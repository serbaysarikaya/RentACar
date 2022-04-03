using Entities.Concrete;
using FluentValidation;
using System;

namespace Bussiness.ValidationRules.FluentValidation
{
    public class CarDetailValidator : AbstractValidator<CarDetail>
    {
        public CarDetailValidator()
        {
            RuleFor(cd => cd.CarId).NotEmpty();
        }
    }
}
