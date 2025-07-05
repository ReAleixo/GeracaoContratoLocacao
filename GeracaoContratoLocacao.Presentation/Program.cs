using GeracaoContratoLocacao.Presentation.Configurations;
using GeracaoContratoLocacao.Presentation.Forms;

namespace GeracaoContratoLocacao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ControllerConfiguration.Configure();
            Application.Run(new Menu(serviceProvider));
        }
    }
}