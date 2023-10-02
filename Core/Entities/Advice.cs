using Core.Enums;

namespace Core.Entities
{
    public class Advice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public AdviceDetails AdviceDetails { get; set; }
        public User User { get; set; }
        public int IdUser { get; set; }


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