namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Locador : Pessoa
    {
        public List<House> Houses { get; set; }
    }
}
