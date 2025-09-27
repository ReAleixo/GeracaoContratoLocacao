using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.Utils;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class frmGeradorContrato : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPessoaController _pessoaController;
        private readonly IImovelController _imovelController;
        private readonly IContratoController _contratoController;

        public frmGeradorContrato(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _pessoaController = _serviceProvider.GetRequiredService<IPessoaController>();
            _imovelController = _serviceProvider.GetRequiredService<IImovelController>();
            _contratoController = _serviceProvider.GetRequiredService<IContratoController>();
        }

        private async void frmGeradorContrato_Load(object sender, EventArgs e)
        {
            await PreencherComboBoxLocador();
            await PreencherComboBoxLocatario();
            PreencherComboBoxModeloContrato();
            txtDataGeracaoContrato.Text = DateTime.Today.ToShortDateString();
        }

        private async void cmdGerar_Click(object sender, EventArgs e)
        {
            if (cmbImoveisLocador.DataSource == default)
            {
                MessageBox.Show("Não foi selecionado nenhum locador.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (cmbImoveisLocador.Items.Count.Equals(default))
            {
                MessageBox.Show("Esse locador não possui imóveis cadastrados.\nPara prosseguir é necessário cadastrar um imóvel.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                var contratoViewModel = new ContratoViewModel
                    (
                        cmbLocador.SelectedValue.ToString(),
                        cmbLocatario.SelectedValue.ToString(),
                        cmbImoveisLocador.SelectedValue.ToString(),
                        cmbModeloContrato.SelectedValue.ToString(),
                        txtPrazo.Text,
                        txtDataInicio.Text,
                        txtDataGeracaoContrato.Text
                    );

                await _contratoController.GerarContrato(contratoViewModel);

                MessageBox.Show("Contrato gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar contrato:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void AdicionarPessoa(object sender, EventArgs e)
        {
            if (sender is Button button
                && button.Equals(cmdAdicionarLocador))
            {
                CadastroPessoa cadastroPessoa = new CadastroPessoa(_serviceProvider, tipoPessoa: TipoPessoa.Locador);
                cadastroPessoa.ShowDialog();
                await PreencherComboBoxLocador();
            }
            else if (sender is Button anotherButton
                     && anotherButton.Equals(cmdAdicionarLocatario))
            {
                CadastroPessoa cadastroPessoa = new CadastroPessoa(_serviceProvider, tipoPessoa: TipoPessoa.Locatario);
                cadastroPessoa.ShowDialog();
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
            cmbImoveisLocador.DataSource = (await _imovelController.BuscarImoveisPorProprietario(locadorId)).ToList();
            cmbImoveisLocador.DisplayMember = nameof(ImovelViewModel.EnderecoCompleto);
            cmbImoveisLocador.ValueMember = nameof(ImovelViewModel.Id);
        }

        private async Task PreencherComboBoxLocador()
        {
            cmbLocador.DisplayMember = nameof(PessoaViewModel.Name);
            cmbLocador.ValueMember = nameof(PessoaViewModel.Id);
            cmbLocador.DataSource = (await _pessoaController.BuscarLocadores()).ToList();
        }

        private async Task PreencherComboBoxLocatario()
        {
            cmbLocatario.DataSource = (await _pessoaController.BuscarLocatarios()).ToList();
            cmbLocatario.DisplayMember = nameof(PessoaViewModel.Name);
            cmbLocatario.ValueMember = nameof(PessoaViewModel.Id);
        }

        private void PreencherComboBoxModeloContrato()
        {
            cmbModeloContrato.DataSource = ModeloContrato.PreencherComboBox<ModeloContrato>();
            cmbModeloContrato.DisplayMember = ModeloContrato.DisplayMemberAttribute;
            cmbModeloContrato.ValueMember = ModeloContrato.ValueMemberAttribute;
        }

        private void FormatacaoCamposData(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyDateMask(sender, e);
        }

        private void txtPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyDigits(e);
        }
    }
}