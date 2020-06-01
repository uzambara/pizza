using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class GetCurrentUserResponse
    {
        public UserModel User { get; set; }
    }
}
