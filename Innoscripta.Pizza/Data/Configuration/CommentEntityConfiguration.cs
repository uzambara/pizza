using System;
using System.Collections.Generic;
using Innoscripta.Pizza.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class CommentEntityConfiguration: IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.HasData(new List<CommentEntity>()
            {
                 new CommentEntity()
                 {
                     Id = 1,
                     UserId = 1,
                     Date = DateTime.Now,
                     Stars = 2,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 2,
                     UserId = 1,
                     Date = DateTime.Now.AddDays(-1),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 3,
                     UserId = 1,
                     Date = DateTime.Now,
                     Stars = 3,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 4,
                     UserId = 1,
                     Date = DateTime.Now.AddDays(-2),
                     Stars = 5,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 5,
                     UserId = 1,
                     Date = DateTime.Now.AddDays(-3),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 }
                 ,new CommentEntity()
                 {
                     Id = 6,
                     UserId = 1,
                     Date = DateTime.Now.AddDays(-4),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 7,
                     UserId = 2,
                     Date = DateTime.Now,
                     Stars = 2,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 8,
                     UserId = 2,
                     Date = DateTime.Now.AddDays(-1),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 9,
                     UserId = 2,
                     Date = DateTime.Now,
                     Stars = 3,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 10,
                     UserId = 2,
                     Date = DateTime.Now.AddDays(-2),
                     Stars = 5,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 11,
                     UserId = 2,
                     Date = DateTime.Now.AddDays(-3),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 }
                 ,new CommentEntity()
                 {
                     Id = 12,
                     UserId = 2,
                     Date = DateTime.Now.AddDays(-4),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 13,
                     UserId = 4,
                     Date = DateTime.Now,
                     Stars = 2,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 14,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-1),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 15,
                     UserId = 4,
                     Date = DateTime.Now,
                     Stars = 3,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 16,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-2),
                     Stars = 5,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 17,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-3),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 }
                 ,new CommentEntity()
                 {
                     Id = 18,
                     UserId = 3,
                     Date = DateTime.Now.AddDays(-4),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 19,
                     UserId = 4,
                     Date = DateTime.Now,
                     Stars = 2,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 20,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-1),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 21,
                     UserId = 4,
                     Date = DateTime.Now,
                     Stars = 3,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 22,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-2),
                     Stars = 5,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },
                 new CommentEntity()
                 {
                     Id = 23,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-3),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 },new CommentEntity()
                 {
                     Id = 24,
                     UserId = 4,
                     Date = DateTime.Now.AddDays(-4),
                     Stars = 4,
                     Text = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Voluptatem veritatis molestias harum soluta nihil, distinctio, sit aperiam dolor debitis culpa eveniet illum, officiis quo architecto hic magni. Eos, incidunt blanditiis.Dolor repellat eum quidem amet! Doloremque dolores autem illo dolore totam, est quo provident in consequatur eligendi, hic quisquam cumque omnis facilis. Vero minus nesciunt quia neque? Nobis, nisi veritatis.",
                 }
            });
        }
    }
}