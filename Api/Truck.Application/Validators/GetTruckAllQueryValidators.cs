using FluentValidation;
using Truck.Application.Querys;

namespace Truck.Application.Validators
{
    public class GetTruckAllQueryValidators : AbstractValidator<GetTruckAllQuery>
    {
        public GetTruckAllQueryValidators()
        {
            RuleFor(t => t.Count)
                .NotEmpty()
                .WithMessage("Inform the number of paths you truck to search!");

            RuleFor(t => t.Count)
                .NotEmpty()
                .WithMessage("Inform the page of paths you truck to search!");
        }
    }
}