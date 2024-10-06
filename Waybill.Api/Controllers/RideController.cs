using Microsoft.AspNetCore.Mvc;
using Waybill.Application.RideArea;
using WayBill.Core.ViewModels;

namespace Waybill.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly ILogger<RideController> _logger;
        private readonly IRideService _rideService;

        // GET: api/<RideController>
        public RideController(ILogger<RideController> logger, IRideService rideService)
        {
            _logger = logger;
            _rideService = rideService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RideVm>>> Get()
        {
            var rides = await _rideService.GetRidesAsync();
            return Ok(rides);
        }

        // GET api/<RideController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RideController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RideController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RideController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}