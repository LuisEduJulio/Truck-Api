using System;
using Truck.Domain.Enums;

namespace Truck.Domain.Entities
{
    public class TruckEntity : BaseEntity
    {
        public DateTime DateFabric { get; set; }
        public DateTime DateModel { get; set; }
        public string Color { get; set; }
        public string Chassis { get; set; }
        public EModelTruck EModelTruck { get; set; }
    }
}