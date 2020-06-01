using FluentValidation;

namespace Innoscripta.Pizza.Contracts.Account
{
    public class AccountLoginValidation: AbstractValidator<AccountLoginRequest>
    {
        public AccountLoginValidation()
        {
            RuleFor(req => req.Phone).NotEmpty();
            RuleFor(req => req.Password).NotEmpty();
        }
    }
}
