using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using GeracaoContratoLocacao.Service.Interfaces;

namespace GeracaoContratoLocacao.Presentation.Controllers
{
    public class ContratoController : IContratoController
    {
        private readonly IContratoService _contratoService;
        private readonly IPessoaService _pessoaService;
        private readonly IImovelService _imovelService;

        public ContratoController(IContratoService contratoService,
                                  IPessoaService pessoaService,
                                  IImovelService imovelService)
        {
            _contratoService = contratoService;
            _pessoaService = pessoaService;
            _imovelService = imovelService;
        }

        public async Task GerarContrato(ContratoViewModel contratoViewModel)
        {
            if (contratoViewModel == null)
            {
                throw new ArgumentException("Os dados do contrato não foram informados.");
            }

            string filePath = SetNewFilePath();
            var contratoLocacao = await MapearViewModelParaDominio(contratoViewModel);
            _contratoService.GerarContratoLocacao(contratoLocacao, filePath);
        }

        private string SetNewFilePath()
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

        private async Task<Contrato> MapearViewModelParaDominio(ContratoViewModel contratoViewModel)
        {
            if (contratoViewModel == null)
            {
                throw new ArgumentException("Os dados do contrato não foram informados.");
            }

            Pessoa locador = await _pessoaService.BuscarPessoaPorId(contratoViewModel.IdLocador);
            if (locador == null)
            {
                throw new ArgumentException("O locador selecionado não foi encontrado.");
            }

            Pessoa locatario = await _pessoaService.BuscarPessoaPorId(contratoViewModel.IdLocatario);
            if (locatario == null)
            {
                throw new ArgumentException("O locatário selecionado não foi encontrado.");
            }

            Imovel imovel = await _imovelService.BuscarImovelPorId(contratoViewModel.IdImovel);
            if (imovel == null)
            {
                throw new ArgumentException("O imóvel selecionado não foi encontrado.");
            }

            return new Contrato
            {
                Id = contratoViewModel.Id,
                Locador = locador,
                Locatario = locatario,
                Imovel = imovel,
                IdModelo = contratoViewModel.IdModeloContrato,
                Prazo = contratoViewModel.Prazo,
                DataInicio = contratoViewModel.DataInicioContrato,
                DataGeracao = DateTime.Now
            };
        }
    }
}
