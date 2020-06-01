﻿ using Innoscripta.Pizza.Models;

  namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountRegistrationResponse: BaseResponse
    {
        public UserModel User { get; set; }
    }
}