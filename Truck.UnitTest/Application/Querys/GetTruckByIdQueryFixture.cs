using AutoFixture;
using Truck.Application.Querys;

namespace Truck.UnitTest.Application.Querys
{
    public class GetTruckByIdQueryFixture
    {
        private readonly Fixture _fixture;

        public GetTruckByIdQueryFixture()
        {
            _fixture = new Fixture();
        }

        public GetTruckByIdQuery GetTruckById()
        {
            return _fixture.Create<GetTruckByIdQuery>();
        }
    }
}