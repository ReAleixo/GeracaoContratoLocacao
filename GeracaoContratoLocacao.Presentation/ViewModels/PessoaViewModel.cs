using GeracaoContratoLocacao.CrossCutting.Utils;

namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class PessoaViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string RG { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string PersonType { get; set; }
        public string? MaritalStatus { get; set; }
        public Guid? SpouseId { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && string.IsNullOrEmpty(Name)
                && string.IsNullOrEmpty(Document)
                && string.IsNullOrEmpty(BirthDate)
                && string.IsNullOrEmpty(Gender)
                && string.IsNullOrEmpty(PersonType)
                && string.IsNullOrEmpty(MaritalStatus)
                && SpouseId == default;
        }

        public bool IsValid()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Nome não foi informado.");
            }

            if (Name.Split(' ').Count() < 2)
            {
                throw new ArgumentException("Nome deve conter pelo menos nome e sobrenome.");
            }

            if (string.IsNullOrEmpty(Document))
            {
                throw new ArgumentException("CPF não informado.");
            }
            
            if (!Validacoes.DocumentIsValid(Document))
            {
                throw new ArgumentException("CPF inválido.");
            }

            if (string.IsNullOrEmpty(BirthDate))
            {
                throw new ArgumentException("Data de nascimento não foi informada.");
            }

            if (!DateTime.TryParse(BirthDate, out _))
            {
                throw new ArgumentException("Data de nascimento inválida.");
            }

            if (string.IsNullOrEmpty(Gender))
            {
                throw new ArgumentException("Gênero não informado.");
            }

            if (string.IsNullOrEmpty(PersonType))
            {
                throw new ArgumentException("Tipo de pessoa não informado.");
            }

            if (PersonType != Domain.Enums.PersonType.Spouse.Name
                && string.IsNullOrEmpty(MaritalStatus))
            {
                throw new ArgumentException("Estado civil não informado.");
            }

            return true;
        }
    }
}
