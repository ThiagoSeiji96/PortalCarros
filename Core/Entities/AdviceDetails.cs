using Core.Enums;

namespace Core.Entities
{
    public class AdviceDetails
    {
        public int Id { get; set; }
        public Advice Advice { get; set; }
        public int Id_Advice { get; set; }
        public CarBrand Brand { get; set; }
        public int Id_Brand { get; set; }
        public CarModel CarModel { get; set; }
        public int Id_CarModel { get; set; }
        public CarAcessories CarAcessories{ get; set; }
        public int Id_CarAcessories { get; set; }
        public CarRegularization CarRegularization { get; set; }
        public int Id_CarRegularization { get; set; }
        public CarPreservation CarPreservation { get; set; }
        public int Id_CarPreservation { get; set; }
        public DoorNumberEnum DoorNumbers { get; set; }
        public GasTypeEnum GasType{ get; set; }
        public SteeringTypeEnum SteeringType { get; set; }
        public TransmissionTypeEnum TransmissionType { get; set; }
        public string Hodometer { get; set; }
        public string RotationDay { get; set; }
        public bool HasGnv { get; set; }
    }
}