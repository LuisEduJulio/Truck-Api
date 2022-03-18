using AutoFixture;
using Truck.Application.Commands;

namespace Truck.UnitTest.Application.Commands
{
    public class TruckUpdateCommandFixture
    {
        private readonly Fixture _fixture;

        public TruckUpdateCommandFixture()
        {
            _fixture = new Fixture();
        }

        public TruckUpdateCommand UpdateTruck()
        {
            return _fixture.Create<TruckUpdateCommand>();
        }
    }
}