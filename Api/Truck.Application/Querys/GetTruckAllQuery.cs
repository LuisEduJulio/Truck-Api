using MediatR;
using Truck.Application.dto;

namespace Truck.Application.Querys
{
    public class GetTruckAllQuery : IRequest<TruckPagination>
    {
        public GetTruckAllQuery(int page, int count)
        {
            Page = page;
            Count = count;
        }

        public int Page { get; set; }
        public int Count { get; set; }
    }
}