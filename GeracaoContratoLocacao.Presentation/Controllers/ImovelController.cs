using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ImovelController : IHouseController
    {
        private readonly IImovelService _houseService;

        public ImovelController(IImovelService imovelService)
        {
            _houseService = imovelService;
        }

        public async Task<Guid> CadastrarNovoImovel(HouseViewModel viewModel)
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

        public async Task<IEnumerable<HouseViewModel>> GetAllHouseViewModelList()
        {
            List<House> houses = (await _houseService.GetAllHouses()).ToList();

            return houses.Select(h => new HouseViewModel
            {
                HouseId = h.Id,
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
        }

        public async Task<HouseViewModel> GetHouseViewModelByHouseId(Guid houseId)
        {
            if (houseId == default)
            {
                throw new ArgumentException("O ID do imóvel não pode ser o valor padrão.", nameof(houseId));
            }

            House house = await _houseService.GetHouseById(houseId);

            return new HouseViewModel
            {
                HouseId = house.Id,
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

        public async Task<IEnumerable<Locador>> ObterLocadores()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChanges(HouseViewModel viewModel)
        {
            House imovel = TransformaViewModelEmImovel(viewModel);
            await _houseService.SaveChanges(imovel);
        }

        private House TransformaViewModelEmImovel(HouseViewModel viewModel)
        {
            if (viewModel.IsNullOrEmpty())
            {
                throw new ArgumentNullException("A ViewModel não possui nenhuma informação.");
            }

            return new House
            {
                Id = viewModel.HouseId,
                Proprietario = new Locador
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
                StatusLogico = StatusLogico.Ativo,
            };
        }
    }
}
