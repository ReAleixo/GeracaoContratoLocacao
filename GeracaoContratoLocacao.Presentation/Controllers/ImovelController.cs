using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ImovelController : IImovelController
    {
        private readonly IImovelService _imovelService;

        public ImovelController(IImovelService imovelService)
        {
            _imovelService = imovelService;
        }

        public async Task<IEnumerable<ImovelViewModel>> BuscarImoveisPorProprietario(Guid idProprietario)
        {
            if (idProprietario == default)
            {
                throw new ArgumentException("Não foi informado o proprietário.");
            }
            IEnumerable<Imovel> imoveis = await _imovelService.BuscarImoveisPorProprietario(idProprietario);
            return imoveis.Select(imovel => new ImovelViewModel
            {
                Id = imovel.Id,
                IdProprietario = imovel.Proprietario.Id,
                NomeProprietario = imovel.Proprietario.Nome,
                NumeroComodos = imovel.NumeroComodos,
                ValorAluguel = imovel.ValorAluguel,
                ImovelLocado = imovel.Locado,
                Rua = imovel.Endereco.Rua,
                Numero = imovel.Endereco.Numero,
                Complemento = imovel.Endereco.Complemento,
                Bairro = imovel.Endereco.Bairro,
                Cidade = imovel.Endereco.Cidade,
                Estado = imovel.Endereco.Estado,
                CEP = imovel.Endereco.CEP
            });
        }

        public async Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel)
        {
            Imovel house = TransformaViewModelEmImovel(viewModel);
            return await _imovelService.CadastrarNovoImovel(house);
        }

        public async Task DeleteHouse(Guid houseId)
        {
            if (houseId == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(houseId));
            }

            await _imovelService.RemoverImovel(houseId);
        }

        public async Task<IEnumerable<ImovelViewModel>> GetAllHouseViewModelList(string? lessorNameFilter = null, bool? showHouseRentedFilter = null)
        {
            List<Imovel> houses = (await _imovelService.BuscarTodosImoveis()).ToList();

            if (houses == null || !houses.Any())
            {
                throw new InvalidOperationException("Nenhum imóvel encontrado.");
            }

            var housesViewModelList = houses.Select(h => new ImovelViewModel
            {
                Id = h.Id,
                IdProprietario = h.Proprietario.Id,
                NomeProprietario = h.Proprietario.Nome,
                NumeroComodos = h.NumeroComodos,
                ValorAluguel = h.ValorAluguel,
                ImovelLocado = h.Locado,
                Rua = h.Endereco.Rua,
                Numero = h.Endereco.Numero,
                Complemento = h.Endereco.Complemento,
                Bairro = h.Endereco.Bairro,
                Cidade = h.Endereco.Cidade,
                Estado = h.Endereco.Estado,
                CEP = h.Endereco.CEP
            }).ToList();

            if (!string.IsNullOrEmpty(lessorNameFilter))
            {
                housesViewModelList = housesViewModelList.Where(h => h.NomeProprietario.Contains(lessorNameFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            if (showHouseRentedFilter.HasValue && !showHouseRentedFilter.Value)
            {
                housesViewModelList = housesViewModelList.Where(h => !h.ImovelLocado).ToList();
            }

            return housesViewModelList;
        }

        public async Task<ImovelViewModel> GetHouseViewModelByHouseId(Guid houseId)
        {
            if (houseId == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(houseId));
            }

            Imovel house = await _imovelService.BuscarImovelPorId(houseId);

            return new ImovelViewModel
            {
                Id = house.Id,
                NumeroComodos = house.NumeroComodos,
                ValorAluguel = house.ValorAluguel,
                ImovelLocado = house.Locado,
                Rua = house.Endereco.Rua,
                Numero = house.Endereco.Numero,
                Complemento = house.Endereco.Complemento,
                Bairro = house.Endereco.Bairro,
                Cidade = house.Endereco.Cidade,
                Estado = house.Endereco.Estado,
                CEP = house.Endereco.CEP,
            };
        }

        public async Task SaveChanges(ImovelViewModel viewModel)
        {
            Imovel imovel = TransformaViewModelEmImovel(viewModel);
            await _imovelService.AlterarImovel(imovel);
        }

        private Imovel TransformaViewModelEmImovel(ImovelViewModel viewModel)
        {
            if (viewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException("A ViewModel não possui nenhuma informação.");
            }

            return new Imovel
            {
                Id = viewModel.Id,
                Proprietario = new Pessoa
                {
                    Id = viewModel.IdProprietario
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
                },
            };
        }
    }
}
