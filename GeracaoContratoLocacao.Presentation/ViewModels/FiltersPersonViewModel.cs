using GeracaoContratoLocacao.CrossCutting.Utils;

namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class FiltersPersonViewModel
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public bool? ShowLessee { get; set; }
        public bool? ShowLessor { get; set; }

        public FiltersPersonViewModel(string? name = null, string? document = null, bool? showLessee = null, bool? showLessor = null)
        {
            Name = name;
            Document = document;
            ShowLessee = showLessee;
            ShowLessor = showLessor;
            EnsureValid();
        }

        public bool IsNullOrEmpty()
        {
            return string.IsNullOrEmpty(Name)
                && string.IsNullOrEmpty(Document)
                && ShowLessee == null
                && ShowLessor == null;
        }

        private void EnsureValid()
        {
            if (IsNullOrEmpty())
            {
                throw new ArgumentException("Pelo menos um filtro deve ser declarado.");
            }
            if ((ShowLessee == null || !ShowLessee.Value)
                && (ShowLessor == null || !ShowLessor.Value))
            {
                throw new ArgumentException("Pelo menos um tipo de pessoa deve ser selecionado.");
            }
            if (string.IsNullOrEmpty(Name) 
                && string.IsNullOrEmpty(Document))
            {
                throw new ArgumentException("Pelo menos um filtro de nome ou documento deve ser declarado.");
            }
            if (!string.IsNullOrEmpty(Document))
            {
                Document = Formatacoes.FormatarCPF(Document);
            }
        }
    }
}
