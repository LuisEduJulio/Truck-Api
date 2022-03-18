using FluentValidation;
using Truck.Application.Commands;

namespace Truck.Application.Validators
{
    public class TruckDeleteCommandValidators : AbstractValidator<TruckDeleteCommand>
    {
        public TruckDeleteCommandValidators()
        {
            RuleFor(t => t.Id)
                .NotEmpty()
                .WithMessage("Inform the truck id!");
        }
    }
}