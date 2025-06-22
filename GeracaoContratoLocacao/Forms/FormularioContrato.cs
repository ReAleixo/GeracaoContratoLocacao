using GeracaoContratoLocacao.Presentation.Controllers;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao
{
    public partial class FormularioContrato : Form
    {
        private readonly IFormularioContratoController _controller;

        public FormularioContrato()
        {
            InitializeComponent();
            _controller = new FormularioContratoController();
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
                    (int)cmbNumeroCasa.SelectedValue,
                    txtValorAluguel.Text);

                _controller.GerarContrato(contratoViewModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar contrato:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
