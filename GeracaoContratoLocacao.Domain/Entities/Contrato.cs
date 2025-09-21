namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Contrato
    {
        public Guid Id { get; set; }
        public Pessoa Locador { get; set; }
        public Pessoa Locatario { get; set; }
        public Imovel Imovel { get; set; }
        public Guid IdModelo { get; set; }
        public int Prazo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataGeracao { get; set; }
    }
}
