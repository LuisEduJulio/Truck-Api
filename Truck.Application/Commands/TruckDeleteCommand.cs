using MediatR;

namespace Truck.Application.Commands
{
    public class TruckDeleteCommand : IRequest<Unit>
    {
        public TruckDeleteCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}