using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IImovelService
    {
        Task SalvarAlteracoes(Imovel imovel);
        Task ExcluirImovel(Imovel imovel);
        Task<Guid> CadastrarNovoImovel(Imovel imovel);
        Task<Imovel> ObterImovelViaId(Guid idImovel);
    }
}
