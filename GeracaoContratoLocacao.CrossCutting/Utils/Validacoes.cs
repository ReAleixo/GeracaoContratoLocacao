using Caelum.Stella.CSharp.Validation;

namespace GeracaoContratoLocacao.CrossCutting.Utils
{
    public class Validacoes
    {
        public static string ValidarCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentException("O CPF não pode ser vazio.");
            }

            CPFValidator cpfValidator = new CPFValidator();
            if (!cpfValidator.IsValid(cpf))
            {
                throw new ArgumentException("CPF inválido.");
            }

            return cpf;
        }
    }
}
