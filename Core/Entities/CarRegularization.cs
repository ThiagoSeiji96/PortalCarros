namespace Core.Entities
{
    public class CarRegularization
    {
        public int Id { get; set; }
        public int Id_Advice { get; set; }
        public AdviceDetails AdviceDetail { get; set; }
        public bool IpvaPago { get; set; }
        public bool PossuiMultas { get; set; }
        public bool PassagemLeilao { get; set; }
    }
}