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

        public void GerarContratoLocacao(RentalContract contratoLocacao, string pathDestino)
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

                string nomeNovoArquivo = $"Contrato de locação - Locatário {contratoLocacao.Lessee.Nome}.pdf";
                string fullPath = Path.Combine(pathDestino, nomeNovoArquivo);
                documentoContratoModelo.SaveToFile(fullPath);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void EditDocument(Document contrato, RentalContract contratoLocacao)
        {
            contrato.Replace("#NOME_LOCATARIO#", contratoLocacao.Lessee.Nome.ToUpper(), true, true);
            contrato.Replace("#CPF_LOCATARIO#", contratoLocacao.Lessee.CPF, true, true);
            contrato.Replace("#RG_LOCATARIO#", contratoLocacao.Lessee.RG, true, true);
            contrato.Replace("#CASA#", contratoLocacao.House.Endereco.Complemento, true, true);
            contrato.Replace("#PRAZO#", contratoLocacao.MonthsRent.ToString(), true, true);
            contrato.Replace("#INICIO_CONTRATO#", contratoLocacao.RentalStartDate.ToShortDateString(), true, true);
            contrato.Replace("#TERMINO_CONTRATO#", contratoLocacao.RentalStartDate.AddMonths(contratoLocacao.MonthsRent).ToShortDateString(), true, true);
            contrato.Replace("#VALOR#", contratoLocacao.RentalValue.ToString("C", CultureInfo.CurrentCulture), true, true);
            contrato.Replace("#VALOR_EXTENSO#", DinheiroPorExtenso.Converter(contratoLocacao.RentalValue), true, true);
            contrato.Replace("#VENCIMENTO#", contratoLocacao.RentalStartDate.Day.ToString(), true, true);
            contrato.Replace("#DATA_GERACAO_CONTRATO#", contratoLocacao.ContractGenerationDate.ToString(@"dd \de MMMM \de yyyy"), true, true);
        }
    }
}
