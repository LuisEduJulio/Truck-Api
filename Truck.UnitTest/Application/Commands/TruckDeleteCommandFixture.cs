using AutoFixture;
using Truck.Application.Commands;

namespace Truck.UnitTest.Application.Commands
{
    public class TruckDeleteCommandFixture
    {
        private readonly Fixture _fixture;

        public TruckDeleteCommandFixture()
        {
            _fixture = new Fixture();
        }

        public TruckDeleteCommand DeleteTruck()
        {
            return _fixture.Create<TruckDeleteCommand>();
        }
    }
}