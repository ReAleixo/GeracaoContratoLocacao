namespace GeracaoContratoLocacao.Domain.Entities
{
    public class ContratoLocacao
    {
        public Pessoa Locador { get; set; }
        public Pessoa Locatario { get; set; }
        public Imovel Imovel { get; set; }
        public int PrazoLocacao { get; set; }
        public DateTime DataInicioLocacao { get; set; }
        public DateTime DataFimLocacao { get; set; }
        public decimal ValorAluguel { get; set; }
        public DateTime DataVencimentoPagamento { get; set; }
        public DateTime DataGeracao { get; set; }
    }
}
