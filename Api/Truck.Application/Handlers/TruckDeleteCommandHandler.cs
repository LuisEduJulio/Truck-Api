using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.Commands;
using Truck.Application.Validators;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Exceptions;

namespace Truck.Application.Handlers
{
    public class TruckDeleteCommandHandler : IRequestHandler<TruckDeleteCommand, Unit>
    {
        private readonly ITruckRepository _truckRepository;

        public TruckDeleteCommandHandler(ITruckRepository truckRepository)
        {
            _truckRepository = truckRepository;
        }

        public async Task<Unit> Handle(TruckDeleteCommand request, CancellationToken cancellationToken)
        {
            var validation = await new TruckDeleteCommandValidators().ValidateAsync(request, cancellationToken);

            if (!validation.IsValid)
            {
                throw new CustomException(validation.Errors.First().ErrorMessage);
            }

            var truck = await _truckRepository.GetIdAsync(request.Id);

            if (truck is null)
            {
                throw new CustomException("Truck does not exist!");
            }

            await _truckRepository.DeleteAsync(truck);

            return Unit.Value;
        }
    }
}