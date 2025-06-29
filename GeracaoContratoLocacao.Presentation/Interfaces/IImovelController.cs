using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IImovelController
    {
        Task<ImovelViewModel> GetImovelViewModel(Guid idImovel);
        Task<IEnumerable<Locador>> ObterLocadores();
        Task SalvarAlteracoes(ImovelViewModel viewModel);
        Task ExcluirImovel(Guid idImovel);
        Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel);
    }
}
