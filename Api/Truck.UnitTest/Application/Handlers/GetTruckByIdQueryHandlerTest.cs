using AutoMapper;
using Moq;
using Moq.AutoMock;
using System.Threading;
using System.Threading.Tasks;
using Truck.Application.Handlers;
using Truck.Application.Querys;
using Truck.Domain.Entities;
using Truck.Domain.Repositories;
using Truck.UnitTest.Application.Querys;
using Truck.UnitTest.Domain.Entities;
using Xunit;

namespace Truck.UnitTest.Application.Handlers
{
    public class GetTruckByIdQueryHandlerTest
    {
        private readonly AutoMocker _autoMocker;
        private readonly GetTruckByIdQueryHandler _getTruckByIdQueryHandler;

        private readonly GetTruckByIdQuery _getTruckByIdQuery;
        private readonly TruckEntity _truckEntity;

        public GetTruckByIdQueryHandlerTest()
        {
            _autoMocker = new AutoMocker();
            _getTruckByIdQueryHandler = _autoMocker.CreateInstance<GetTruckByIdQueryHandler>();

            _truckEntity = new TruckEntityFixture().CreateTruckEntityAddMock();
            _getTruckByIdQuery = new GetTruckByIdQueryFixture().GetTruckById();
        }

        [Fact]
        public async Task GetTruckByIdQueryHandlerTest_Create_ReturnSuccess()
        {
            //Arranje
            var truckRepository = new Mock<ITruckRepository>();
            var mapper = new Mock<IMapper>();

            _autoMocker.GetMock<ITruckRepository>()
               .Setup(preferencesRepo => preferencesRepo.GetIdAsync(_truckEntity.Id))
               .ReturnsAsync(_truckEntity);

            var truckCreateCommandHandler = new TruckCreateCommandHandler(truckRepository.Object, mapper.Object);

            // Act
            var result = _getTruckByIdQueryHandler.Handle(_getTruckByIdQuery, new CancellationToken());

            //Assert
            Assert.NotNull(result.Exception.Message);
        }
    }
}