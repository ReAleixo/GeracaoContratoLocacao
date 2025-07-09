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
    }
}
