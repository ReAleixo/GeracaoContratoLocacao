namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class ImovelViewModel
    {
        public Guid IdImovel { get; set; }
        public Guid IdLocadorProprietario { get; set; }
        public int NumeroComodos { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool ImovelLocado { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public bool IsNullOrEmpty()
        {
            return IdImovel == default
                && IdLocadorProprietario == default
                && NumeroComodos == default
                && ValorAluguel == default
                && !ImovelLocado
                && string.IsNullOrEmpty(Rua)
                && Numero == default
                && string.IsNullOrEmpty(Rua)
                && string.IsNullOrEmpty(Complemento)
                && string.IsNullOrEmpty(Bairro)
                && string.IsNullOrEmpty(Cidade)
                && string.IsNullOrEmpty(Estado)
                && string.IsNullOrEmpty(CEP);
        }
    }
}
