using Caelum.Stella.CSharp.Validation;

namespace GeracaoContratoLocacao.CrossCutting.Utils
{
    public class Validacoes
    {
        public static bool DocumentIsValid(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentException("O CPF não pode ser vazio.");
            }

            CPFValidator cpfValidator = new CPFValidator();
            return cpfValidator.IsValid(cpf);
        }
    }
}
