using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Contracts.Order
{
    public class GetUserStatisticResponse: BaseResponse
    {
        public UserStatisticModel Statistic { get; set; }
    }
}