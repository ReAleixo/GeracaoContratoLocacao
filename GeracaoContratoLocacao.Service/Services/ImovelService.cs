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

        public async Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            return await _repository.CadastrarNovoImovel(imovel);
        }

        public async Task RemoverImovel(Imovel imovel)
        {
            VerificaSeImovelEstaNulo(imovel);
            await _repository.SalvarAlteracoes(imovel);
        }

        public async Task<IEnumerable<Imovel>> BuscarTodosImoveis()
        {
            return _repository.BuscarTodosImoveis();
        }

        public async Task<Imovel> BuscarImovelPorId(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }
            return await _repository.BuscarImovelPorId(idImovel);
        }

        public Task SaveChanges(Imovel imovel)
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

        public async Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario)
        {
            if (idProprietario == default)
            {
                throw new ArgumentException("Não foi informado o proprietário.");
            }
            return await _repository.BuscarImoveisPorProprietario(idProprietario);
        }
    }
}
