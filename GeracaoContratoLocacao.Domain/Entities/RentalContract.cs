namespace GeracaoContratoLocacao.Domain.Entities
{
    public class RentalContract
    {
        public Person Lessor { get; set; }
        public Person Lessee { get; set; }
        public House House { get; set; }
        public int MonthsRent { get; set; }
        public DateTime RentalStartDate { get; set; }
        public decimal RentalValue { get; set; }
        public DateTime ContractGenerationDate { get; set; }
    }
}
