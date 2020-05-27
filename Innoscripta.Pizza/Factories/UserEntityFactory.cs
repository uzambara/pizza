using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Factories
{
    public class UserEntityFactory
    {
        public UserEntity Create(string name, string lastName, string phone, string password)
        {
            return new UserEntity
            {
                Name = name,
                LastName = lastName,
                Phone = phone,
                Password = password
            };
        }
    }
}