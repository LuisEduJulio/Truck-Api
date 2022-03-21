using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.dto;
using Truck.Application.Querys;
using Truck.Application.Validators;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Exceptions;

namespace Truck.Application.Handlers
{
    public class GetTruckAllQueryHandler : IRequestHandler<GetTruckAllQuery, TruckPagination>
    {
        private readonly ITruckRepository _truckRepository;

        public GetTruckAllQueryHandler(ITruckRepository truckRepository)
        {
            _truckRepository = truckRepository;
        }

        public async Task<TruckPagination> Handle(GetTruckAllQuery request, CancellationToken cancellationToken)
        {
            var validation = await new GetTruckAllQueryValidators().ValidateAsync(request, cancellationToken);

            if (!validation.IsValid)
            {
                throw new CustomException(validation.Errors.First().ErrorMessage);
            }

            var trucks = await _truckRepository.GetAllAsync(request.Page, request.Count);

            if (!trucks.Any())
            {
                throw new CustomException("System does not have a registered truck");
            }

            var count = await _truckRepository.GetAllCountAsync();

            var truckPagination = new TruckPagination()
            {
                Count = request.Count,
                Page = request.Page,
                Total = count,
                TruckEntities = trucks
            };

            return truckPagination;
        }
    }
}