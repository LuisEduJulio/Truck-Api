using MediatR;
using System.Collections.Generic;
using Truck.Domain.Entities;

namespace Truck.Application.Querys
{
    public class GetTruckAllQuery : IRequest<List<TruckEntity>>
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