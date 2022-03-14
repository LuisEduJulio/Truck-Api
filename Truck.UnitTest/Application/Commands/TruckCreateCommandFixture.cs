using AutoFixture;
using Truck.Application.Commands;

namespace Truck.UnitTest.Application.Commands
{
    public class TruckCreateCommandFixture
    {
        private readonly Fixture _fixture;

        public TruckCreateCommandFixture()
        {
            _fixture = new Fixture();
        }

        public TruckCreateCommand CreateTruck()
        {
            return _fixture.Create<TruckCreateCommand>();
        }
    }
}