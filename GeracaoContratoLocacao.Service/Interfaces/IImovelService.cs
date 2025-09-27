using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IImovelService
    {
        Task AlterarImovel(Imovel imovel);
        Task RemoverImovel(Guid idImovel);
        Task<Guid> CadastrarNovoImovel(Imovel imovel);
        Task<Imovel> BuscarImovelPorId(Guid idImovel);
        Task<IEnumerable<Imovel>> BuscarTodosImoveis();
        Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario);
    }
}
