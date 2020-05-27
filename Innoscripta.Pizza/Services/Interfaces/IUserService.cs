using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.User;

namespace Innoscripta.Pizza.Services.Interfaces
{
    public interface IUserService
    {
        public Task<RegisterUserResponse> RegisterAsync(RegisterUserRequest request);
    }
}