using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ImovelController : IImovelController
    {
        private readonly IImovelService _service;

        public ImovelController(IImovelService imovelService)
        {
            _service = imovelService;
        }

        public async Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel)
        {
            Imovel imovel = TransformaViewModelEmImovel(viewModel);
            return await _service.CadastrarNovoImovel(imovel);
        }

        public async Task ExcluirImovel(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }

            Imovel imovel = await _service.ObterImovelViaId(idImovel);
            await _service.ExcluirImovel(imovel);
        }

        public async Task<ImovelViewModel> GetImovelViewModel(Guid idImovel)
        {
            if (idImovel == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(idImovel));
            }

            Imovel imovel = await _service.ObterImovelViaId(idImovel);

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

        public async Task<IEnumerable<Locador>> ObterLocadores()
        {
            throw new NotImplementedException();
        }

        public async Task SalvarAlteracoes(ImovelViewModel viewModel)
        {
            Imovel imovel = TransformaViewModelEmImovel(viewModel);
            await _service.SalvarAlteracoes(imovel);
        }

        private Imovel TransformaViewModelEmImovel(ImovelViewModel viewModel)
        {
            if (viewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException("A ViewModel não possui nenhuma informação.");
            }

            return new Imovel
            {
                Id = viewModel.IdImovel,
                Proprietario = new Locador
                {
                    Id = viewModel.IdLocadorProprietario
                },
                NumeroComodos = viewModel.NumeroComodos,
                ValorAluguel = viewModel.ValorAluguel,
                Locado = viewModel.ImovelLocado,
                Endereco = new Endereco
                {
                    Rua = viewModel.Rua,
                    Numero = viewModel.Numero,
                    Complemento = viewModel.Complemento,
                    Bairro = viewModel.Bairro,
                    Cidade = viewModel.Cidade,
                    Estado = viewModel.Estado,
                    CEP = viewModel.CEP
                }
            };
        }
    }
}
