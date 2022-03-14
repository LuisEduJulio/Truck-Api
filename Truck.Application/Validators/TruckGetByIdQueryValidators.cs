using FluentValidation;
using Truck.Application.Querys;

namespace Truck.Application.Validators
{
    public class TruckGetByIdQueryValidators : AbstractValidator<GetTruckByIdQuery>
    {
        public TruckGetByIdQueryValidators()
        {
            RuleFor(t => t.Id)
                .NotEmpty()
                .WithMessage("Inform the truck id!");
        }
    }
}