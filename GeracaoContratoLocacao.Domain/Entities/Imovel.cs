using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Imovel
    {
        public Guid Id { get; set; }
        public Endereco Endereco { get; set; }
        public int NumeroComodos { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool Locado { get; set; }
    }
}
