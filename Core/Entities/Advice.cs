using Core.Enums;

namespace Core.Entities
{
    public class Advice
    {
        public Advice(int id, string model, string brand, int year, string color,
            VehicleTransmissionTypeEnum transmission, string hodomometer, int idUser, string description)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            Transmission = transmission;
            Hodometer = hodomometer;
            IdUser = idUser;
            CreatedAt = DateTime.Now;
            Status = true;
            Description = description;
        }

        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
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