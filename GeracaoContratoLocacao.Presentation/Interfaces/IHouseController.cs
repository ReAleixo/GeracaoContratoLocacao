using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IHouseController
    {
        Task<HouseViewModel> GetHouseViewModelByHouseId(Guid idImovel);
        Task<IEnumerable<HouseViewModel>> GetAllHouseViewModelList(string? lessorNameFilter = null, bool? showHouseRentedFilter = null);
        Task<IEnumerable<Pessoa>> ObterLocadores();
        Task SaveChanges(HouseViewModel viewModel);
        Task DeleteHouse(Guid idImovel);
        Task<Guid> CadastrarNovoImovel(HouseViewModel viewModel);
    }
}
