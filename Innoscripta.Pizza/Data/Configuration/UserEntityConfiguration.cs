using System;
using System.Collections.Generic;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Data.Enums;
using Innoscripta.Pizza.Services.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Innoscripta.Pizza.Data.Configuration
{
    public class UserEntityConfiguration: IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            var hashService = new HashService();
             builder.HasData(new List<UserEntity>()
             {
                 new UserEntity()
                 {
                     Id = -1,
                     Name = "Vasiliy",
                     Password = hashService.HashPassword("123"),
                     LastName = "Pupkin",
                     Phone = "1234567891",
                     Role = UserRole.Client,
                 },
                 new UserEntity()
                 {
                     Id = -2,
                     Name = "Mariya",
                     Password = hashService.HashPassword("123"),
                     LastName = "Ivanova",
                     Phone = "1234567892",
                     Role = UserRole.Client,
                 },
                 new UserEntity()
                 {
                     Id = -3,
                     Name = "Petr",
                     Password = hashService.HashPassword("123"),
                     LastName = "Levin",
                     Phone = "1234567893",
                     Role = UserRole.Client
                 },
                 new UserEntity()
                 {
                     Id = -4,
                     Name = "Ivan",
                     Password = hashService.HashPassword("123"),
                     LastName = "Bikov",
                     Phone = "1234567894",
                     Role = UserRole.Client
                 }
            });
        }
    }
}