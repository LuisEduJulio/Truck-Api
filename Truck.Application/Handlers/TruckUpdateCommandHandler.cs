using AutoMapper;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.Commands;
using Truck.Application.Validators;
using Truck.Domain.Entities;
using Truck.Domain.Repositories;
using Truck.Infraestructure.Exceptions;

namespace Truck.Application.Handlers
{
    public class TruckUpdateCommandHandler : IRequestHandler<TruckUpdateCommand, TruckEntity>
    {
        private readonly ITruckRepository _truckRepository;
        private readonly IMapper _mapper;

        public TruckUpdateCommandHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<TruckEntity> Handle(TruckUpdateCommand request, CancellationToken cancellationToken)
        {
            var validation = await new TruckUpdateCommandValidators().ValidateAsync(request, cancellationToken);

            if (!validation.IsValid)
            {
                throw new CustomException(validation.Errors.First().ErrorMessage);
            }

            var truck = await _truckRepository.GetIdAsync(request.Id);

            if (truck is null)
            {
                throw new CustomException("Truck does not exist!");
            }

            truck.DateModel = request.DateModel ?? truck.DateModel;
            truck.DateFabric = request.DateFabric ?? truck.DateFabric;
            truck.DateUpdated = request.DateUpdated;
            truck.Chassis = request.Chassis ?? truck.Chassis;
            truck.EModelTruck = request.EModelTruck ?? truck.EModelTruck;
            truck.Color = request.Color ?? truck.Color;

            return await _truckRepository.UpdateAsync(truck);
        }
    }
}