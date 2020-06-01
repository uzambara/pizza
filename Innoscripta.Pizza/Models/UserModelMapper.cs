using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class UserModelMapper: Profile
    {
        public UserModelMapper()
        {
            CreateMap<UserEntity, UserModel>();
        }
    }
}