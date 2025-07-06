using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Domain.ValueObjects;
using System.Data;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class HouseRepository : RepositoryBase<ImoveisDTO>, IHouseRepository
    {
        private readonly IDbConnection _dbConnection;

        public HouseRepository()
        {
        }

        public Task<Guid> CadastrarNovoImovel(House imovel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<House> GetAllHouses()
        {
            List<House> AllHouses = new List<House>();

            House house1 = new House()
            {
                Id = Guid.NewGuid(),
                Proprietario = new Lessor
                {
                    Id = Guid.NewGuid(),
                    Nome = "Mayck Henrique da Silva",
                    CPF = "123.123.123-23",
                    RG = "12.123.123-X",
                    DataNascimento = new DateTime(2001, 10, 15),
                    EstadoCivil = EstadoCivil.Casado,
                    StatusLogico = StatusLogico.Ativo,
                    Houses = new List<House>()
                },
                Endereco = new Endereco
                {
                    Rua = "Tristão de Ataíde",
                    Numero = 121,
                    Complemento = "Apartamento 02",
                    Bairro = "Ana Maria",
                    Cidade = "Santo André",
                    Estado = "São Paulo",
                    CEP = "09260-680"
                },
                NumeroComodos = 5,
                StatusLogico = StatusLogico.Ativo,
                ValorAluguel = 2300,
                Locado = false
            };
            AllHouses.Add(house1);

            House house2 = new House()
            {
                Id = Guid.NewGuid(),
                Proprietario = new Lessor
                {
                    Id = Guid.NewGuid(),
                    Nome = "Mateus Henrique da Silva",
                    CPF = "56756756790",
                    RG = "12.123.123-3",
                    DataNascimento = new DateTime(2000, 04, 25),
                    EstadoCivil = EstadoCivil.Viuvo,
                    StatusLogico = StatusLogico.Ativo,
                    Houses = new List<House>()
                },
                Endereco = new Endereco
                {
                    Rua = "Tristão de Melquisede",
                    Numero = 121,
                    Complemento = "Chegadinho do lado",
                    Bairro = "Ana Maria Aparecida",
                    Cidade = "Santo André",
                    Estado = "São Paulo",
                    CEP = "09260-000"
                },
                NumeroComodos = 4,
                StatusLogico = StatusLogico.Ativo,
                ValorAluguel = 1600,
                Locado = true
            };
            AllHouses.Add(house2);
            return AllHouses.AsEnumerable();
        }

        public Task<House> ObterImovelViaId(Guid idImovel)
        {
            throw new NotImplementedException();
        }

        public Task SalvarAlteracoes(House imovel)
        {
            throw new NotImplementedException();
        }
    }
}
