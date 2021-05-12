using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(cu => cu.UserId).NotEmpty();
            RuleFor(cu => cu.CompanyName).MaximumLength(35);
            RuleFor(cu => cu.CompanyName).NotEmpty();

        }
    }
}
