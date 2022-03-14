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
    public class TruckDeleteCommandHandlerTest
    {
        private readonly AutoMocker _autoMocker;
        private readonly TruckDeleteCommandHandler _truckDeleteCommandHandler;

        private readonly TruckDeleteCommand _truckDeleteCommand;
        private readonly TruckEntity _truckEntity;

        public TruckDeleteCommandHandlerTest()
        {
            _autoMocker = new AutoMocker();
            _truckDeleteCommandHandler = _autoMocker.CreateInstance<TruckDeleteCommandHandler>();

            _truckEntity = new TruckEntityFixture().CreateTruckEntityAddMock();
            _truckDeleteCommand = new TruckDeleteCommandFixture().DeleteTruck();
        }

        [Fact]
        public async Task TruckDeleteCommandHandler_Delete_ReturnSuccess()
        {
            //Arranje
            var truckRepository = new Mock<ITruckRepository>();

            _autoMocker.GetMock<ITruckRepository>()
               .Setup(preferencesRepo => preferencesRepo.DeleteAsync(_truckEntity));

            var truckDeleteCommandHandler = new TruckDeleteCommandHandler(truckRepository.Object);

            // Act
            var result = _truckDeleteCommandHandler.Handle(_truckDeleteCommand, new CancellationToken());

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task TruckDeleteCommandHandler_Validations_ReturnSuccess()
        {
            //Arranje
            var validator = new TruckDeleteCommandValidators();

            // Act
            var result = validator.Validate(_truckDeleteCommand);

            //Assert
            Assert.Equal(null, result.Errors.FirstOrDefault()?.ErrorMessage);
        }
    }
}