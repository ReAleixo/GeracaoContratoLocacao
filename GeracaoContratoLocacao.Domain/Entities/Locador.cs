namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Locador : Pessoa
    {
        public List<Imovel> Imoveis { get; set; }
    }
}
