namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IHashService
    {
        bool VerifyPassword(string hashedPassword, string password);
        string HashPassword(string password);
    }
}