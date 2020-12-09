using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Models
{
    public class OrderItemModelMapper: Profile
    {
        public OrderItemModelMapper()
        {
            CreateMap<OrderItemEntity, OrderItemModel>()
                .ForMember(
                    dest => dest.ProductImg,
                    opt => opt.MapFrom(src => src.Product.Img))
                .ForMember(
                dest => dest.ProductNameRu,
                opt => opt.MapFrom(src => src.Product.NameRu))
                .ForMember(
                    dest => dest.ProductNameEng,
                    opt => opt.MapFrom(src => src.Product.NameEng));
        }
    }
}
