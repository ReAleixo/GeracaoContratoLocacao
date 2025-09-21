using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ImovelController : IImovelController
    {
        private readonly IImovelService _houseService;

        public ImovelController(IImovelService imovelService)
        {
            _houseService = imovelService;
        }

        public async Task<Guid> CadastrarNovoImovel(ImovelViewModel viewModel)
        {
            House house = TransformaViewModelEmImovel(viewModel);
            return await _houseService.CadastrarNovoImovel(house);
        }

        public async Task DeleteHouse(Guid houseId)
        {
            if (houseId == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(houseId));
            }

            House house = await _houseService.GetHouseById(houseId);
            await _houseService.DeleteHouse(house);
        }

        public async Task<IEnumerable<ImovelViewModel>> GetAllHouseViewModelList(string? lessorNameFilter = null, bool? showHouseRentedFilter = null)
        {
            List<House> houses = (await _houseService.GetAllHouses()).ToList();

            if (houses == null || !houses.Any())
            {
                throw new InvalidOperationException("Nenhum imóvel encontrado.");
            }

            var housesViewModelList = houses.Select(h => new ImovelViewModel
            {
                Id = h.Id,
                IdProprietario = h.Owner.Id,
                NomeProprietario = h.Owner.Nome,
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

            House house = await _houseService.GetHouseById(houseId);

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

        public async Task<IEnumerable<Pessoa>> ObterLocadores()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChanges(ImovelViewModel viewModel)
        {
            House imovel = TransformaViewModelEmImovel(viewModel);
            await _houseService.SaveChanges(imovel);
        }

        private House TransformaViewModelEmImovel(ImovelViewModel viewModel)
        {
            if (viewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException("A ViewModel não possui nenhuma informação.");
            }

            return new House
            {
                Id = viewModel.Id,
                Owner = new Pessoa
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
                LogicalStatus = LogicalStatus.Active,
            };
        }
    }
}
