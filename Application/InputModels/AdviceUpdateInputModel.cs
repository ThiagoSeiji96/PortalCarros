namespace Application.InputModels
{
    public class AdviceUpdateInputModel
    {
        public AdviceUpdateInputModel(string description)
        {
            Description = description;
        }
        public int Id { get; set; }

        public string Description { get; set; }
    }
}
