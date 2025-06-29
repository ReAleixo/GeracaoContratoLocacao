using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ImovelController : IImovelController
    {
        private readonly IImovelService _imovelService;

        public ImovelController(IImovelService imovelService)
        {
            _imovelService = imovelService;
        }

        public async Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel)
        {
            if (viewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException("A ViewModel não possui nenhuma informação.");
            }

            var imovel = new Imovel
            {
                Id = viewModel.IdImovel,
                Endereco = new Endereco
                {
                    Rua = viewModel.Rua,
                    Numero = viewModel.Numero,
                    Complemento = viewModel.Complemento,
                    Bairro = viewModel.Bairro,
                    Cidade = viewModel.Cidade,
                    Estado = viewModel.Estado,
                    CEP = viewModel.CEP
                },
                ValorAluguel = viewModel.ValorAluguel,
                Locado = viewModel.ImovelLocado,
                NumeroComodos = viewModel.NumeroComodos
            };

            var locador = new Locador
            {
                Id = viewModel.IdLocadorProprietario
            };

            return await _imovelService.CadastrarNovoImovel(imovel, locador);
        }

        public Task ExcluirImovel(Guid idImovel)
        {
            throw new NotImplementedException();
        }

        public async Task<ImovelViewModel> GetImovelViewModel(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }

            Imovel imovel = await _imovelService.GetImovelById(idImovel);

            return new ImovelViewModel
            {
                IdImovel = imovel.Id,
                NumeroComodos = imovel.NumeroComodos, 
                ValorAluguel = imovel.ValorAluguel,
                ImovelLocado = imovel.Locado,
                Rua = imovel.Endereco.Rua,
                Numero = imovel.Endereco.Numero,
                Complemento = imovel.Endereco.Complemento,
                Bairro = imovel.Endereco.Bairro,
                Cidade = imovel.Endereco.Cidade,
                Estado = imovel.Endereco.Estado,
                CEP = imovel.Endereco.CEP,
            };
        }

        public Task<IEnumerable<Locador>> ObterLocadores()
        {
            throw new NotImplementedException();
        }

        public Task SalvarAlteracoes(ImovelViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}
