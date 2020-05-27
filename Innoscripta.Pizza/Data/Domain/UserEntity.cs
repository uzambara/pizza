using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}