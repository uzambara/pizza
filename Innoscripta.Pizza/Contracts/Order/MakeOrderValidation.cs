using FluentValidation;

namespace Innoscripta.Pizza.Contracts.Order
{
    public class MakeOrderValidation: AbstractValidator<MakeOrderRequest>
    {
        public MakeOrderValidation()
        {
            RuleFor(obj => obj.Address).NotEmpty();
            RuleFor(obj => obj.Phone).NotEmpty();
            RuleFor(obj => obj.Name).NotEmpty();
        }
    }
}