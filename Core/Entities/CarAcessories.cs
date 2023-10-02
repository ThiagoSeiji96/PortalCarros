namespace Core.Entities
{
    public class CarAcessories
    {
        public int Id { get; set; }
        public AdviceDetails AdviceDetails { get; set; }
        public int Id_AdviceDetails { get; set; }
        public bool AirBag { get; set; }
        public bool Alarme { get; set; }
        public bool ArCondicionado { get; set; }
        public bool TravaEletrica { get; set; }
        public bool VidroEletrico { get; set; }
        public bool Som { get; set; }
        public bool SensorRe { get; set; }
        public bool CameraRe { get; set; }
        public bool Blindado { get; set; }
    }
}