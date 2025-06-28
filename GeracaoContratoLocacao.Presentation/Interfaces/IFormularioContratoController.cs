using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IFormularioContratoController
    {
        void GerarContrato(ContratoViewModel contratoViewModel);
    }
}
