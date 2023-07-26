using Core.Enums;

namespace Core.Entities
{
    public class Advice
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public VehicleTransmissionTypeEnum Transmission { get; private set; }
        public string Hodometer { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int IdUser { get; private set; }
        public User User { get; private set; }
    }
}