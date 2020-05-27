using System.Security.Claims;
using Innoscripta.Pizza.Data.Domain;
using Newtonsoft.Json;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountLoginResponse: BaseResponse
    {
        [JsonIgnore]
        public ClaimsPrincipal ClaimPrincipal { get; set; }
        public UserEntity User { get; set; }
    }
}
