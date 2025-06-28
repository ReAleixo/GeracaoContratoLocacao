namespace GeracaoContratoLocacao.Domain.Entities
{
    public class ContratoLocacao
    {
        public Locador Locador { get; set; }
        public Locatario Locatario { get; set; }
        public Imovel Imovel { get; set; }
        public int PrazoLocacao { get; set; }
        public DateTime DataInicioLocacao { get; set; }
        public decimal ValorAluguel { get; set; }
        public DateTime DataGeracao { get; set; }
    }
}
