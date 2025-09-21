using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IContratoController
    {
        Task GerarContrato(ContratoViewModel contratoViewModel);
    }
}
