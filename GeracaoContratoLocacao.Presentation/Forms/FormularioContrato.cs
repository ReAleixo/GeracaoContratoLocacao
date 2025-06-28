using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.Utils;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao
{
    public partial class FormularioContrato : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IFormularioContratoController _controller;

        public FormularioContrato(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _controller = _serviceProvider.GetService<IFormularioContratoController>();
        }

        private void cmdGerarContrato_Click(object sender, EventArgs e)
        {
            try
            {
                var contratoViewModel = new ContratoViewModel(
                    txtNomeLocatario.Text,
                    txtCPFLocatario.Text,
                    txtRGLocatario.Text,
                    txtDataInicio.Text,
                    txtPrazo.Text,
                    (int)cmbNumeroCasa.SelectedIndex + 1,
                    txtValorAluguel.Text);

                _controller.GerarContrato(contratoViewModel);

                MessageBox.Show("Contrato gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar contrato:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtCPFLocatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyCPFMask(sender, e);
        }

        private void txtDataInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyDateMask(sender, e);
        }

        private void txtValorAluguel_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxMasks.ApplyMoneyMask(sender, e);
        }

        private void txtPrazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxKeyPress.OnlyDigits(sender, e);
        }
    }
}
