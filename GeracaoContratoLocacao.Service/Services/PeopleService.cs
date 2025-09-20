using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
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

        public async Task<Person> GetLesseeOrLessorBySpouseId(Guid spouseId)
        {
            if (spouseId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }
            return await _peopleRepository.GetLesseeOrLessorBySpouseId(spouseId);
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

        public async Task SavePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }

            var existingPerson = await _peopleRepository.GetPersonById(person.Id);
            if (existingPerson != null)
            {
                existingPerson.Nome = person.Nome;
                existingPerson.CPF = person.CPF;
                existingPerson.RG = person.RG;
                existingPerson.DataNascimento = person.DataNascimento;
                existingPerson.Gender = person.Gender;
                existingPerson.EstadoCivil = person.EstadoCivil;
                existingPerson.PersonType = person.PersonType;

                if (person.Spouse != null
                    && !person.Spouse.IsNullOrEmpty())
                {
                    existingPerson.Spouse = new Person
                    {
                        Id = person.Spouse.Id,
                        Nome = person.Spouse.Nome,
                        CPF = person.Spouse.CPF,
                        RG = person.Spouse.RG,
                        DataNascimento = person.Spouse.DataNascimento,
                        Gender = person.Spouse.Gender,
                        LogicalStatus = LogicalStatus.Active,
                        PersonType = PersonType.Spouse
                    };
                }
                await _peopleRepository.UpdatePerson(existingPerson);
                return;
            }

            person.LogicalStatus = LogicalStatus.Active;

            if (person.Spouse != null
                && !person.Spouse.IsNullOrEmpty())
            {
                person.Spouse = new Person
                {
                    Id = person.Spouse.Id,
                    Nome = person.Spouse.Nome,
                    CPF = person.Spouse.CPF,
                    RG = person.Spouse.RG,
                    DataNascimento = person.Spouse.DataNascimento,
                    Gender = person.Spouse.Gender,
                    LogicalStatus = LogicalStatus.Active,
                    PersonType = PersonType.Spouse
                };
            }

            await _peopleRepository.AddPerson(person);
        }
    }
}
