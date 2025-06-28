using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class EstadoCivil : Enumeration
    {
        public static readonly EstadoCivil Solteiro = new EstadoCivil(1, "Solteiro");
        public static readonly EstadoCivil Casado = new EstadoCivil(2, "Casado");
        public static readonly EstadoCivil Divorciado = new EstadoCivil(3, "Divorciado");
        public static readonly EstadoCivil Viuvo = new EstadoCivil(4, "Viúvo");
        public static readonly EstadoCivil Separado = new EstadoCivil(5, "Separado");
        public static readonly EstadoCivil UniaoEstavel = new EstadoCivil(6, "União Estável");

        protected EstadoCivil(int id, string name) : base(id, name)
        {
        }
    }
}
