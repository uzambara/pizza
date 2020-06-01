using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Innoscripta.Pizza.Data.Enums;

namespace Innoscripta.Pizza.Data.Domain
{
    [Table("Users")]
    public class UserEntity: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        [MaxLength(128)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(128)]
        public string Password { get; set; }
        public DateTime? BirthDay { get; set; }
        public DateTime? Deleted { get; set; }
        public CreateUserPlace CreateUserPlace { get; set; }
        public UserRole Role { get; set; }
        public UserStatisticEntity Statistic { get; set; }
        public List<CommentEntity> Comments { get; set; }
    }
}