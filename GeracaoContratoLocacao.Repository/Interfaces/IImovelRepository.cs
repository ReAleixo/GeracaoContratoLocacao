using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Base.Interface;
using GeracaoContratoLocacao.Repository.DTOs;

namespace GeracaoContratoLocacao.Repository.Interfaces
{
    public interface IImovelRepository : IRepositoryBase<ImoveisDTO>
    {
        Task<Guid> CadastrarNovoImovel(House imovel);
        Task<House> ObterImovelViaId(Guid idImovel);
        Task SalvarAlteracoes(House imovel);
        Task<IEnumerable<House>> GetAllHouses();
    }
}
