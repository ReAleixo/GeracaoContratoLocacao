using GeracaoContratoLocacao.Domain.Enums;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public Gender Gender { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Pessoa? Spouse { get; set; }
        public TipoPessoa PersonType { get; set; }
        public List<Imovel> Houses { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && string.IsNullOrEmpty(Nome)
                && string.IsNullOrEmpty(CPF)
                && string.IsNullOrEmpty(RG)
                && DataNascimento == default
                && Gender == default
                && EstadoCivil == null;
        }
    }
}
