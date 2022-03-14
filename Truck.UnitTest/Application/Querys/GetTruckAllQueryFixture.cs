using AutoFixture;
using Truck.Application.Querys;

namespace Truck.UnitTest.Application.Querys
{
    public class GetTruckAllQueryFixture
    {
        private readonly Fixture _fixture;

        public GetTruckAllQueryFixture()
        {
            _fixture = new Fixture();
        }

        public GetTruckAllQuery GetTruckAll()
        {
            return _fixture.Create<GetTruckAllQuery>();
        }
    }
}