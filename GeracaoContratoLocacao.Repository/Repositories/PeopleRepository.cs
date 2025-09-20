using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using System.Data;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class PeopleRepository : RepositoryBase<PeopleDTO>, IPeopleRepository
    {
        private List<Person> peopleDB = new List<Person>();

        public PeopleRepository()
        {
            peopleDB.Add(new Person
            {
                Id = Guid.NewGuid(),
                Nome = "John Doe",
                CPF = "12345678901",
                RG = "12345678",
                DataNascimento = new DateTime(1990, 1, 1),
                EstadoCivil = EstadoCivil.Solteiro,
                LogicalStatus = LogicalStatus.Active,
                PersonType = PersonType.Lessor,
                Houses = new List<House>()
            });
            peopleDB.Add(new Person
            {
                Id = Guid.NewGuid(),
                Nome = "Jhon Travolta",
                CPF = "006.102.760-00",
                RG = "12345678",
                DataNascimento = new DateTime(1976, 11, 7),
                EstadoCivil = EstadoCivil.UniaoEstavel,
                LogicalStatus = LogicalStatus.Active,
                PersonType = PersonType.Lessor,
                Houses = new List<House>()
            });
            peopleDB.Add(new Person
            {
                Id = Guid.NewGuid(),
                Nome = "Jane Smith",
                CPF = "10987654321",
                RG = "87654321",
                Gender = Gender.Female,
                DataNascimento = new DateTime(1985, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                LogicalStatus = LogicalStatus.Active,
                PersonType = PersonType.Lessee,
            });
            peopleDB.Add(new Person
            {
                Id = Guid.NewGuid(),
                Nome = "Jony Treaver",
                CPF = "41522476067",
                RG = "87654321",
                DataNascimento = new DateTime(2001, 2, 18),
                EstadoCivil = EstadoCivil.Casado,
                LogicalStatus = LogicalStatus.Active,
                PersonType = PersonType.Lessee,
            });
        }

        public async Task<IEnumerable<Person>> GetFilteredPeopleAsync(string? name = null, string? document = null, bool? showLessor = null, bool? showLessee = null)
        {
            List<Person> filteredPeople = peopleDB.Where(p => p.LogicalStatus == LogicalStatus.Active).ToList();
            filteredPeople.AddRange(peopleDB.Where(p => p.Spouse != null).Select(p => p.Spouse));
            if (!string.IsNullOrEmpty(name))
            {
                filteredPeople = filteredPeople.Where(p => p.Nome.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (!string.IsNullOrEmpty(document))
            {
                filteredPeople = filteredPeople.Where(p => p.CPF.Contains(document) || p.RG.Contains(document)).ToList();
            }
            if (showLessor.HasValue && showLessor.Value
                && (!showLessee.HasValue
                    || (showLessee.HasValue && !showLessee.Value)))
            {
                filteredPeople = filteredPeople.Where(p => p.PersonType == PersonType.Lessor).ToList();
            }
            else if (showLessee.HasValue && showLessee.Value
                     && (!showLessor.HasValue
                         || (showLessor.HasValue && !showLessor.Value)))
            {
                filteredPeople = filteredPeople.Where(p => p.PersonType == PersonType.Lessee).ToList();
            }
            return filteredPeople;
        }

        public async Task<Person> GetPersonById(Guid personId)
        {
            Person person = peopleDB.FirstOrDefault(p => p.Id == personId && p.LogicalStatus == LogicalStatus.Active);
            if (person == null || person.IsNullOrEmpty())
            {
                person = peopleDB.FirstOrDefault(p => p.Spouse?.Id == personId && p.LogicalStatus == LogicalStatus.Active);
                if (person != null)
                {
                    return person.Spouse;
                }
                return default;
            }
            return person;
        }

        public async Task RemovePerson(Person person)
        {
            Person existingPerson = peopleDB.FirstOrDefault(p => p.Id == person.Id);
            if (existingPerson == null)
            {
                throw new KeyNotFoundException($"Person with ID {person.Id} not found.");
            }
            existingPerson.LogicalStatus = LogicalStatus.Inactive;
        }

        public Task AddPerson(Person person)
        {
            peopleDB.Add(person);
            return Task.CompletedTask;
        }

        public async Task UpdatePerson(Person person)
        {
            peopleDB.Remove(await GetPersonById(person.Id));
            await AddPerson(person);
        }

        public async Task<Person> GetLesseeOrLessorBySpouseId(Guid spouseId)
        {
            return peopleDB.FirstOrDefault(p => p.Spouse?.Id == spouseId && p.LogicalStatus == LogicalStatus.Active);
        }
    }
}
