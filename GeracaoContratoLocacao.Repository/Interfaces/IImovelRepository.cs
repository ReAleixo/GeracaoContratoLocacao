using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Base.Interface;
using GeracaoContratoLocacao.Repository.DTOs;

namespace GeracaoContratoLocacao.Repository.Interfaces
{
    public interface IImovelRepository : IRepositoryBase<ImoveisDTO>
    {
        Task<Guid> CadastrarNovoImovel(Imovel imovel);
        Task<Imovel> ObterImovelViaId(Guid idImovel);
        Task SalvarAlteracoes(Imovel imovel);
    }
}
