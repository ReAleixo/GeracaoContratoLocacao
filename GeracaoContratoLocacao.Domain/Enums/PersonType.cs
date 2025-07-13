using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class PersonType : Enumeration
    {
        public static readonly PersonType Lessor = new(1, "Locador");
        public static readonly PersonType Lessee = new(2, "Locatário");
        public static readonly PersonType Spouse = new(3, "Cônjuge");

        protected PersonType(int id, string name) : base(id, name)
        {
        }
    }
}
