using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _peopleRepository;
        public PessoaService(IPessoaRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }

        public async Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro)
        {
            return await _peopleRepository.GetFilteredPeopleAsync(filtro.Nome, filtro.Documento, filtro.ExibirLocador, filtro.ExibirLocatario);
        }

        public async Task<Pessoa> BuscarPessoaViaIdConjuge(Guid spouseId)
        {
            if (spouseId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }
            return await _peopleRepository.BuscarPessoaViaIdConjuge(spouseId);
        }

        public async Task<Pessoa> BuscarPessoaViaId(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Pessoa person = await _peopleRepository.BuscarPessoaViaId(personId);
            if (person == null)
            {
                throw new KeyNotFoundException($"Pessoa com ID {personId} não encontrada.");
            }
            return person;
        }

        public Task RemoverPessoa(Pessoa person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }
            return _peopleRepository.RemoverPessoa(person);
        }

        public async Task CadastrarPessoa(Pessoa person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.");
            }

            var existingPerson = await _peopleRepository.BuscarPessoaViaId(person.Id);
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
                    existingPerson.Spouse = new Pessoa
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
                await _peopleRepository.AtualizarPessoa(existingPerson);
                return;
            }

            person.LogicalStatus = LogicalStatus.Active;

            if (person.Spouse != null
                && !person.Spouse.IsNullOrEmpty())
            {
                person.Spouse = new Pessoa
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

            await _peopleRepository.CadastrarPessoa(person);
        }

        public async Task<Pessoa> BuscarUltimaPessoaCadastrada()
        {
            return await _peopleRepository.BuscarUltimaPessoaCadastrada();
        }
    }
}
