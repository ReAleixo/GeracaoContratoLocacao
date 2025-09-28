using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using System.Data;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class ImovelRepository : RepositoryBase<ImovelDTO>, IImovelRepository
    {
        List<Imovel> AllHouses = new List<Imovel>();

        public ImovelRepository()
        {
            Imovel house1 = new Imovel()
            {
                Id = Guid.NewGuid(),
                Proprietario = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "Mayck Henrique da Silva",
                    CPF = "123.123.123-23",
                    RG = "12.123.123-X",
                    DataNascimento = new DateTime(2001, 10, 15),
                    EstadoCivil = EstadoCivil.Casado,
                    Houses = new List<Imovel>()
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
                ValorAluguel = 2300,
                Locado = false
            };
            AllHouses.Add(house1);

            Imovel house2 = new Imovel()
            {
                Id = Guid.NewGuid(),
                Proprietario = new Pessoa
                {
                    Id = Guid.NewGuid(),
                    Nome = "Mateus Henrique da Silva",
                    CPF = "56756756790",
                    RG = "12.123.123-3",
                    DataNascimento = new DateTime(2000, 04, 25),
                    EstadoCivil = EstadoCivil.Viuvo,
                    Houses = new List<Imovel>()
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
                ValorAluguel = 1600,
                Locado = true
            };
            AllHouses.Add(house2);
        }

        public async Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            imovel.Id = Guid.NewGuid();
            AllHouses.Add(imovel);
            return imovel.Id;
        }

        public async Task<IEnumerable<Imovel>> BuscarTodosImoveis()
        {
            return AllHouses.AsEnumerable();
        }

        public async Task<Imovel> BuscarImovelPorId(Guid idImovel)
        {
            return AllHouses.FirstOrDefault(imovel => imovel.Id.Equals(idImovel));
        }

        public Task SalvarAlteracoes(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario)
        {
            return AllHouses.Where(house => house.Proprietario.Id == idProprietario).AsEnumerable();
        }

        public async Task RemoverImovel(Guid idImovel)
        {
            Imovel imovel = AllHouses.FirstOrDefault(imovel => imovel.Id.Equals(idImovel));
            AllHouses.Remove(imovel);
        }
    }
}
