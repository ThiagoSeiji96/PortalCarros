namespace Core.Entities
{
    public class CarPreservation
    {
        public int Id { get; set; }
        public int Id_Advice { get; set; }
        public AdviceDetails AdviceDetails { get; set; }
        public bool UnicoDono { get; set; }
        public bool ComManual { get; set; }
        public bool ChaveReserva { get; set; }
        public bool RevisoesConcessionaria { get; set; }
        public bool ComGarantia { get; set; }
    }
}