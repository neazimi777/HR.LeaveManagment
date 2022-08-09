using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagment.Application.DTos.LeaveType.Validators
{
    public  class CreateLeaveTypeDtoValidator:AbstractValidator<CreateLeaveTypeDto>
    {
       public  CreateLeaveTypeDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("{propertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{propertyName} is not exceed 50 charecter");

            RuleFor(x => x.DefaultDays)
                .NotEmpty().WithMessage("{propertyName} is required.")
                .GreaterThan(0).WithMessage("{propertyName} must be at least 1 ")
                .LessThan(100).WithMessage("{propertyName} must be less than 100 ");
        }
    }
}
