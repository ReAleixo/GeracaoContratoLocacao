using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Base.Interface;
using GeracaoContratoLocacao.Repository.DTOs;

namespace GeracaoContratoLocacao.Repository.Interfaces
{
    public interface IImovelRepository : IRepositoryBase<ImovelDTO>
    {
        Task<Guid> CadastrarNovoImovel(Imovel imovel);
        Task<Imovel> BuscarImovelPorId(Guid idImovel);
        Task SalvarAlteracoes(Imovel imovel);
        Task<IEnumerable<Imovel>> BuscarTodosImoveis();
        Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario);
        Task RemoverImovel(Guid idImovel);
    }
}
