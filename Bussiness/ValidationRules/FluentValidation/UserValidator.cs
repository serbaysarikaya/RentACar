using Entities.Concrete;
using FluentValidation;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {

            RuleFor(u => u.CreateDate).NotEmpty();
            RuleFor(u => u.Status).NotNull();

        }

    }
}
