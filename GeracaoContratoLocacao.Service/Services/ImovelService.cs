using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Service.Services
{
    public class ImovelService : IImovelService
    {
        private readonly IImovelRepository _imovelRepository;

        public ImovelService(IImovelRepository imovelRepository)
        {
            _imovelRepository = imovelRepository;
        }

        public async Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return await _imovelRepository.CadastrarNovoImovel(imovel);
        }

        public async Task RemoverImovel(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("Não foi informado o imóvel a ser removido.");
            }
            await _imovelRepository.RemoverImovel(idImovel);
        }

        public async Task<IEnumerable<Imovel>> BuscarTodosImoveis()
        {
            return _imovelRepository.BuscarTodosImoveis();
        }

        public async Task<Imovel> BuscarImovelPorId(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("Não foi informado o imóvel a ser buscado.");
            }
            return await _imovelRepository.BuscarImovelPorId(idImovel);
        }

        public Task AlterarImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return _imovelRepository.SalvarAlteracoes(imovel);
        }

        private void VerificaSeImovelEstaNulo(Imovel imovel)
        {
            if (imovel.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(imovel), "O imóvel não pode ser nulo.");
            }
        }

        public async Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario)
        {
            if (idProprietario == default)
            {
                throw new ArgumentException("Não foi informado o proprietário.");
            }
            return await _imovelRepository.BuscarImoveisPorProprietario(idProprietario);
        }
    }
}
