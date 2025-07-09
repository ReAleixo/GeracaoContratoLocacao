using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IPeopleController
    {
        Task<IEnumerable<PersonViewModel>> GetFilteredListOfAllPeopleViewModel(FiltersPersonViewModel filters);
        Task RemovePerson(Guid personId);
    }
}
