using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Innoscripta.Pizza.Contracts;
using Innoscripta.Pizza.Contracts.Account;
using Innoscripta.Pizza.Data.Domain;
using Innoscripta.Pizza.Models;
using Innoscripta.Pizza.Routing;
using Innoscripta.Pizza.Services.Implementations;
using Innoscripta.Pizza.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Innoscripta.Pizza.Controllers
{
    [Authorize]
    public class AccountController: BaseController
    {
        private readonly IUserService _userService;
        private readonly IHashService _hashService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService, IMapper mapper, IHashService hashService)
        {
            _userService = userService;
            _mapper = mapper;
            _hashService = hashService;
        }

        [HttpGet]
        [Route(ApiRoutes.Account.GetCurrentUser)]
        [AllowAnonymous]
        public async Task<GetCurrentUserResponse> GetCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            return new GetCurrentUserResponse()
            {
                User = _mapper.Map<UserModel>(user)
            };
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Register)]
        [AllowAnonymous]
        public async Task<AccountRegistrationResponse> Register(AccountRegistrationRequest request)
        {
            var inputPassword = request.Password;
            request.Password = _hashService.HashPassword(request.Password);
            var result = await _userService.RegisterUserAsync(request);
            await Login(new AccountLoginRequest()
            {
                Phone = request.Phone,
                Password = inputPassword
            });
            return result;
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Login)]
        [AllowAnonymous]
        public async Task<AccountLoginResponse> Login(AccountLoginRequest request)
        {
            var user = await _userService.GetUserByPhoneAsync(request.Phone);

            if (user == null)
            {
                return new AccountLoginResponse()
                {
                    Code = ResponseCode.UserNotFound
                };
            }

            if (!_hashService.VerifyPassword(user.Password, request.Password))
            {
                return new AccountLoginResponse()
                {
                    Code = ResponseCode.InnerError
                };
            }

            var claimsPrincipal = GetClaimsPrincipal(user);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);

            return new AccountLoginResponse()
            {
                User = _mapper.Map<UserModel>(user)
            };
        }

        [HttpPost]
        [Route(ApiRoutes.Account.Logout)]
        public async Task<AccountLogoutResponse> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return new AccountLogoutResponse();
        }

        private static ClaimsPrincipal GetClaimsPrincipal(UserEntity user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Phone)
            };

            var id = new ClaimsIdentity(claims, "ApplicationCookie");
            return new ClaimsPrincipal(new [] {id});
        }
    }
}
