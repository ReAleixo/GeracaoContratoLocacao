using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IPeopleService
    {
        Task<IEnumerable<Person>> GetFilteredListOfPeople(
            string? personName = null, string? personDocument = null, bool? showLessee = null, bool? showLessor = null);
        Task<Person> GetPersonById(Guid personId);
        Task RemovePerson(Person person);
        Task SavePerson(Person person, Person? spouse = null);
    }
}
