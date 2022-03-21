using MediatR;
using Truck.Domain.Entities;

namespace Truck.Application.Querys
{
    public class GetTruckByIdQuery : IRequest<TruckEntity>
    {
        public GetTruckByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}