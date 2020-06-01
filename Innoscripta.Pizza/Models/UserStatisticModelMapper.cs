using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class UserStatisticModelMapper: Profile
    {
        public UserStatisticModelMapper()
        {
            CreateMap<UserStatisticEntity, UserStatisticModel>();
        }
    }
}