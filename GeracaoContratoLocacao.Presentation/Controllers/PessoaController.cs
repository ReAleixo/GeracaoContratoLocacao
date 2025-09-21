using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using System;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class PessoaController : IPessoaController
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService peopleService)
        {
            _pessoaService = peopleService;
        }

        public async Task<IEnumerable<PessoaViewModel>> BuscarPessoasPorFiltro(FiltrosPessoaViewModel filters)
        {
            FiltroPessoas filtro = new FiltroPessoas
            {
                Nome = filters.Name,
                Documento = filters.Document,
                ExibirLocatario = filters.ShowLessee,
                ExibirLocador = filters.ShowLessor
            };

            List<Pessoa> people = (await _pessoaService.BuscarPessoasPorFiltro(filtro)).ToList();

            return people.Select(person => new PessoaViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
            });
        }

        public async Task<PessoaViewModel> BuscarPessoaViaIdConjuge(Guid spouseId)
        {
            if (spouseId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Pessoa person = await _pessoaService.BuscarPessoaViaIdConjuge(spouseId);
            return new PessoaViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                Gender = person.Gender.Name,
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
                SpouseId = person.Spouse.Id,
            };
        }

        public async Task<PessoaViewModel> BuscarPessoaViaId(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Pessoa person = await _pessoaService.BuscarPessoaPorId(personId);
            if (person == null)
            {
                throw new KeyNotFoundException("Pessoa não encontrada.");
            }

            return new PessoaViewModel
            {
                Id = person.Id,
                Name = person.Nome,
                Document = person.CPF,
                RG = person.RG,
                BirthDate = person.DataNascimento.ToShortDateString(),
                Gender = person.Gender.Name,
                PersonType = person.PersonType.Name,
                MaritalStatus = person.EstadoCivil?.Name,
                SpouseId = person.Spouse?.Id ?? Guid.Empty,
            };
        }

        public async Task RemoverPessoa(Guid personId)
        {
            if (personId == default)
            {
                throw new ArgumentException("O ID da pessoa não pode ser o valor padrão.");
            }

            Pessoa person = await _pessoaService.BuscarPessoaPorId(personId);
            await _pessoaService.RemoverPessoa(person);
        }

        public async Task CadastrarPessoa(PessoaViewModel personViewModel, PessoaViewModel? spouseViewModel = null)
        {
            if (personViewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(personViewModel), "A pessoa não pode ser nula.");
            }

            Pessoa person = new Pessoa
            {
                Id = personViewModel.Id,
                Nome = personViewModel.Name,
                CPF = personViewModel.Document,
                RG = personViewModel.RG,
                DataNascimento = DateTime.Parse(personViewModel.BirthDate),
                Gender = Gender.GetByName<Gender>(personViewModel.Gender),
                EstadoCivil = EstadoCivil.GetByName<EstadoCivil>(personViewModel.MaritalStatus),
                PersonType = TipoPessoa.GetByName<TipoPessoa>(personViewModel.PersonType),
            };

            if (spouseViewModel != null
                && spouseViewModel.IsValid())
            {
                Pessoa spouse = new Pessoa
                {
                    Id = spouseViewModel.Id,
                    Nome = spouseViewModel.Name,
                    CPF = spouseViewModel.Document,
                    RG = spouseViewModel.RG,
                    DataNascimento = DateTime.Parse(spouseViewModel.BirthDate),
                    Gender = Gender.GetByName<Gender>(spouseViewModel.Gender),
                    PersonType = TipoPessoa.GetByName<TipoPessoa>(spouseViewModel.PersonType),
                };

                person.Spouse = spouse;
            }
            await _pessoaService.CadastrarPessoa(person);
        }

        public async Task<IEnumerable<PessoaViewModel>> BuscarLocadores()
        {
            return new List<PessoaViewModel>
            {
                new PessoaViewModel()
            }.Concat(await BuscarPessoasPorFiltro(new FiltrosPessoaViewModel(showLessor: true)));
        }

        public async Task<IEnumerable<PessoaViewModel>> BuscarLocatarios()
        {
            return new List<PessoaViewModel>
            {
                new PessoaViewModel()
            }.Concat(await BuscarPessoasPorFiltro(new FiltrosPessoaViewModel(showLessee: true)));
        }
    }
}
