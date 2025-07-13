using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.Utils;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class PeoplePanel : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPeopleController _peopleController;

        private FiltersPersonViewModel filtersPersonViewModel;

        public PeoplePanel(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _peopleController = _serviceProvider.GetRequiredService<IPeopleController>();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cmdFilter_Click(object sender, EventArgs e)
        {
            try
            {
                filtersPersonViewModel = new FiltersPersonViewModel(
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

        private void cmdAlter_Click(object sender, EventArgs e)
        {
            Guid personId = Guid.Parse(dtgPeople.CurrentRow.Cells["PersonId"].Value.ToString());
            EditPerson editPerson = new EditPerson(_serviceProvider, personId);
            editPerson.ShowDialog();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            EditPerson editPerson = new EditPerson(_serviceProvider);
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
                await _peopleController.RemovePerson(personId);

                await SetDataGridViewDataSource();
                cmdAlter.Visible = cmdRemove.Visible =
                    dtgPeople.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao remover pessoa:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SetDataGridViewDataSource()
        {
            List<PersonViewModel> peopleViewModel = (await _peopleController.GetFilteredListOfAllPeopleViewModel(filtersPersonViewModel)).ToList();

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
            TextBoxKeyPress.OnlyLetters(sender, e);
        }

        private void txtCPFFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyCPFMask(sender, e);
        }
    }
}
