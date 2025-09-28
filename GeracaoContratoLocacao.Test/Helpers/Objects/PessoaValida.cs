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
    }
}
