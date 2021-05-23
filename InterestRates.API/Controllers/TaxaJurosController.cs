using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InterestRates.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        [HttpGet("/taxaJuros")]
        [ProducesResponseType(typeof(decimal), StatusCodes.Status200OK)]
        public Task<decimal> Get() =>
            Task.FromResult(0.01m);
    }
}