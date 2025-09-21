using GeracaoContratoLocacao.Domain.Enums.Base;

namespace GeracaoContratoLocacao.Domain.Enums
{
    public class ModeloContrato : Enumeration
    {
        public static readonly ModeloContrato Padrao = new(1, "Modelo Padrão");
        public static readonly ModeloContrato Simples = new(2, "Modelo Simples");
        public static readonly ModeloContrato Completo = new(3, "Modelo Completo");
        public static readonly ModeloContrato Personalizado = new(4, "Modelo Personalizado");

        public ModeloContrato(int id, string name) : base(id, name)
        {

        }
    }
}
