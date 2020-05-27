namespace Innoscripta.Pizza.Contracts.User
{
    public class RegisterUserRequest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}