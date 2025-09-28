using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Test.Helpers.Objects
{
    public static class PessoaValida
    {
        public static Pessoa PessoaValidaPadrao()
        {
            return new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "Bruce Wayne",
                CPF = "987.654.321-00",
                RG = "98.765.432-1",
                DataNascimento = new DateTime(1990, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                Gender = Gender.Male,
                Houses = new List<Imovel>(),
                PersonType = TipoPessoa.Locatario,
                Spouse = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "Selina Kyle",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(1992, 7, 20),
                    EstadoCivil = EstadoCivil.Casado,
                    Gender = Gender.Male,
                    PersonType = TipoPessoa.Spouse,
                }
            };
        }

        public static Pessoa PessoaValidaPorId(Guid id)
        {
            return new Pessoa
            {
                Id = id,
                Nome = "Bruce Wayne",
                CPF = "987.654.321-00",
                RG = "98.765.432-1",
                DataNascimento = new DateTime(1990, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                Gender = Gender.Male,
                Houses = new List<Imovel>(),
                PersonType = TipoPessoa.Locatario,
                Spouse = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "Selina Kyle",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(1992, 7, 20),
                    EstadoCivil = EstadoCivil.Casado,
                    Gender = Gender.Male,
                    PersonType = TipoPessoa.Spouse,
                }
            };
        }

        public static Pessoa PessoaValidaPorIdConjuge(Guid idConjuge)
        {
            return new Pessoa
            {
                Id = Guid.NewGuid(),
                Nome = "Bruce Wayne",
                CPF = "987.654.321-00",
                RG = "98.765.432-1",
                DataNascimento = new DateTime(1990, 5, 15),
                EstadoCivil = EstadoCivil.Casado,
                Gender = Gender.Male,
                Houses = new List<Imovel>(),
                PersonType = TipoPessoa.Locatario,
                Spouse = new Pessoa
                {
                    Id = idConjuge,
                    Nome = "Selina Kyle",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(1992, 7, 20),
                    EstadoCivil = EstadoCivil.Casado,
                    Gender = Gender.Male,
                    PersonType = TipoPessoa.Spouse,
                }
            };
        }

        public static IEnumerable<Pessoa> ListaPessoasValidas()
        {
            return new List<Pessoa>
            {
                PessoaValidaPadrao(),
                PessoaValidaPadrao(),
                PessoaValidaPadrao()
            };
        }
    }
}
