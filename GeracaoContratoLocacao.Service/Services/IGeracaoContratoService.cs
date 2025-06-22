using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Services
{
    public interface IGeracaoContratoService
    {
        void GerarContratoLocacao(ContratoLocacao contratoLocacao, string pathDestino);
    }
}
