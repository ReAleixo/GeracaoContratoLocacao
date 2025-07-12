namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class EditPerson : Form
    {
        public EditPerson(IServiceProvider serviceProvider,
                          Guid personId = default)
        {
            InitializeComponent();
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {




            Close();
        }
    }
}
