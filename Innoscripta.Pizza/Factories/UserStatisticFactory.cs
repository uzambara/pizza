using Innoscripta.Pizza.Data.Domain;

namespace Innoscripta.Pizza.Factories
{
    public class UserStatisticFactory
    {
        public UserStatisticEntity Create(int userId)
        {
            return new UserStatisticEntity()
            {
                Id = userId,
                Bonus = 0,
                OrdersCount = 0,
                TotalOrdersPrice = 0
            };
        }
    }
}