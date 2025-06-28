using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }
}
