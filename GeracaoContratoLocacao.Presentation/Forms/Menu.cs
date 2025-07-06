using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            PainelImoveis painelImoveis = new PainelImoveis(_serviceProvider);
            painelImoveis.ShowDialog();
        }
    }
}
