using Caelum.Stella.CSharp.Format;

namespace GeracaoContratoLocacao.CrossCutting.Utils
{
    public class Formatacoes
    {
        public static string FormatarCPF(string cpf)
        {
            CPFFormatter cpfFormatter = new CPFFormatter();
            if (!cpfFormatter.CanBeFormatted(cpf)
                || cpfFormatter.IsFormatted(cpf))
            {
                return cpf;
            }

            return cpfFormatter.Format(cpf);
        }
    }
}
