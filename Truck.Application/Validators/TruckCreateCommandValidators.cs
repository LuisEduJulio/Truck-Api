using FluentValidation;
using Truck.Application.Commands;

namespace Truck.Application.Validators
{
    public class TruckCreateCommandValidators : AbstractValidator<TruckCreateCommand>
    {
        public TruckCreateCommandValidators()
        {
            RuleFor(t => t.Chassis)
                .NotEmpty()
                .WithMessage("Inform the chassis of the truck!");

            RuleFor(t => t.Color)
                .NotEmpty()
                .WithMessage("Inform the color of the truck!");

            RuleFor(t => t.DateFabric)
                .NotEmpty()
                .WithMessage("Inform the date of manufacture of the truck!");

            RuleFor(t => t.DateModel)
                .NotEmpty()
                .WithMessage("Inform the date of truck model!");

            RuleFor(t => t.DateModel)
               .NotEmpty()
               .WithMessage("Inform the truck model, FM or FH!");
        }
    }
}