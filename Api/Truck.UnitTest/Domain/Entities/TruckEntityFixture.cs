using AutoFixture;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Truck.Application.Mappers;
using Truck.Domain.Entities;
using Truck.UnitTest.Application.Commands;

namespace Truck.UnitTest.Domain.Entities
{
    public class TruckEntityFixture
    {
        private readonly Fixture _fixture;
        private readonly IMapper _mapper;
        private readonly TruckCreateCommandFixture _truckCreateCommandFixture;
        private readonly TruckUpdateCommandFixture _truckUpdateCommandFixture;

        public TruckEntityFixture()
        {
            _fixture = new Fixture();

            _truckCreateCommandFixture = new TruckCreateCommandFixture();
            _truckUpdateCommandFixture = new TruckUpdateCommandFixture();

            var _serviceCollection = new ServiceCollection();

            _serviceCollection.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<CommandsToEntityMapperProfile>();
            });

            var provider = _serviceCollection.BuildServiceProvider();

            _mapper = provider.GetService<IMapper>();
        }

        public TruckEntity TruckEntityMock()
        {
            var result = _fixture.Create<TruckEntity>();

            return result;
        }

        public TruckEntity CreateTruckEntityAddMock()
        {
            return _mapper.Map<TruckEntity>(_truckCreateCommandFixture.CreateTruck());
        }

        public TruckEntity CreateTruckEntityUpdateMock()
        {
            return _mapper.Map<TruckEntity>(_truckUpdateCommandFixture.UpdateTruck());
        }
    }
}