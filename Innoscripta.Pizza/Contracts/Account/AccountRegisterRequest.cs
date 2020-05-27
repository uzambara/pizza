﻿namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountRegisterRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}