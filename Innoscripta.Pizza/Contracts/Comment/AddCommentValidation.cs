using FluentValidation;

namespace Innoscripta.Pizza.Contracts.Comment
{
    public class AddCommentValidation: AbstractValidator<AddCommentRequest>
    {
        public AddCommentValidation()
        {
            RuleFor(obj => obj.Name).NotEmpty();
            RuleFor(obj => obj.Phone).NotEmpty();
            RuleFor(obj => obj.Text).NotEmpty();
        }
    }
}