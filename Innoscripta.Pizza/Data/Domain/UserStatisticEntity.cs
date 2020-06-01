using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innoscripta.Pizza.Data.Domain
{
    [Table("UserStatistics")]
    public class UserStatisticEntity: IEntityBase
    {
        /// <summary>
        /// UserId
        /// </summary>
        [Key, ForeignKey("User")]
        [Column("UserId")]
        public int Id { get; set; }
        public UserEntity User { get; set; }
        public int OrdersCount { get; set; }
        public decimal TotalOrdersPrice { get; set; }
        public decimal Bonus { get; set; }
    }
}