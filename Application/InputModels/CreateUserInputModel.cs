namespace Application.InputModels
{
    public class CreateUserInputModel
    {
        public CreateUserInputModel(int id, string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            //BirthDate? = birthDate;
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public DateTime? BirthDate { get; set; }
    }
}
