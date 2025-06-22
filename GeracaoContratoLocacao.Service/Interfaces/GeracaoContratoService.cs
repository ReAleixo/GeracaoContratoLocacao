using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Utils;
using GeracaoContratoLocacao.Service.Services;
using Spire.Doc;

namespace GeracaoContratoLocacao.Service.Interfaces
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
                documentoContratoModelo.SaveToFile(pathDestino + ".pdf", new ToPdfParameterList());
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void EditDocument(Document contrato, ContratoLocacao contratoLocacao)
        {
            contrato.Replace("#NOME_LOCATARIO#", contratoLocacao.Locatario.Nome, true, true);
            contrato.Replace("#CPF_LOCATARIO#", contratoLocacao.Locatario.CPF, true, true);
            contrato.Replace("#RG_LOCATARIO#", contratoLocacao.Locatario.RG, true, true);
            contrato.Replace("#CASA#", contratoLocacao.Imovel.Endereco.Complemento, true, true);
            contrato.Replace("#PRAZO#", contratoLocacao.PrazoLocacao.ToString(), true, true);
            contrato.Replace("#INICIO_CONTRATO#", contratoLocacao.DataInicioLocacao.ToShortDateString(), true, true);
            contrato.Replace("#TERMINO_CONTRATO#", contratoLocacao.DataFimLocacao.ToShortDateString(), true, true);
            contrato.Replace("#VALOR#", contratoLocacao.ValorAluguel.ToString(), true, true);
            contrato.Replace("#VALOR_EXTENSO#", contratoLocacao.ValorAluguel.ToString("C", System.Globalization.CultureInfo.CurrentCulture), true, true);
            contrato.Replace("#VENCIMENTO#", contratoLocacao.DataVencimentoPagamento.ToString(), true, true);
            contrato.Replace("#DATA_GERACAO_CONTRATO#", contratoLocacao.DataGeracao.ToShortDateString(), true, true);
        }
    }
}
