using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class CommentModelMapper: Profile
    {
        public CommentModelMapper()
        {
            CreateMap<CommentEntity, CommentModel>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.User.Name));
        }
    }
}