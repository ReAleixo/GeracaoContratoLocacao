using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class FormularioContratoController : IFormularioContratoController
    {
        public FormularioContratoController()
        {
        }

        public Task GerarContrato(ContratoViewModel contratoViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
