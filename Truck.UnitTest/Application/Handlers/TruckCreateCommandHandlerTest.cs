using AutoMapper;
using Moq;
using Moq.AutoMock;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.Commands;
using Truck.Application.Handlers;
using Truck.Application.Validators;
using Truck.Domain.Entities;
using Truck.Domain.Repositories;
using Truck.UnitTest.Application.Commands;
using Truck.UnitTest.Domain.Entities;
using Xunit;

namespace Truck.UnitTest.Application.Handlers
{
    public class TruckCreateCommandHandlerTest
    {
        private readonly AutoMocker _autoMocker;
        private readonly TruckCreateCommandHandler _truckCreateCommandHandler;

        private readonly TruckCreateCommand _truckCreateCommand;
        private readonly TruckEntity _truckEntity;

        public TruckCreateCommandHandlerTest()
        {
            _autoMocker = new AutoMocker();
            _truckCreateCommandHandler = _autoMocker.CreateInstance<TruckCreateCommandHandler>();

            _truckEntity = new TruckEntityFixture().CreateTruckEntityAddMock();
            _truckCreateCommand = new TruckCreateCommandFixture().CreateTruck();
        }

        [Fact]
        public async Task TruckCreateCommandHandler_Create_ReturnSuccess()
        {
            //Arranje
            var truckRepository = new Mock<ITruckRepository>();
            var mapper = new Mock<IMapper>();

            _autoMocker.GetMock<ITruckRepository>()
               .Setup(preferencesRepo => preferencesRepo.AddAsync(_truckEntity))
               .ReturnsAsync(_truckEntity);

            var truckCreateCommandHandler = new TruckCreateCommandHandler(truckRepository.Object, mapper.Object);

            // Act
            var result = _truckCreateCommandHandler.Handle(_truckCreateCommand, new CancellationToken());

            //Assert
            Assert.True(result.Result == null);
            Assert.Null(result.Result);
        }

        [Fact]
        public async Task TruckCreateCommandHandler_Validations_ReturnSuccess()
        {
            //Arranje
            var validator = new TruckCreateCommandValidators();

            // Act
            var result = validator.Validate(_truckCreateCommand);

            //Assert
            Assert.Equal(null, result.Errors.FirstOrDefault()?.ErrorMessage);
        }
    }
}