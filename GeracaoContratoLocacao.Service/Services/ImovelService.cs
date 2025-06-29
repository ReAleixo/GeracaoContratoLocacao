using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class ImovelService : IImovelService
    {
        private readonly IImovelRepository _repository;

        public ImovelService(IImovelRepository imovelRepository)
        {
            _repository = imovelRepository;
        }

        public Task<Guid> CadastrarNovoImovel(Imovel imovel, Locador locador)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirImovel(int idImovel)
        {
            throw new NotImplementedException();
        }

        public Task<Imovel> GetImovelById(Guid idImovel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Locador>> ObterLocadores()
        {
            throw new NotImplementedException();
        }

        public Task SalvarAlteracoes(Imovel imovel)
        {
            throw new NotImplementedException();
        }
    }
}
