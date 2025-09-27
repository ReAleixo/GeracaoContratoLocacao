using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class TipoPessoa : Enumeration
    {
        public static readonly TipoPessoa Locador = new(1, "Locador");
        public static readonly TipoPessoa Locatario = new(2, "Locatário");
        public static readonly TipoPessoa Spouse = new(3, "Cônjuge");

        public TipoPessoa(int id, string name) : base(id, name)
        {

        }
    }
}
