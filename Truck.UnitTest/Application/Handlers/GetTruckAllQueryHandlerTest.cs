using AutoMapper;
using Moq;
using Moq.AutoMock;
using System.Collections.Generic;
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
    public class GetTruckAllQueryHandlerTest
    {
        private readonly AutoMocker _autoMocker;
        private readonly GetTruckAllQueryHandler _getTruckAllQueryHandler;

        private readonly GetTruckAllQuery _getTruckAllQuery;
        private readonly TruckEntity _truckEntity;

        public GetTruckAllQueryHandlerTest()
        {
            _autoMocker = new AutoMocker();
            _getTruckAllQueryHandler = _autoMocker.CreateInstance<GetTruckAllQueryHandler>();

            _truckEntity = new TruckEntityFixture().CreateTruckEntityAddMock();
            _getTruckAllQuery = new GetTruckAllQueryFixture().GetTruckAll();
        }

        [Fact]
        public async Task GetTruckAllQueryHandlerTest_Create_ReturnSuccess()
        {
            //Arranje
            var truckRepository = new Mock<ITruckRepository>();
            var mapper = new Mock<IMapper>();

            _autoMocker.GetMock<ITruckRepository>()
               .Setup(preferencesRepo => preferencesRepo.GetAllAsync(It.IsAny<int>(), It.IsAny<int>()))
               .ReturnsAsync(new List<TruckEntity>());

            var truckCreateCommandHandler = new TruckCreateCommandHandler(truckRepository.Object, mapper.Object);

            // Act
            var result = _getTruckAllQueryHandler.Handle(_getTruckAllQuery, new CancellationToken());

            //Assert
            Assert.NotNull(result.Exception.Message);
        }
    }
}