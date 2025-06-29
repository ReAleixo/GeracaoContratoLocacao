using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IImovelService
    {
        Task<IEnumerable<Locador>> ObterLocadores();
        Task SalvarAlteracoes(Imovel imovel);
        Task ExcluirImovel(int idImovel);
        Task<Guid> CadastrarNovoImovel(Imovel imovel, Locador locador);
        Task<Imovel> GetImovelById(Guid idImovel);
    }
}
