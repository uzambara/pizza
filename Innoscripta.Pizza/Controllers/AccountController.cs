using System;
using System.Threading.Tasks;
using Innoscripta.Pizza.Contracts.Account;
using Innoscripta.Pizza.Routing;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Innoscripta.Pizza.Controllers
{
    [Authorize]
    public class AccountController: BaseController
    {
        [HttpGet]
        [Route(ApiRoutes.Account.GetCurrentUser)]
        [AllowAnonymous]
        public async Task<GetCurrentUserResponse> GetCurrentUser()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Register)]
        [AllowAnonymous]
        public async Task<AccountRegisterResponse> Register(AccountRegisterRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Login)]
        [AllowAnonymous]
        public async Task<AccountLoginResponse> Login(AccountLoginRequest request)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Logout)]
        public async Task<AccountLogoutResponse> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new AccountLogoutResponse();
        }
    }
}