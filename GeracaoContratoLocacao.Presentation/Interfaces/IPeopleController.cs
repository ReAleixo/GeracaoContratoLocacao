using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IPeopleController
    {
        Task<IEnumerable<PersonViewModel>> GetFilteredListOfAllPeopleViewModel(FiltersPersonViewModel filters);
        Task<PersonViewModel> GetPersonViewModelByPersonId(Guid personId);
        Task RemovePerson(Guid personId);
        Task SavePerson(PersonViewModel personViewModel, PersonViewModel? spouseViewModel = null);
        Task<PersonViewModel> GetLesseeOrLessorBySpouseId(Guid spouseId);
    }
}
