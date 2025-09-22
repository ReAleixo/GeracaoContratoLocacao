using GeracaoContratoLocacao.Presentation.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class PainelImoveis : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IImovelController _imovelController;

        public PainelImoveis(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _imovelController = _serviceProvider.GetRequiredService<IImovelController>();
        }

        private void cmdVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void PainelImoveis_Load(object sender, EventArgs e)
        {
            dgvHouses.DataSource = await _imovelController.GetAllHouseViewModelList();

            cmdAlterar.Visible = cmdRemover.Visible =
                dgvHouses.Rows.Count > 0;
        }

        private void cmdAlterar_Click(object sender, EventArgs e)
        {
            Guid houseId = Guid.Parse(dgvHouses.CurrentRow.Cells["Id"].Value.ToString());
            CadastroImovel cadastroImovel = new CadastroImovel(_serviceProvider, houseId);
            cadastroImovel.ShowDialog();
        }

        private void cmdAdicionar_Click(object sender, EventArgs e)
        {
            CadastroImovel cadastroImovel = new CadastroImovel(_serviceProvider);
            cadastroImovel.ShowDialog();
        }

        private async void cmdRemover_Click(object sender, EventArgs e)
        {
            Guid houseId = Guid.Parse(dgvHouses.CurrentRow.Cells["Id"].Value.ToString());
            await _imovelController.DeleteHouse(houseId);
        }

        private void FilterHousesGrid(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFiltroLocador.Text))
            {
                dgvHouses.DataSource = _imovelController.GetAllHouseViewModelList(txtFiltroLocador.Text, chkFiltroExibirLocados.Checked).Result;
                return;
            }
            dgvHouses.DataSource = _imovelController.GetAllHouseViewModelList(showHouseRentedFilter: chkFiltroExibirLocados.Checked).Result;
        }
    }
}
