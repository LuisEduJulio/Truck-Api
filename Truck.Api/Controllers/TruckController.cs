using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Truck.Application.Commands;
using Truck.Application.Querys;

namespace Truck.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TruckController : ControllerBase
    {
        private readonly ILogger<TruckController> _loggerController;
        private readonly ILogger<Mediator> _loggerMediator;
        private readonly IMediator _mediator;

        public TruckController(ILogger<TruckController> loggerController, ILogger<Mediator> loggerMediator, IMediator mediator)
        {
            _loggerController = loggerController;
            _loggerMediator = loggerMediator;
            _mediator = mediator;
        }

        [HttpPost("CreateTruck")]
        public async Task<IActionResult> PostCreateTruckAsync([FromBody] TruckCreateCommand truckCreateCommand)
        {
            var truck = await _mediator.Send(truckCreateCommand);

            return Ok(truck);
        }

        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetByIdTruckAsync(int Id)
        {
            var truck = await _mediator.Send(new GetTruckByIdQuery(Id));

            return Ok(truck);
        }

        [HttpGet("GetAll/{page}/{count}")]
        public async Task<IActionResult> GetAllTruckAsync(int Page, int Count)
        {
            var truck = await _mediator.Send(new GetTruckAllQuery(Page, Count));

            return Ok(truck);
        }

        [HttpPut("UpdateTruck")]
        public async Task<IActionResult> PutTruckAsync(TruckUpdateCommand truckUpdateCommand)
        {
            var truck = await _mediator.Send(new TruckUpdateCommand() 
            { 
                Chassis = truckUpdateCommand.Chassis,
                Color = truckUpdateCommand.Color,
                DateFabric = truckUpdateCommand.DateFabric,
                DateModel = truckUpdateCommand.DateModel,
                EModelTruck = truckUpdateCommand.EModelTruck,
                Id = truckUpdateCommand.Id
            });

            return Ok(truck);
        }

        [HttpDelete("DeleteTruck/{Id}")]
        public async Task<IActionResult> DeleteTruckAsync(int Id)
        {
            var truck = await _mediator.Send(new TruckDeleteCommand(Id));

            return Ok(truck);
        }
    }
}