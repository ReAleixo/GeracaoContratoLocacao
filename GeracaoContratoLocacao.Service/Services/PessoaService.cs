using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository peopleRepository)
        {
            _pessoaRepository = peopleRepository;
        }

        public async Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro)
        {
            return await _pessoaRepository.BuscarPessoasPorFiltro(filtro);
        }

        public async Task<Pessoa> BuscarPessoaViaIdConjuge(Guid idConjuge)
        {
            if (idConjuge == default)
            {
                throw new ArgumentException("O cônjuge não foi informado.");
            }
            return await _pessoaRepository.BuscarPessoaViaIdConjuge(idConjuge);
        }

        public async Task<Pessoa> BuscarPessoaPorId(Guid id)
        {
            if (id == default)
            {
                throw new ArgumentException("Não foi informada a pessoa que está sendo procurada.");
            }

            Pessoa person = await _pessoaRepository.BuscarPessoaViaId(id);
            if (person == null)
            {
                throw new KeyNotFoundException($"A pessoa não foi encontrada.");
            }
            return person;
        }

        public Task RemoverPessoa(Pessoa person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("Não foi informada a pessoa a ser removida.");
            }
            return _pessoaRepository.RemoverPessoa(person);
        }

        public async Task CadastrarPessoa(Pessoa person)
        {
            if (person == null)
            {
                throw new ArgumentNullException("Não foi informada uma pessoa");
            }

            var existingPerson = await _pessoaRepository.BuscarPessoaViaId(person.Id);
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
                        PersonType = TipoPessoa.Spouse
                    };
                }
                await _pessoaRepository.AtualizarPessoa(existingPerson);
                return;
            }

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
                    PersonType = TipoPessoa.Spouse
                };
            }

            await _pessoaRepository.CadastrarPessoa(person);
        }
    }
}
