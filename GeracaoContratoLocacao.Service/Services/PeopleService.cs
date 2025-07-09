using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class PeopleService : IPeopleService
    {
        public PeopleService()
        {

        }

        public Task<IEnumerable<Person>> GetFilteredListOfPeople(
            string? personName = null, string? personDocument = null, bool? showLessee = null, bool? showLessor = null)
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetPersonById(Guid personId)
        {
            throw new NotImplementedException();
        }

        public Task RemovePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
