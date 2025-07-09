namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class PersonViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string LogicalStatus { get; set; }
        public string Category { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && string.IsNullOrEmpty(Name)
                && string.IsNullOrEmpty(Document)
                && string.IsNullOrEmpty(RG)
                && BirthDate == default
                && string.IsNullOrEmpty(MaritalStatus)
                && string.IsNullOrEmpty(LogicalStatus)
                && string.IsNullOrEmpty(Category);
        }
    }
}
