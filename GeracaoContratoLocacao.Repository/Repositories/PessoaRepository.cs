using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using System.Data;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class PessoaRepository : RepositoryBase<PessoaDTO>, IPessoaRepository
    {
        private List<Pessoa> peopleDB = new List<Pessoa>();

        public PessoaRepository()
        {
            peopleDB.Add(new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "John Doe",
                CPF = "12345678901",
                RG = "12345678",
                DataNascimento = new DateTime(1990, 1, 1),
                Gender = Gender.Male,
                EstadoCivil = EstadoCivil.Solteiro,
                PersonType = TipoPessoa.Locador,
                Houses = new List<Imovel>()
            });
            peopleDB.Add(new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "Jhon Travolta",
                CPF = "006.102.760-00",
                RG = "12345678",
                DataNascimento = new DateTime(1976, 11, 7),
                Gender = Gender.Male,
                EstadoCivil = EstadoCivil.UniaoEstavel,
                PersonType = TipoPessoa.Locador,
                Houses = new List<Imovel>()
            });
            peopleDB.Add(new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "Jane Smith",
                CPF = "10987654321",
                RG = "87654321",
                Gender = Gender.Female,
                DataNascimento = new DateTime(1985, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                PersonType = TipoPessoa.Locatario,
            });
            peopleDB.Add(new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "Jony Treaver",
                CPF = "41522476067",
                RG = "87654321",
                DataNascimento = new DateTime(2001, 2, 18),
                Gender = Gender.Male,
                EstadoCivil = EstadoCivil.Casado,
                PersonType = TipoPessoa.Locatario,
            });
        }

        public async Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro)
        {
            List<Pessoa> filteredPeople = peopleDB.ToList();
            filteredPeople.AddRange(peopleDB.Where(p => p.Spouse != null).Select(p => p.Spouse));
            if (!string.IsNullOrEmpty(filtro.Nome))
            {
                filteredPeople = filteredPeople.Where(p => p.Nome.Contains(filtro.Nome, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            if (!string.IsNullOrEmpty(filtro.Documento))
            {
                filteredPeople = filteredPeople.Where(p => p.CPF.Contains(filtro.Documento) || p.RG.Contains(filtro.Documento)).ToList();
            }
            if (filtro.ExibirLocador.HasValue && filtro.ExibirLocador.Value
                && (!filtro.ExibirLocatario.HasValue
                    || (filtro.ExibirLocatario.HasValue && !filtro.ExibirLocatario.Value)))
            {
                filteredPeople = filteredPeople.Where(p => p.PersonType == TipoPessoa.Locador).ToList();
            }
            else if (filtro.ExibirLocatario.HasValue && filtro.ExibirLocatario.Value
                     && (!filtro.ExibirLocador.HasValue
                         || (filtro.ExibirLocador.HasValue && !filtro.ExibirLocador.Value)))
            {
                filteredPeople = filteredPeople.Where(p => p.PersonType == TipoPessoa.Locatario).ToList();
            }
            return filteredPeople;
        }

        public async Task<Pessoa> BuscarPessoaViaId(Guid personId)
        {
            Pessoa person = peopleDB.FirstOrDefault(p => p.Id == personId);
            if (person == null || person.IsNullOrEmpty())
            {
                person = peopleDB.FirstOrDefault(p => p.Spouse?.Id == personId);
                if (person != null)
                {
                    return person.Spouse;
                }
                return default;
            }
            return person;
        }

        public async Task RemoverPessoa(Pessoa person)
        {
            Pessoa existingPerson = peopleDB.FirstOrDefault(p => p.Id == person.Id);
            peopleDB.Remove(existingPerson);
        }

        public Task CadastrarPessoa(Pessoa person)
        {
            peopleDB.Add(person);
            return Task.CompletedTask;
        }

        public async Task AtualizarPessoa(Pessoa person)
        {
            peopleDB.Remove(await BuscarPessoaViaId(person.Id));
            await CadastrarPessoa(person);
        }

        public async Task<Pessoa> BuscarPessoaViaIdConjuge(Guid spouseId)
        {
            return peopleDB.FirstOrDefault(p => p.Spouse?.Id == spouseId);
        }
    }
}
