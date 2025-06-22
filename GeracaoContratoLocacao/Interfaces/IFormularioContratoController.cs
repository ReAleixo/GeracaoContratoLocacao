using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IFormularioContratoController
    {
        Task GerarContrato(ContratoViewModel contratoViewModel);
    }
}
