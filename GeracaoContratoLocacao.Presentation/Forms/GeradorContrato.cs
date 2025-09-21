using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class frmGeradorContrato : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPessoaController _pessoaController;
        private readonly IImovelController _imovelController;

        public frmGeradorContrato(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _pessoaController = _serviceProvider.GetRequiredService<IPessoaController>();
            _imovelController = _serviceProvider.GetRequiredService<IImovelController>();
        }

        private async void frmGeradorContrato_Load(object sender, EventArgs e)
        {
            await PreencherComboBoxLocador();
            await PreencherComboBoxLocatario();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AdicionarPessoa(object sender, EventArgs e)
        {
            CadastroPessoa cadastroPessoa = new CadastroPessoa(_serviceProvider);
            cadastroPessoa.ShowDialog();

            if (sender is Button button
                && button.Equals(cmdAdicionarLocador))
            {
                await PreencherComboBoxLocador();
            }
            else if (sender is Button anotherButton
                     && anotherButton.Equals(cmdAdicionarLocatario))
            {
                await PreencherComboBoxLocatario();
            }
        }

        private async void AdicionarImovel(object sender, EventArgs e)
        {
            if (cmbLocador.SelectedValue == default)
            {
                MessageBox.Show("Não foi selecionado nenhum locador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastroImovel cadastroImovel = new CadastroImovel(_serviceProvider, idProprietario: (Guid)cmbLocador.SelectedValue);
            cadastroImovel.ShowDialog();

            await PreencherComboBoxImoveis();
        }

        private async void cmbLocador_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbLocador.SelectedValue != default
                && (Guid)cmbLocador.SelectedValue != Guid.Empty)
            {
                grbImovel.Enabled = true;
                await PreencherComboBoxImoveis();
            }
            else
            {
                grbImovel.Enabled = false;
                cmbImoveisLocador.DataSource = null;
            }
        }

        private async Task PreencherComboBoxImoveis()
        {
            var locadorId = (Guid)cmbLocador.SelectedValue;
            cmbImoveisLocador.DataSource = await _imovelController.ObterImoveisPorProprietario(locadorId);
            cmbImoveisLocador.DisplayMember = nameof(ImovelViewModel.Descricao);
            cmbImoveisLocador.ValueMember = nameof(ImovelViewModel.Id);
        }

        private async Task PreencherComboBoxLocador()
        {
            cmbLocador.DataSource = await _pessoaController.BuscarLocadores();
            cmbLocador.DisplayMember = nameof(PessoaViewModel.Name);
            cmbLocador.ValueMember = nameof(PessoaViewModel.Id);
        }

        private async Task PreencherComboBoxLocatario()
        {
            cmbLocatario.DataSource = await _pessoaController.BuscarLocatarios();
            cmbLocatario.DisplayMember = nameof(PessoaViewModel.Name);
            cmbLocatario.ValueMember = nameof(PessoaViewModel.Id);
        }
    }
}