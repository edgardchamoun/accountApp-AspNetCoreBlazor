using AccountApp.Core.Services;
using Microsoft.AspNetCore.Mvc;
using AccountApp.Shared.Models;
using System;
using System.Threading.Tasks;

namespace AccountApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        IAccountService accountService;
        public AccountController(IAccountService _accountService)
        {
            accountService = _accountService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAccounts()
        {
            try
            {
                var accounts = await accountService.GetAccounts();
                if (accounts == null)
                {
                    return NotFound();
                }

                return Ok(accounts);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAccount([FromBody] Account model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var accountId = await accountService.AddAccount(model);
                    if (accountId > 0)
                    {
                        return Ok(accountId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAccount(int? accountId)
        {
            int result = 0;

            if (accountId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await accountService.DeleteAccount(accountId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
        
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAccount(Account model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await accountService.UpdateAccount(model);

                    return Ok();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}
