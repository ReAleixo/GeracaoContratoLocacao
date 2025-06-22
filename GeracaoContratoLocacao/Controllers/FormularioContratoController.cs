using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Services;

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
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "Salvar Contrato de Locação",
                Filter = "Documento Word|*.docx|PDF|*.pdf",
                FileName = $"CONTRATO LOCAÇÃO - {contratoViewModel.NomeLocatario.ToUpper()}",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                throw new ArgumentException("O caminho de destino não foi selecionado ou é inválido.");
            }
            return ofd.FileName;
        }

        private ContratoLocacao MapFromViewModelToDomain(ContratoViewModel contratoViewModel)
        {
            return new ContratoLocacao
            {
                Locatario = new Pessoa
                {
                    Nome = contratoViewModel.NomeLocatario,
                    CPF = contratoViewModel.CPFLocatario,
                    RG = contratoViewModel.RGLocatario,
                },
                DataInicioLocacao = contratoViewModel.DataInicioContrato,
                DataFimLocacao = contratoViewModel.DataInicioContrato.AddMonths(contratoViewModel.PrazoContrato),
                PrazoLocacao = contratoViewModel.PrazoContrato,
                Imovel = new Imovel
                {
                    Endereco = new Endereco
                    {
                        Complemento = contratoViewModel.NumeroCasa.ToString()
                    }
                },
                ValorAluguel = contratoViewModel.ValorAluguel,
                DataVencimentoPagamento = contratoViewModel.DataInicioContrato,
                DataGeracao = DateTime.Now
            };
        }
    }
}
