using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class LogicalStatus : Enumeration
    {
        public static readonly LogicalStatus Inactive = new LogicalStatus(0, "Inativo");
        public static readonly LogicalStatus Active = new LogicalStatus(1, "Ativo");

        protected LogicalStatus(int id, string name) : base(id, name)
        {
        }
    }
}
