using Microsoft.AspNetCore.Mvc;

namespace SaveMoney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        [HttpGet("balance")]
        public decimal Balance()
        {
            return 87.45M;
        }
    }
}
