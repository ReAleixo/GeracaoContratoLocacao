using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.Utils;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class PainelPessoas : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPessoaController _peopleController;

        private FiltrosPessoaViewModel filtersPersonViewModel;

        public PainelPessoas(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _peopleController = _serviceProvider.GetRequiredService<IPessoaController>();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cmdFilter_Click(object sender, EventArgs e)
        {
            try
            {
                filtersPersonViewModel = new FiltrosPessoaViewModel(
                    txtNameFilter.Text,
                    txtCPFFilter.Text,
                    chkShowLesseeFilter.Checked,
                    chkShowLessorFilter.Checked);

                await SetDataGridViewDataSource();
                cmdAlter.Visible = cmdRemove.Visible =
                    dtgPeople.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void cmdAlter_Click(object sender, EventArgs e)
        {
            try
            {
                Guid personId = Guid.Parse(dtgPeople.CurrentRow.Cells["PersonId"].Value.ToString());

                if (dtgPeople.CurrentRow.Cells["Category"].Value.ToString().Equals(TipoPessoa.Spouse.Name))
                {
                    PessoaViewModel personViewModel = await _peopleController.BuscarPessoaViaIdConjuge(personId);
                    personId = personViewModel.Id;  
                }

                CadastroPessoa editPerson = new CadastroPessoa(_serviceProvider, personId);
                editPerson.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar alterar pessoa:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            CadastroPessoa editPerson = new CadastroPessoa(_serviceProvider);
            editPerson.ShowDialog();
        }

        private async void cmdRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a remoção do registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Guid personId = Guid.Parse(dtgPeople.CurrentRow.Cells["PersonId"].Value.ToString());
                await _peopleController.RemoverPessoa(personId);

                await SetDataGridViewDataSource();
                cmdAlter.Visible = cmdRemove.Visible =
                    dtgPeople.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar remover pessoa:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SetDataGridViewDataSource()
        {
            List<PessoaViewModel> peopleViewModel = (await _peopleController.BuscarPessoasPorFiltro(filtersPersonViewModel)).ToList();

            object[] SourceToGrid = peopleViewModel.Select(it => new
            {
                PersonId = it.Id,
                PersonName = it.Name,
                Document = it.Document,
                Category = it.PersonType,
            }).ToArray();

            dtgPeople.DataSource = SourceToGrid;
        }

        private void txtNameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyLetters(e);
        }

        private void txtCPFFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyCPFMask(sender, e);
        }
    }
}
