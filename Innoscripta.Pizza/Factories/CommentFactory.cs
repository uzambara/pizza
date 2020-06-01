using System;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;

namespace Innoscripta.Pizza.Factories
{
    public class CommentFactory
    {
        public CommentEntity Create(UserEntity user, string text, byte stars)
        {
            return new CommentEntity()
            {
                User = user,
                Date = DateTime.Now,
                Stars = stars,
                Text = text
            };
        }
    }
}