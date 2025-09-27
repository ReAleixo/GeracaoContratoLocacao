namespace GeracaoContratoLocacao.Domain.ValueObjects
{
    public class FiltroPessoas
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public bool? ExibirLocador { get; set; }
        public bool? ExibirLocatario { get; set; }
        public bool? ExibirConjuge { get; set; }
    }
}
