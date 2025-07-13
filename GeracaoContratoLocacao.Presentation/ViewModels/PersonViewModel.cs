namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class PersonViewModel
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
                && string.IsNullOrEmpty(RG)
                && string.IsNullOrEmpty(BirthDate)
                && string.IsNullOrEmpty(Gender)
                && string.IsNullOrEmpty(PersonType)
                && string.IsNullOrEmpty(MaritalStatus)
                && SpouseId == default;
        }
    }
}
