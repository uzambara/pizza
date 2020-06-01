using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Factories
{
    public class UserEntityFactory
    {
        public UserEntity Create(string name, string lastName, string phone, string password, CreateUserPlace place)
        {
            return new UserEntity
            {
                Name = name,
                LastName = lastName,
                Phone = phone,
                Password = password,
                CreateUserPlace =  place
            };
        }
    }
}