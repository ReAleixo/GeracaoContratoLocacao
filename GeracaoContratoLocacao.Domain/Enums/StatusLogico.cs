using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class StatusLogico : Enumeration
    {
        public static readonly StatusLogico Ativo = new StatusLogico(0, "Ativo");
        public static readonly StatusLogico Inativo = new StatusLogico(1, "Inativo");

        protected StatusLogico(int id, string name) : base(id, name)
        {
        }
    }
}
