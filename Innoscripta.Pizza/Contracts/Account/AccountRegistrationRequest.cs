﻿namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountRegistrationRequest
    {
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}