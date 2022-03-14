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
        public async Task<IActionResult> GetByIdTruckAsync([FromQuery] int Id)
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

        [HttpGet("UpdateTruck")]
        public async Task<IActionResult> PutTruckAsync([FromBody] TruckUpdateCommand truckUpdateCommand)
        {
            var truck = await _mediator.Send(truckUpdateCommand);

            return Ok(truck);
        }

        [HttpGet("DeleteTruck")]
        public async Task<IActionResult> DeleteTruckAsync([FromBody] TruckDeleteCommand truckDeleteCommand)
        {
            var truck = await _mediator.Send(truckDeleteCommand);

            return Ok(truck);
        }
    }
}