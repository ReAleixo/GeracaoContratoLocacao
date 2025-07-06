using GeracaoContratoLocacao.Domain.Entities;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IGeracaoContratoService
    {
        void GerarContratoLocacao(RentalContract contratoLocacao, string pathDestino);
    }
}
