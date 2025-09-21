using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.Enums.Base;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.Utils;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class CadastroPessoa : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPessoaController _peopleController;

        private Guid _personId = default, _spouseId = default;

        public CadastroPessoa(IServiceProvider serviceProvider,
                          Guid personId = default)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _peopleController = _serviceProvider.GetRequiredService<IPessoaController>();
            _personId = personId;
        }

        private async void EditPerson_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Gender.GetAllToFillComboBox();
            cmbGender.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbGender.ValueMember = Enumeration.ValueMemberAttribute;
            cmbSpouseGender.DataSource = Gender.GetAllToFillComboBox();
            cmbSpouseGender.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbSpouseGender.ValueMember = Enumeration.ValueMemberAttribute;

            cmbMaritalStatus.DataSource = EstadoCivil.GetAllToFillComboBox();
            cmbMaritalStatus.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbMaritalStatus.ValueMember = Enumeration.ValueMemberAttribute;


            tabPessoas.TabPages.Remove(tabConjuge);

            if (_personId == default)
            {
                return;
            }

            PessoaViewModel personViewModel = await _peopleController.BuscarPessoaViaId(_personId);

            if (personViewModel.IsNullOrEmpty())
            {
                MessageBox.Show("Pessoa não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            await AlimentarCamposComViewModel(personViewModel);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cmdSalvar_Click(object sender, EventArgs e)
        {
            if (!rdbLessor.Checked && !rdbLessee.Checked)
            {
                MessageBox.Show($"Erro ao salvar:\nNão foi informado se essa pessoa é locador ou locatário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PessoaViewModel personViewModel = new PessoaViewModel
            {
                Id = _personId == default ? Guid.NewGuid() : _personId,
                Name = txtName.Text,
                Document = txtDocument.Text,
                RG = txtRG.Text,
                BirthDate = txtBirthDate.Text,
                Gender = cmbGender.Text,
                PersonType = rdbLessor.Checked ? PersonType.Lessor.Name : PersonType.Lessee.Name,
                MaritalStatus = cmbMaritalStatus.Text
            };

            try
            {
                if (personViewModel.IsValid()
                    && !EstadoCivil.PossuiConjuge.Any(e => e.Name.Equals(personViewModel.MaritalStatus)))
                {
                    await _peopleController.CadastrarPessoa(personViewModel);
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                personViewModel.SpouseId = _spouseId == default ? Guid.NewGuid() : _spouseId;
                PessoaViewModel spouseViewModel = new PessoaViewModel
                {
                    Id = personViewModel.SpouseId.Value,
                    Name = txtSpouseName.Text,
                    Document = txtSpouseDocument.Text,
                    RG = txtSpouseRG.Text,
                    BirthDate = txtSpouseBirthDate.Text,
                    Gender = cmbSpouseGender.Text,
                    PersonType = PersonType.Spouse.Name,
                };

                if (spouseViewModel.IsValid())
                {
                    await _peopleController.CadastrarPessoa(personViewModel, spouseViewModel);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar cônjuge:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AlimentarCamposComViewModel(PessoaViewModel personViewModel)
        {
            txtName.Text = personViewModel.Name;
            txtDocument.Text = personViewModel.Document;
            txtRG.Text = personViewModel.RG;
            txtBirthDate.Text = personViewModel.BirthDate;
            cmbGender.Text = personViewModel.Gender;
            cmbMaritalStatus.Text = personViewModel.MaritalStatus;
            rdbLessor.Checked = personViewModel.PersonType.Equals("Locador");
            rdbLessee.Checked = !rdbLessor.Checked;

            if (personViewModel.SpouseId.HasValue
                && personViewModel.SpouseId.Value != default)
            {
                PessoaViewModel SpouseViewModel = await _peopleController.BuscarPessoaViaId(personViewModel.SpouseId.Value);
                if (SpouseViewModel.IsNullOrEmpty())
                {
                    MessageBox.Show("Cônjuge não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _spouseId = SpouseViewModel.Id;

                if (!tabPessoas.TabPages.Contains(tabConjuge))
                {
                    tabPessoas.TabPages.Add(tabConjuge);
                }

                txtSpouseName.Text = SpouseViewModel.Name;
                txtSpouseDocument.Text = SpouseViewModel.Document;
                txtSpouseRG.Text = SpouseViewModel.RG;
                cmbSpouseGender.Text = SpouseViewModel.Gender;
                txtSpouseBirthDate.Text = SpouseViewModel.BirthDate;
            }
        }

        private void Document_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyCPFMask(sender, e);
        }

        private void Date_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyDateMask(sender, e);
        }

        private void cmbMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearSpouseFields();

            if (int.TryParse(cmbMaritalStatus.SelectedValue.ToString(), out int idMaritalStatus))
            {
                if (EstadoCivil.PossuiConjuge.Any(ms => ms.Id == idMaritalStatus)
                    && !tabPessoas.TabPages.Contains(tabConjuge))
                {
                    tabPessoas.TabPages.Add(tabConjuge);
                    return;
                }
                tabPessoas.TabPages.Remove(tabConjuge);
            }
        }

        private void ClearSpouseFields()
        {
            txtSpouseName.Clear();
            txtSpouseDocument.Clear();
            txtSpouseRG.Clear();
            txtSpouseBirthDate.Clear();
            cmbSpouseGender.SelectedIndex = -1;
        }
    }
}
