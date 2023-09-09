using Core.Enums;

namespace Application.InputModels
{
    public class AdviceInputModel
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public string Year { get; private set; }
        public string Color { get; private set; }
        public bool Transmission { get; private set; }
        public string Hodometer { get; private set; }
        public string Description{ get; private set; }
        public string IdUser { get; private set; }
    }
}
