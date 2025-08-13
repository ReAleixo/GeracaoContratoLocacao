using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Base.Interface;
using GeracaoContratoLocacao.Repository.DTOs;

namespace GeracaoContratoLocacao.Repository.Interfaces
{
    public interface IPeopleRepository : IRepositoryBase<PeopleDTO>
    {
        Task<IEnumerable<Person>> GetFilteredPeopleAsync(
            string? name = null, string? document = null, bool? isLessor = null, bool? isLessee = null);
        Task<Person> GetPersonById(Guid personId);
        Task RemovePerson(Person person);
        Task AddPerson(Person person);
        Task UpdatePerson(Person person);
        Task<Person> GetLesseeOrLessorBySpouseId(Guid spouseId);
    }
}
