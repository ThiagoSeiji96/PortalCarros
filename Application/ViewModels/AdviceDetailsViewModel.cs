using Core.Enums;

namespace Application.ViewModels
{
    public class AdviceDetailsViewModel
    {
        public AdviceDetailsViewModel(int id, string model, string brand, int year, string color, TransmissionTypeEnum transmission, string hodometer)
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
        public TransmissionTypeEnum Transmission { get; private set; }
        public string Hodometer { get; private set; }
    }
}
