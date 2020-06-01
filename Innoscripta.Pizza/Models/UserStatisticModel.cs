namespace Innoscripta.Pizza.Models
{
    public class UserStatisticModel
    {
        public int OrdersCount { get; set; }
        public decimal TotalOrdersPrice { get; set; }
        public decimal Bonus { get; set; }
    }
}