using System.Collections.Generic;
using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Account;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IUserService
    {
        Task<AccountRegistrationResponse> RegisterUserAsync(AccountRegistrationRequest request);
        Task<UserEntity> GetUserByPhoneAsync(string phone);
        Task<UserEntity> GetCurrentUserAsync();
        Task<IEnumerable<OrderModel>> GetHistoryAsync(int userId);
        Task<UserStatisticModel> GetStatisticAsync(int userId);
    }
}