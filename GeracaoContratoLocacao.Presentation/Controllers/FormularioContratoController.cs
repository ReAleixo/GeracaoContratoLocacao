using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class FormularioContratoController : IFormularioContratoController
    {
        private readonly IGeracaoContratoService _service;
        public FormularioContratoController(IGeracaoContratoService service)
        {
            _service = service;
        }

        public void GerarContrato(ContratoViewModel contratoViewModel)
        {
            string filePath = SetNewFilePath(contratoViewModel);
            var contratoLocacao = MapFromViewModelToDomain(contratoViewModel);
            _service.GerarContratoLocacao(contratoLocacao, filePath);
        }

        private string SetNewFilePath(ContratoViewModel contratoViewModel)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (folderBrowser.ShowDialog() != DialogResult.OK)
            {
                throw new ArgumentException("O caminho de destino não foi selecionado ou é inválido.");
            }
            return folderBrowser.SelectedPath;
        }

        private RentalContract MapFromViewModelToDomain(ContratoViewModel contratoViewModel)
        {
            return new RentalContract
            {
                Lessee = new Person
                {
                    Nome = contratoViewModel.NomeLocatario,
                    CPF = contratoViewModel.CPFLocatario,
                    RG = contratoViewModel.RGLocatario,
                },
                RentalStartDate = contratoViewModel.DataInicioContrato,
                MonthsRent = contratoViewModel.PrazoContrato,
                House = new House
                {
                    Endereco = new Endereco
                    {
                        Complemento = contratoViewModel.NumeroCasa.ToString()
                    }
                },
                RentalValue = contratoViewModel.ValorAluguel,
                ContractGenerationDate = DateTime.Now
            };
        }
    }
}
