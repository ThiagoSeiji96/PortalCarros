using Core.Enums;

namespace Core.Entities
{
    public class Advice
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int ModelYear { get; private set; }
        public int ModelProductionYear { get; private set; }
        public string Color { get; private set; }
        public VehicleTransmissionTypeEnum Transmission { get; private set; }
        public string Hodometer { get; private set; }
        public bool Status { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }


        public void FinishAdvice()
        {
            Status = false;
        }
        public void UpdateDescription(string description)
        {
            Description = description;
        }
    }
}