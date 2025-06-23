using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IGeracaoContratoService
    {
        void GerarContratoLocacao(ContratoLocacao contratoLocacao, string pathDestino);
    }
}
