namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class ContratoViewModel
    {
        public Guid Id { get; set; }
        public string NomeLocatario { get; set; }
        public string CPFLocatario { get; set; }
        public string RGLocatario { get; set; }
        public string DataInicioContrato { get; set; }
        public string PrazoContrato { get; set; }
        public int NumeroCasa { get; set; }
        public string ValorAluguel { get; set; }

        public ContratoViewModel(
            string nomeLocatario,
            string cpfLocatario,
            string rgLocatario,
            string dataInicioContrato,
            string prazoContrato,
            int numeroCasa,
            string valorAluguel)
        {
            NomeLocatario = ValidaNomeLocatario(nomeLocatario);
            CPFLocatario = cpfLocatario;
            RGLocatario = rgLocatario;
            DataInicioContrato = dataInicioContrato;
            PrazoContrato = prazoContrato;
            NumeroCasa = numeroCasa;
            ValorAluguel = valorAluguel;
            Id = Guid.NewGuid();
        }

        private string ValidaNomeLocatario(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome.Trim()))
            {
                throw new ArgumentException("O nome do locatário não pode ser vazio.");
            }
            if (nome.Length > 200)
            {
                throw new ArgumentException("O nome do locatário não pode ter mais de 200 caracteres.");
            }
            if(nome.Split(' ').Count() < 2)
            {
                throw new ArgumentException("O nome do locatário deve conter pelo menos um sobrenome.");
            }
            return nome;
        }
    }
}
