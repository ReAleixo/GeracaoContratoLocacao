using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IImovelService
    {
        Task SaveChanges(House imovel);
        Task DeleteHouse(House imovel);
        Task<Guid> CadastrarNovoImovel(House imovel);
        Task<House> GetHouseById(Guid idImovel);
        Task<IEnumerable<House>> GetAllHouses();
    }
}
