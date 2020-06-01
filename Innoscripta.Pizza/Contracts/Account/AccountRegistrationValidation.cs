using FluentValidation;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountRegistrationValidation: AbstractValidator<AccountRegistrationRequest>
    {
        public AccountRegistrationValidation()
        {
            RuleFor(obj => obj.Password).NotEmpty();
            RuleFor(obj => obj.Phone).NotEmpty();
        }
    }
}