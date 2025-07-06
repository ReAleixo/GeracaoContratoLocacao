using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class StatusLogico : Enumeration
    {
        public static readonly StatusLogico Inativo = new StatusLogico(0, "Inativo");
        public static readonly StatusLogico Ativo = new StatusLogico(1, "Ativo");

        protected StatusLogico(int id, string name) : base(id, name)
        {
        }
    }
}
