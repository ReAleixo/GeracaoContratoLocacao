using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IContratoService
    {
        void GerarContratoLocacao(Contrato contratoLocacao, string pathDestino);
    }
}
