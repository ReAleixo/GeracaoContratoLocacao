using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Imovel
    {
        public Guid Id { get; set; }
        public Pessoa Proprietario { get; set; }
        public Endereco Endereco { get; set; }
        public int NumeroComodos { get; set; }
        public decimal ValorAluguel { get; set; }
        public bool Locado { get; set; }

        public bool IsNullOrEmpty()
        {
            return Id == default
                && Endereco == default
                && Proprietario == default
                && NumeroComodos == default
                && ValorAluguel == default;
        }

        public override string ToString()
        {
            return $"{Endereco.Rua}, nº {Endereco.Numero} {(!string.IsNullOrEmpty(Endereco.Complemento) ? $"({Endereco.Complemento}) " : string.Empty)}- {Endereco.Bairro}, {Endereco.Cidade} - {Endereco.Estado}, {Endereco.CEP}";
        }
    }
}
