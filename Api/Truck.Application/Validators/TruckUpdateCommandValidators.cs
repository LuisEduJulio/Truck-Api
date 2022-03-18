using FluentValidation;
using Truck.Application.Commands;

namespace Truck.Application.Validators
{
    public class TruckUpdateCommandValidators : AbstractValidator<TruckUpdateCommand>
    {
        public TruckUpdateCommandValidators()
        {
            RuleFor(t => t.Id)
                .NotEmpty()
                .WithMessage("Inform the truck id!");
        }
    }
}