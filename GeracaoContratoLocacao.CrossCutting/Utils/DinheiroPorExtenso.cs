using Caelum.Stella.CSharp.Inwords;

namespace GeracaoContratoLocacao.CrossCutting.Utils
{
    public class DinheiroPorExtenso
    {
        public static string Converter(decimal valor)
        {
            MoedaBRL moeda = new MoedaBRL(Convert.ToDouble(valor));
            return moeda.Extenso();
        }
    }
}
