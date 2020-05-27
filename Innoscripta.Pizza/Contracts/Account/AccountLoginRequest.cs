namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountLoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
