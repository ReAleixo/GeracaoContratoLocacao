using Dapper;
using Dapper.Contrib.Extensions;
using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using System.Data;
using System.Text;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class PeopleRepository : RepositoryBase<PeopleDTO>, IPeopleRepository
    {
        private readonly IDbConnection _dbConnection;

        public async Task<IEnumerable<Person>> GetFilteredPeopleAsync(string? name = null, string? document = null, bool? showLessor = null, bool? showLessee = null)
        {
            StringBuilder sql = new StringBuilder($@"SELECT * FROM People WHERE LogicalStatus = {LogicalStatus.Active.Id}");
            var parameters = new DynamicParameters();
            if (!string.IsNullOrEmpty(name))
            {
                sql.Append(" AND Name LIKE %@Name%");
                parameters.Add("Name", name);
            }
            if (!string.IsNullOrEmpty(document))
            {
                sql.Append(" AND Document LIKE %@Document%");
                parameters.Add("Document", document);
            }

            if (showLessor.HasValue && showLessor.Value 
                && (!showLessee.HasValue
                    || (showLessee.HasValue && !showLessee.Value)))
            {
                sql.Append(" AND IsLessor = @IsLessor");
                parameters.Add("IsLessor", 1);
            }
            else if (showLessee.HasValue && showLessee.Value
                     && (!showLessor.HasValue
                         || (showLessor.HasValue && !showLessor.Value)))
            {
                sql.Append(" AND IsLessor = @IsLessor");
                parameters.Add("IsLessor", 0);
            }

            IEnumerable<PeopleDTO> dto = await _dbConnection.QueryAsync<PeopleDTO>(sql.ToString(), parameters);
            if (dto == null || !dto.Any())
            {
                throw new KeyNotFoundException("Nenhuma pessoa encontrada com os critérios especificados.");
            }

            return dto.Select(p => new Person
            {
                Id = p.Id,
                Nome = p.Name,
                CPF = p.Document,
                RG = p.RG,
                DataNascimento = p.BirthDate,
                IsLessor = p.IsLessor,
                LogicalStatus = p.LogicalStatus ? LogicalStatus.Active : LogicalStatus.Inactive,
                EstadoCivil = EstadoCivil.GetById<EstadoCivil>(p.MaritalStatusId),
            });
        }

        public async Task<Person> GetPersonById(Guid personId)
        {
            if (personId == Guid.Empty)
            {
                throw new ArgumentException("O ID da pessoa não pode ser vazio.");
            }

            string sql = $@"SELECT * FROM People WHERE Id = @Id AND LogicalStatus = {LogicalStatus.Active.Id}";
            PeopleDTO dto = await _dbConnection.QueryFirstOrDefaultAsync<PeopleDTO>(sql, new { Id = personId });

            if (dto == null)
            {
                throw new KeyNotFoundException($"Pessoa com ID {personId} não encontrada.");
            }

            return await Task.FromResult(new Person
            {
                Id = dto.Id,
                Nome = dto.Name,
                CPF = dto.Document,
                RG = dto.RG,
                DataNascimento = dto.BirthDate,
                IsLessor = dto.IsLessor,
                LogicalStatus = dto.LogicalStatus ? LogicalStatus.Active : LogicalStatus.Inactive,
                EstadoCivil = EstadoCivil.GetById<EstadoCivil>(dto.MaritalStatusId),
            });
        }

        public async Task RemovePerson(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }

            if (person.Id == Guid.Empty)
            {
                throw new ArgumentException("O ID da pessoa não pode ser vazio.");
            }

            PeopleDTO dto = new PeopleDTO
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento,
                IsLessor = person.IsLessor,
                LogicalStatus = false,
                MaritalStatusId = person.EstadoCivil.Id
            };

            await _dbConnection.UpdateAsync(dto);
        }
    }
}
