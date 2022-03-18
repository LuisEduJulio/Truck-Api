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
    public class TruckUpdateCommandHandlerTest
    {
        private readonly AutoMocker _autoMocker;
        private readonly TruckUpdateCommandHandler _truckupdateCommandHandler;

        private readonly TruckUpdateCommand _truckUpdateCommand;
        private readonly TruckEntity _truckEntity;

        public TruckUpdateCommandHandlerTest()
        {
            _autoMocker = new AutoMocker();
            _truckupdateCommandHandler = _autoMocker.CreateInstance<TruckUpdateCommandHandler>();

            _truckEntity = new TruckEntityFixture().CreateTruckEntityAddMock();
            _truckUpdateCommand = new TruckUpdateCommandFixture().UpdateTruck();
        }

        [Fact]
        public async Task TruckUpdateCommandHandler_Update_ReturnSuccess()
        {
            //Arranje
            var truckRepository = new Mock<ITruckRepository>();
            var mapper = new Mock<IMapper>();

            _autoMocker.GetMock<ITruckRepository>()
               .Setup(preferencesRepo => preferencesRepo.UpdateAsync(_truckEntity))
               .ReturnsAsync(_truckEntity);

            var truckCreateCommandHandler = new TruckUpdateCommandHandler(truckRepository.Object, mapper.Object);

            // Act
            var result = _truckupdateCommandHandler.Handle(_truckUpdateCommand, new CancellationToken());

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task TruckUpdateCommandHandler_Validations_ReturnSuccess()
        {
            //Arranje
            var validator = new TruckUpdateCommandValidators();

            // Act
            var result = validator.Validate(_truckUpdateCommand);

            //Assert
            Assert.Equal(null, result.Errors.FirstOrDefault()?.ErrorMessage);
        }
    }
}