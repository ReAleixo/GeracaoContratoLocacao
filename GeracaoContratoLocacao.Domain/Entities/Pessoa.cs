using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public Endereco Endereco { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
    }
}
