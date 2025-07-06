using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public abstract class Person
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public StatusLogico StatusLogico { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && string.IsNullOrEmpty(Nome)
                && string.IsNullOrEmpty(CPF)
                && string.IsNullOrEmpty(RG)
                && DataNascimento == default
                && EstadoCivil == null
                && StatusLogico == null;
        }
    }
}
