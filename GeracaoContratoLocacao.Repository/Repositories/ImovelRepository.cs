using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Base.Repository;
using GeracaoContratoLocacao.Repository.DTOs;
using GeracaoContratoLocacao.Repository.Interfaces;
using System.Data;

namespace GeracaoContratoLocacao.Repository.Repositories
{
    public class ImovelRepository : RepositoryBase<ImoveisDTO>, IImovelRepository
    {
        private readonly IDbConnection _dbConnection;

        public ImovelRepository()
        {
        }

        public Task<Guid> CadastrarNovoImovel(House imovel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<House>> GetAllHouses()
        {
            throw new NotImplementedException();
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
