using System.Collections.Generic;
using Truck.Domain.Entities;

namespace Truck.Application.dto
{
    public class TruckPagination
    {
        public TruckPagination()
        {
            TruckEntities = new List<TruckEntity>();
        }
        public List<TruckEntity> TruckEntities { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Total { get; set; }
    }
}
