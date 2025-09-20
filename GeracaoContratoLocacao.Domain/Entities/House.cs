using GeracaoContratoLocacao.Domain.Enums;
using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class House
    {
        public Guid Id { get; set; }
        public Person Owner { get; set; }
        public Endereco Endereco { get; set; }
        public int NumeroComodos { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool Locado { get; set; }
        public LogicalStatus LogicalStatus { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && Endereco == null
                && Owner == null
                && NumeroComodos == default
                && ValorAluguel == default
                && !Locado
                && LogicalStatus == null;
        }
    }
}
