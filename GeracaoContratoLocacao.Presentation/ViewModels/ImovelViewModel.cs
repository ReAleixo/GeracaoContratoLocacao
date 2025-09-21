namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class ImovelViewModel
    {
        public Guid Id { get; set; }
        public Guid IdProprietario { get; set; }
        public string? NomeProprietario { get; set; }
        public int NumeroComodos { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool ImovelLocado { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public string ImovelLocadoPorExtenso 
        { 
            get
            { 
                return ImovelLocado ? "Locado" : "Não Locado";
            }
        }

        public string EnderecoCompleto
        {
            get
            {
                return ToString();
            }
        }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && IdProprietario == default
                && string.IsNullOrEmpty(NomeProprietario)
                && NumeroComodos == default
                && ValorAluguel == default
                && !ImovelLocado
                && string.IsNullOrEmpty(Rua)
                && Numero == default
                && string.IsNullOrEmpty(Complemento)
                && string.IsNullOrEmpty(Bairro)
                && string.IsNullOrEmpty(Cidade)
                && string.IsNullOrEmpty(Estado)
                && string.IsNullOrEmpty(CEP);
        }

        public override string ToString()
        {
            return $"{Rua}, {Numero} {(!string.IsNullOrEmpty(Complemento) ? $"({Complemento}) " : string.Empty)}- {Bairro}, {Cidade} - {Estado}, {CEP}";
        }
    }
}
