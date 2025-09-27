using GeracaoContratoLocacao.CrossCutting.Utils;
using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.Utils;
using GeracaoContratoLocacao.Service.Interfaces;
using Spire.Doc;
using System.Globalization;

namespace GeracaoContratoLocacao.Service.Services
{
    public class ContratoService : IContratoService
    {
        public void GerarContratoLocacao(Contrato contratoLocacao, string pathDestino)
        {
            if (contratoLocacao == null)
            {
                throw new ArgumentNullException("O contrato de locação não foi informado.");
            }

            if (string.IsNullOrEmpty(pathDestino))
            {
                throw new ArgumentException("O caminho de destino não foi selecionado.");
            }

            try
            {
                var documentoContratoModelo = new Document();
                documentoContratoModelo.LoadFromFile(Paths.pathModeloContrato);
                EditarDocumento(documentoContratoModelo, contratoLocacao);

                string nomeNovoArquivo;
                if (contratoLocacao.Locatario.Gender.Equals(Gender.Male))
                {
                    nomeNovoArquivo = $"Contrato de locação - Locatário {contratoLocacao.Locatario.Nome}.pdf";
                }
                else
                {
                    nomeNovoArquivo = $"Contrato de locação - Locatária {contratoLocacao.Locatario.Nome}.pdf";
                }

                string fullPath = Path.Combine(pathDestino, nomeNovoArquivo);
                documentoContratoModelo.SaveToFile(fullPath);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void EditarDocumento(Document contrato, Contrato contratoLocacao)
        {
            contrato.Replace("#NOME_LOCADOR#", contratoLocacao.Locador.Nome.ToUpper(), true, true);
            contrato.Replace("#CPF_LOCADOR#", contratoLocacao.Locador.CPF, true, true);
            contrato.Replace("#RG_LOCADOR#", contratoLocacao.Locador.RG.ToUpper(), true, true);
            contrato.Replace("#NOME_LOCATARIO#", contratoLocacao.Locatario.Nome.ToUpper(), true, true);
            contrato.Replace("#CPF_LOCATARIO#", contratoLocacao.Locatario.CPF, true, true);
            contrato.Replace("#RG_LOCATARIO#", contratoLocacao.Locatario.RG.ToUpper(), true, true);
            contrato.Replace("#ENDERECO_IMOVEL#", contratoLocacao.Imovel.ToString(), true, true);
            contrato.Replace("#PRAZO#", contratoLocacao.Prazo.ToString(), true, true);
            contrato.Replace("#INICIO_CONTRATO#", contratoLocacao.DataInicio.ToShortDateString(), true, true);
            contrato.Replace("#TERMINO_CONTRATO#", contratoLocacao.DataInicio.AddMonths(contratoLocacao.Prazo).ToShortDateString(), true, true);
            contrato.Replace("#VALOR#", contratoLocacao.Imovel.ValorAluguel.ToString("C", CultureInfo.CurrentCulture), true, true);
            contrato.Replace("#VALOR_EXTENSO#", DinheiroPorExtenso.Converter(contratoLocacao.Imovel.ValorAluguel), true, true);
            contrato.Replace("#VENCIMENTO#", contratoLocacao.DataInicio.Day.ToString(), true, true);
            contrato.Replace("#DATA_GERACAO_CONTRATO#", contratoLocacao.DataGeracao.ToString(@"dd \de MMMM \de yyyy"), true, true);
        }
    }
}
