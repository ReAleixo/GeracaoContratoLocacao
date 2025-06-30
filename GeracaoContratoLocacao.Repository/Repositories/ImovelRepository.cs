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

        public Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            throw new NotImplementedException();
        }

        public Task<Imovel> ObterImovelViaId(Guid idImovel)
        {
            throw new NotImplementedException();
        }

        public Task SalvarAlteracoes(Imovel imovel)
        {
            throw new NotImplementedException();
        }
    }
}
