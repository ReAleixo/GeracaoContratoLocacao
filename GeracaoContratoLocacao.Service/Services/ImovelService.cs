using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class ImovelService : IImovelService
    {
        private readonly IHouseRepository _repository;

        public ImovelService(IHouseRepository imovelRepository)
        {
            _repository = imovelRepository;
        }

        public async Task<Guid> CadastrarNovoImovel(House imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return await _repository.CadastrarNovoImovel(imovel);
        }

        public async Task DeleteHouse(House imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            imovel.LogicalStatus = LogicalStatus.Inactive;
            await _repository.SalvarAlteracoes(imovel);
        }

        public async Task<IEnumerable<House>> GetAllHouses()
        {
            return _repository.GetAllHouses();
        }

        public async Task<House> GetHouseById(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }
            return await _repository.ObterImovelViaId(idImovel);
        }

        public Task SaveChanges(House imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return _repository.SalvarAlteracoes(imovel);
        }

        private void VerificaSeImovelEstaNulo(House imovel)
        {
            if (imovel.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(imovel), "O imóvel não pode ser nulo.");
            }
        }
    }
}
