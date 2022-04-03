using Entities.Concrete;
using FluentValidation;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class UserDetailValidator : AbstractValidator<UserDetail>
    {

        public UserDetailValidator()
        {
            RuleFor(ud => ud.UserId).NotEmpty();
            RuleFor(Ud => Ud.Firstname).NotEmpty();
            RuleFor(Ud => Ud.Firstname).MinimumLength(2);
            RuleFor(Ud => Ud.Firstname).MaximumLength(50);
            RuleFor(Ud => Ud.Lastname).MinimumLength(1);
            RuleFor(Ud => Ud.Lastname).MaximumLength(50);
            RuleFor(ud => ud.BirthDate).NotEmpty();
            RuleFor(ud => ud.Email).EmailAddress();
            RuleFor(ud => ud.Phone).Empty();

        }


    }
}
