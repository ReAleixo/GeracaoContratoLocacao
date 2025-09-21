using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class frmGeradorContrato : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPessoaController _pessoaController;

        public frmGeradorContrato(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _pessoaController = _serviceProvider.GetRequiredService<IPessoaController>();
        }

        private void frmGeradorContrato_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task AdicionarPessoa(object sender, EventArgs e)
        {
            EditPerson CadastroPessoa = new EditPerson(_serviceProvider);
            CadastroPessoa.ShowDialog();

            PessoaViewModel pessoaViewModel = await _pessoaController.BuscarUltimaPessoaCadastrada();

            if (sender is Button button
                && button.Equals(cmdAdicionarLocador))
            {
                cmbLocador.SelectedValue = pessoaViewModel.Id;
            }
            else if (sender is Button anotherButton
                     && anotherButton.Equals(cmdAdicionarLocatario))
            {
                cmbLocatario.SelectedValue = pessoaViewModel.Id;
            }
        }
    }
}