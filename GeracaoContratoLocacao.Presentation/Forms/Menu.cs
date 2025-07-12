namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class Menu : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Menu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdHousesPanel_Click(object sender, EventArgs e)
        {
            PainelImoveis housesPanel = new PainelImoveis(_serviceProvider);
            housesPanel.ShowDialog();
        }

        private void cmdPeoplePanel_Click(object sender, EventArgs e)
        {
            PeoplePanel peoplePanel = new PeoplePanel(_serviceProvider);
            peoplePanel.ShowDialog();
        }
    }
}
