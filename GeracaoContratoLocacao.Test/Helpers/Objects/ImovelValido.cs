using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Test.Helpers.Objects
{
    public static class ImovelValido
    {
        public static Imovel ImovelValidoPadrao()
        {
            return new Imovel
            {
                Id = Guid.NewGuid(),
                Endereco = new Domain.ValueObjects.Endereco
                {
                    Rua = "Rua 1",
                    Numero = 456,
                    Complemento = "",
                    Bairro = "Bairro Central",
                    Cidade = "Cidade XYZ",
                    Estado = "Estado ABC",
                    CEP = "12345-678"
                },
                ValorAluguel = 1000,
                Proprietario = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "Tony Stark",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(2000, 1, 1),
                    EstadoCivil = EstadoCivil.Separado,
                    Gender = Gender.Male,
                    PersonType = TipoPessoa.Locador,
                }
            };
        }

        public static Imovel ImovelValidoPorIdProprietario(Guid idProprietario)
        {
            return new Imovel
            {
                Id = Guid.NewGuid(),
                Endereco = new Domain.ValueObjects.Endereco
                {
                    Rua = "Rua A",
                    Numero = 123,
                    Complemento = "",
                    Bairro = "Bairro Central",
                    Cidade = "Cidade X",
                    Estado = "Estado Y",
                    CEP = "12345-678"
                },
                ValorAluguel = 1500.00m,
                Proprietario = new Pessoa
                {
                    Id = idProprietario,
                    Nome = "João Silva",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(1980, 1, 1),
                }
            };
        }

        public static Imovel ImovelValidoPorIdImovel(Guid idImovel)
        {
            return new Imovel
            {
                Id = idImovel,
                Endereco = new Domain.ValueObjects.Endereco
                {
                    Rua = "Rua A",
                    Numero = 123,
                    Complemento = "",
                    Bairro = "Bairro Central",
                    Cidade = "Cidade X",
                    Estado = "Estado Y",
                    CEP = "12345-678"
                },
                ValorAluguel = 1500.00m,
                Proprietario = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "João Silva",
                    CPF = "123.456.789-00",
                    RG = "12.345.678-9",
                    DataNascimento = new DateTime(1980, 1, 1),
                    EstadoCivil = EstadoCivil.Casado,
                    Gender = Gender.Male,
                    PersonType = TipoPessoa.Locador,
                }
            };
        }
    }
}
