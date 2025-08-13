using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using Microsoft.VisualBasic;

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

            return people.Select(person => new PersonViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
            });
        }

        public async Task<PersonViewModel> GetLesseeOrLessorBySpouseId(Guid spouseId)
        {
            if (spouseId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Person person = await _peopleService.GetLesseeOrLessorBySpouseId(spouseId);
            return new PersonViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                Gender = person.Gender.Name,
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
                SpouseId = person.Spouse.Id,
            };
        }

        public async Task<PersonViewModel> GetPersonViewModelByPersonId(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Person person = await _peopleService.GetPersonById(personId);
            if (person == null)
            {
                throw new KeyNotFoundException("Pessoa não encontrada.");
            }

            return new PersonViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                Gender = person.Gender.Name,
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
                SpouseId = person.Spouse?.Id ?? Guid.Empty,
            };
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

        public async Task SavePerson(PersonViewModel personViewModel, PersonViewModel? spouseViewModel = null)
        {
            if (personViewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(personViewModel), "A pessoa não pode ser nula.");
            }

            Person person = new Person
            {
                Id = personViewModel.Id,
                Nome = personViewModel.Name,
                CPF = personViewModel.Document,
                RG = personViewModel.RG,
                DataNascimento = DateTime.Parse(personViewModel.BirthDate),
                Gender = Gender.GetByName<Gender>(personViewModel.Gender),
                EstadoCivil = EstadoCivil.GetByName<EstadoCivil>(personViewModel.MaritalStatus),
                PersonType = PersonType.GetByName<PersonType>(personViewModel.PersonType),
            };

            if (spouseViewModel != null
                && spouseViewModel.IsValid())
            {
                Person spouse = new Person
                {
                    Id = spouseViewModel.Id,
                    Nome = spouseViewModel.Name,
                    CPF = spouseViewModel.Document,
                    RG = spouseViewModel.RG, 
                    DataNascimento = DateTime.Parse(spouseViewModel.BirthDate),
                    Gender = Gender.GetByName<Gender>(spouseViewModel.Gender),
                    PersonType = PersonType.GetByName<PersonType>(spouseViewModel.PersonType),
                };

                person.Spouse = spouse;
            }
            await _peopleService.SavePerson(person);
        }
    }
}
