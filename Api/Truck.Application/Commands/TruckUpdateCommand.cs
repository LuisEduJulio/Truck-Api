using MediatR;
using System;
using Truck.Domain.Entities;
using Truck.Domain.Enums;

namespace Truck.Application.Commands
{
    public class TruckUpdateCommand : IRequest<TruckEntity>
    {
        public TruckUpdateCommand()
        {
            DateUpdated = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime? DateFabric { get; set; }
        public DateTime? DateModel { get; set; }
        public string Color { get; set; }
        public string Chassis { get; set; }
        public EModelTruck? EModelTruck { get; set; }
    }
}