using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.Querys;
using Truck.Application.Validators;
using Truck.Domain.Entities;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Exceptions;

namespace Truck.Application.Handlers
{
    public class GetTruckByIdQueryHandler : IRequestHandler<GetTruckByIdQuery, TruckEntity>
    {
        private readonly ITruckRepository _truckRepository;
        private readonly IMapper _mapper;

        public GetTruckByIdQueryHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<TruckEntity> Handle(GetTruckByIdQuery request, CancellationToken cancellationToken)
        {
            var validation = await new TruckGetByIdQueryValidators().ValidateAsync(request, cancellationToken);

            if (!validation.IsValid)
            {
                throw new CustomException(validation.Errors.First().ErrorMessage);
            }

            var truck = await _truckRepository.GetIdAsync(request.Id);

            if (truck is null)
            {
                throw new CustomException("System does not have a registered truck");
            }

            return truck;
        }
    }
}