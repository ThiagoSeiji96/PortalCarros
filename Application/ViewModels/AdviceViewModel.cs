namespace Application.ViewModels
{
    public class AdviceViewModel
    {
        public AdviceViewModel(int id, string model, string brand, int year)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Year = year;
        }

        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
    }
}
