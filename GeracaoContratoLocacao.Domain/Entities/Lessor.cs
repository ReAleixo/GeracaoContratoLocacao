namespace GeracaoContratoLocacao.Domain.Entities
{
    public class Lessor : Person
    {
        public List<House> Houses { get; set; }
    }
}
