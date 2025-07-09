using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public LogicalStatus LogicalStatus { get; set; }
        public bool IsLessor { get; set; }
        public List<House> Houses { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && string.IsNullOrEmpty(Nome)
                && string.IsNullOrEmpty(CPF)
                && string.IsNullOrEmpty(RG)
                && DataNascimento == default
                && EstadoCivil == null
                && LogicalStatus == null;
        }
    }
}
