using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
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

        public async Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return await _repository.CadastrarNovoImovel(imovel);
        }

        public async Task ExcluirImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            imovel.StatusLogico = StatusLogico.Inativo;
            await _repository.SalvarAlteracoes(imovel);
        }

        public async Task<Imovel> ObterImovelViaId(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }
            return await _repository.ObterImovelViaId(idImovel);
        }

        public Task SalvarAlteracoes(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return _repository.SalvarAlteracoes(imovel);
        }

        private void VerificaSeImovelEstaNulo(Imovel imovel)
        {
            if (imovel.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(imovel), "O imóvel não pode ser nulo.");
            }
        }
    }
}
