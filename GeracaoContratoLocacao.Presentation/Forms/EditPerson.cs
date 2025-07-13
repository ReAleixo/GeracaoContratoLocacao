using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.Enums.Base;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class EditPerson : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPeopleController _peopleController;
        private Guid _personId;
        private Guid _spouseId = default;

        public EditPerson(IServiceProvider serviceProvider,
                          Guid personId = default)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _peopleController = _serviceProvider.GetRequiredService<IPeopleController>();
            _personId = personId;
        }

        private async void EditPerson_Load(object sender, EventArgs e)
        {
            List<Gender> GenderList =
            [
                new Gender(default, default), .. Gender.GetAll<Gender>().ToList()
            ];
            cmbGender.DataSource = GenderList;
            cmbGender.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbGender.ValueMember = Enumeration.ValueMemberAttribute;

            List<EstadoCivil> MaritalStatusList =
            [
                new EstadoCivil(default, default), .. EstadoCivil.GetAll<EstadoCivil>().ToList()
            ];
            cmbMaritalStatus.DataSource = MaritalStatusList;
            cmbMaritalStatus.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbMaritalStatus.ValueMember = Enumeration.ValueMemberAttribute;

            tabPessoas.TabPages.Remove(tabConjuge);
            if (_personId == default)
            {
                return;
            }

            PersonViewModel personViewModel = await _peopleController.GetPersonViewModelByPersonId(_personId);

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
            try
            {
                PersonViewModel personViewModel = new PersonViewModel
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

                if (!EstadoCivil.PossuiConjuge.Any(e => e.Name.Equals(personViewModel.MaritalStatus)))
                {
                    await _peopleController.SavePerson(personViewModel);
                    Close();
                    return;
                }

                personViewModel.SpouseId = _spouseId == default ? Guid.NewGuid() : _spouseId;

                PersonViewModel spouseViewModel = new PersonViewModel
                {
                    Id = personViewModel.SpouseId.Value,
                    Name = txtSpouseName.Text,
                    Document = txtSpouseDocument.Text,
                    RG = txtSpouseRG.Text,
                    BirthDate = txtSpouseBirthDate.Text,
                    Gender = cmbSpouseGender.Text,
                    PersonType = PersonType.Spouse.Name,
                };

                await _peopleController.SavePerson(personViewModel, spouseViewModel);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AlimentarCamposComViewModel(PersonViewModel personViewModel)
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
                PersonViewModel SpouseViewModel = await _peopleController.GetPersonViewModelByPersonId(personViewModel.SpouseId.Value);
                if (SpouseViewModel.IsNullOrEmpty())
                {
                    MessageBox.Show("Cônjuge não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _spouseId = SpouseViewModel.Id;

                tabPessoas.TabPages.Add(tabConjuge);

                List<Gender> GenderList = new List<Gender>
                {
                    new Gender(default, default)
                };
                GenderList.AddRange(Gender.GetAll<Gender>().ToList());
                cmbSpouseGender.DataSource = GenderList;
                cmbSpouseGender.DisplayMember = Enumeration.DisplayMemberAttribute;
                cmbSpouseGender.ValueMember = Enumeration.ValueMemberAttribute;

                txtSpouseName.Text = SpouseViewModel.Name;
                txtSpouseDocument.Text = SpouseViewModel.Document;
                txtSpouseRG.Text = SpouseViewModel.RG;
                cmbGender.Text = SpouseViewModel.Gender;
                txtSpouseBirthDate.Text = SpouseViewModel.BirthDate;
            }
        }
    }
}
