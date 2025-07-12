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
                IsLessor = true,
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
                IsLessor = true,
                Houses = new List<House>()
            });
            peopleDB.Add(new Person
            {
                Id = Guid.NewGuid(),
                Nome = "Jane Smith",
                CPF = "10987654321",
                RG = "87654321",
                DataNascimento = new DateTime(1985, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                LogicalStatus = LogicalStatus.Active,
                IsLessor = false
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
                IsLessor = false
            });
        }

        public async Task<IEnumerable<Person>> GetFilteredPeopleAsync(string? name = null, string? document = null, bool? showLessor = null, bool? showLessee = null)
        {
            List<Person> filteredPeople = peopleDB.Where(p => p.LogicalStatus == LogicalStatus.Active).ToList();
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
                filteredPeople = filteredPeople.Where(p => p.IsLessor).ToList();
            }
            else if (showLessee.HasValue && showLessee.Value
                     && (!showLessor.HasValue
                         || (showLessor.HasValue && !showLessor.Value)))
            {
                filteredPeople = filteredPeople.Where(p => !p.IsLessor).ToList();
            }
            return filteredPeople;
        }

        public async Task<Person> GetPersonById(Guid personId)
        {
            var person = peopleDB.FirstOrDefault(p => p.Id == personId && p.LogicalStatus == LogicalStatus.Active);
            if (person == null || person.IsNullOrEmpty())
            {
                throw new KeyNotFoundException($"Person with ID {personId} not found.");
            }
            return person;
        }

        public async Task RemovePerson(Person person)
        {
            if (person == null || person.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(person), "Person cannot be null or empty.");
            }
            var existingPerson = peopleDB.FirstOrDefault(p => p.Id == person.Id);
            if (existingPerson == null)
            {
                throw new KeyNotFoundException($"Person with ID {person.Id} not found.");
            }
            existingPerson.LogicalStatus = LogicalStatus.Inactive;
        }
    }
}
