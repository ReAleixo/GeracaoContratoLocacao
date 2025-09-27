using GeracaoContratoLocacao.CrossCutting.Utils;

namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class FiltrosPessoaViewModel
    {
        public string? Name { get; set; }
        public string? Document { get; set; }
        public bool? ShowLessee { get; set; }
        public bool? ShowLessor { get; set; }

        public FiltrosPessoaViewModel(string? name = null, string? document = null, bool? showLessee = null, bool? showLessor = null)
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

            if (!string.IsNullOrEmpty(Document))
            {
                Document = Formatacoes.FormatarCPF(Document);
            }
        }
    }
}
