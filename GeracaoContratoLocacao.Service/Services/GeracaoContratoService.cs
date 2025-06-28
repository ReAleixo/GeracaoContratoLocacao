using GeracaoContratoLocacao.CrossCutting.Utils;
using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Utils;
using GeracaoContratoLocacao.Service.Interfaces;
using Spire.Doc;
using System.Globalization;

namespace GeracaoContratoLocacao.Service.Services
{
    public class GeracaoContratoService : IGeracaoContratoService
    {
        public GeracaoContratoService()
        {

        }

        public void GerarContratoLocacao(ContratoLocacao contratoLocacao, string pathDestino)
        {
            if (contratoLocacao == null)
            {
                throw new ArgumentNullException("O contrato de locação não pode ser nulo.");
            }

            if (string.IsNullOrEmpty(pathDestino))
            {
                throw new ArgumentException("O caminho de destino não pode ser vazio ou nulo.");
            }

            try
            {
                var documentoContratoModelo = new Document();
                documentoContratoModelo.LoadFromFile(Paths.pathModeloContrato);
                EditDocument(documentoContratoModelo, contratoLocacao);

                string nomeNovoArquivo = $"Contrato de locação - Locatário {contratoLocacao.Locatario.Nome}.pdf";
                string fullPath = Path.Combine(pathDestino, nomeNovoArquivo);
                documentoContratoModelo.SaveToFile(fullPath);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void EditDocument(Document contrato, ContratoLocacao contratoLocacao)
        {
            contrato.Replace("#NOME_LOCATARIO#", contratoLocacao.Locatario.Nome.ToUpper(), true, true);
            contrato.Replace("#CPF_LOCATARIO#", contratoLocacao.Locatario.CPF, true, true);
            contrato.Replace("#RG_LOCATARIO#", contratoLocacao.Locatario.RG, true, true);
            contrato.Replace("#CASA#", contratoLocacao.Imovel.Endereco.Complemento, true, true);
            contrato.Replace("#PRAZO#", contratoLocacao.PrazoLocacao.ToString(), true, true);
            contrato.Replace("#INICIO_CONTRATO#", contratoLocacao.DataInicioLocacao.ToShortDateString(), true, true);
            contrato.Replace("#TERMINO_CONTRATO#", contratoLocacao.DataInicioLocacao.AddMonths(contratoLocacao.PrazoLocacao).ToShortDateString(), true, true);
            contrato.Replace("#VALOR#", contratoLocacao.ValorAluguel.ToString("C", CultureInfo.CurrentCulture), true, true);
            contrato.Replace("#VALOR_EXTENSO#", DinheiroPorExtenso.Converter(contratoLocacao.ValorAluguel), true, true);
            contrato.Replace("#VENCIMENTO#", contratoLocacao.DataInicioLocacao.Day.ToString(), true, true);
            contrato.Replace("#DATA_GERACAO_CONTRATO#", contratoLocacao.DataGeracao.ToString(@"dd \de MMMM \de yyyy"), true, true);
        }
    }
}
