using FluentValidation;
using System.Drawing;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(co => co.Name).NotEmpty();
        }
    }
}
