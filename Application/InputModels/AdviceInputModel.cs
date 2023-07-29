using Core.Enums;

namespace Application.InputModels
{
    public class AdviceInputModel
    {
        public AdviceInputModel(int id, string model, string brand, int year, string color, VehicleTransmissionTypeEnum transmission, string hodometer)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            Transmission = transmission;
            Hodometer = hodometer;
        }

        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
        public string Color { get; private set; }
        public VehicleTransmissionTypeEnum Transmission { get; private set; }
        public string Hodometer { get; private set; }
        public string Description{ get; set; }
        public int IdUser { get; private set; }
    }
}
