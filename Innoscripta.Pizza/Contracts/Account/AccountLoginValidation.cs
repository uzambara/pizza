using FluentValidation;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountLoginValidation: AbstractValidator<AccountLoginRequest>
    {
        public AccountLoginValidation()
        {
            RuleFor(req => req.Login).NotEmpty();
            RuleFor(req => req.Password).NotEmpty();
        }
    }
}
