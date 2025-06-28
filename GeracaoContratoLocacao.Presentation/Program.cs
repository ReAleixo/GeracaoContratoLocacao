using GeracaoContratoLocacao.Presentation.Configurations;

namespace GeracaoContratoLocacao
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var serviceProvider = ControllerConfiguration.Configure();
            Application.Run(new FormularioContrato(serviceProvider));
        }
    }
}