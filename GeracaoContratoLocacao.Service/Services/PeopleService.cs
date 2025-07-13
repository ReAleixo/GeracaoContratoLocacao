using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class PeopleService : IPeopleService
    {
        private readonly IPeopleRepository _peopleRepository;
        public PeopleService(IPeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public async Task<IEnumerable<Person>> GetFilteredListOfPeople(
            string? personName = null, string? personDocument = null, bool? showLessee = null, bool? showLessor = null)
        {
            return await _peopleRepository.GetFilteredPeopleAsync(personName, personDocument, showLessor, showLessee);
        }

        public async Task<Person> GetPersonById(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Person person = await _peopleRepository.GetPersonById(personId);
            if (person == null)
            {
                throw new KeyNotFoundException($"Pessoa com ID {personId} não encontrada.");
            }
            return person;
        }

        public Task RemovePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }
            return _peopleRepository.RemovePerson(person);
        }

        public Task SavePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }
            return _peopleRepository.SavePerson(person);
        }
    }
}
