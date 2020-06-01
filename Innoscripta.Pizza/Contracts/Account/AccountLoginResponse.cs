using System.Security.Claims;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;
using Newtonsoft.Json;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountLoginResponse: BaseResponse
    {
        public UserModel User { get; set; }
    }
}
