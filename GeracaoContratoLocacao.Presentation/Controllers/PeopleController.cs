using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class PeopleController : IPeopleController
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

        public async Task<IEnumerable<PersonViewModel>> GetFilteredListOfAllPeopleViewModel(FiltersPersonViewModel filters)
        {
            List<Person> people = (await _peopleService.GetFilteredListOfPeople(
                                        filters.Name, filters.Document, filters.ShowLessee, filters.ShowLessor)).ToList();

            return people.Select(p => new PersonViewModel
            {
                Id = p.Id,
                Name = p.Nome,
                Document = p.CPF,
                RG = p.RG,
                BirthDate = p.DataNascimento,
                Category = p.IsLessor ? "Locador" : "Locatário",
                LogicalStatus = p.LogicalStatus.Name,
                MaritalStatus = p.EstadoCivil.Name,
            });
        }

        public async Task RemovePerson(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Person person = await _peopleService.GetPersonById(personId);
            await _peopleService.RemovePerson(person);
        }
    }
}
