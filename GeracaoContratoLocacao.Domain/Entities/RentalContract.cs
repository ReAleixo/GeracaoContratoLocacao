namespace GeracaoContratoLocacao.Domain.Entities
{
    public class RentalContract
    {
        public Lessor Lessor { get; set; }
        public Lessee Lessee { get; set; }
        public House House { get; set; }
        public int MonthsRent { get; set; }
        public DateTime RentalStartDate { get; set; }
        public decimal RentalValue { get; set; }
        public DateTime ContractGenerationDate { get; set; }
    }
}
