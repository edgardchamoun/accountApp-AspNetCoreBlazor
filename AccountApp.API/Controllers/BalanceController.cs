using AccountApp.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AccountApp.API.Controllers
{
    [Route("api/Account/{accountId}/[controller]")]
    [ApiController]
    public class BalanceController : Controller
    {
        IBalanceService balanceService;
        public BalanceController(IBalanceService _balanceService)
        {
            balanceService = _balanceService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetBalances()
        {
            try
            {
                int? accountId = (RouteData.Values["accountId"] != null ? Convert.ToInt32(RouteData.Values["accountId"].ToString()) : null);
                if (accountId == null)
                    return NotFound();
                var balances = await balanceService.GetBalancesByAccountId(accountId);
                if (balances == null)
                {
                    return NotFound();
                }

                return Ok(balances);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
