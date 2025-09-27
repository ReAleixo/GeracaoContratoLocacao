using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IImovelController
    {
        Task<ImovelViewModel> GetHouseViewModelByHouseId(Guid idImovel);
        Task<IEnumerable<ImovelViewModel>> GetAllHouseViewModelList(string? lessorNameFilter = null, bool? showHouseRentedFilter = null);
        Task SaveChanges(ImovelViewModel viewModel);
        Task DeleteHouse(Guid idImovel);
        Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel);
        Task<IEnumerable<ImovelViewModel>> BuscarImoveisPorProprietario(Guid idProprietario);
    }
}
