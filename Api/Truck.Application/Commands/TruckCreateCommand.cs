using MediatR;
using System;
using Truck.Domain.Entities;

namespace Truck.Application.Commands
{
    public class TruckCreateCommand : IRequest<TruckEntity>
    {
        public TruckCreateCommand()
        {
            DateCreation = DateTime.Now;
        }

        public DateTime DateCreation { get; set; }
        public DateTime DateFabric { get; set; }
        public DateTime DateModel { get; set; }
        public string Color { get; set; }
        public string Chassis { get; set; }
        public int EModelTruck { get; set; }
    }
}