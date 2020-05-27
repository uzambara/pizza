
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innoscripta.Pizza.Data.Domain
{
    [Table("Comments")]
    public class CommentEntity: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1024)]
        public string Text { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public byte Stars { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Deleted { get; set; }
    }
}