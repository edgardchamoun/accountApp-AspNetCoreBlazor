using AccountApp.Core.Services;
using Microsoft.AspNetCore.Mvc;
using AccountApp.Shared.Models;
using System;
using System.Threading.Tasks;

namespace AccountApp.API.Controllers
{
    [Route("api/Account/{accountId}/[controller]")]
    [ApiController]
    public class TransactionController : Controller
    {
        ITransactionService transactionService;
        public TransactionController(ITransactionService _transactionService)
        {
            transactionService = _transactionService;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetTransactions()
        {
            try
            {
                int? accountId = (RouteData.Values["accountId"] != null ? Convert.ToInt32(RouteData.Values["accountId"].ToString()) : null);
                if (accountId == null)
                    return NotFound();
                var transactions = await transactionService.GetTransactionsByAccountId(accountId);
                if (transactions == null)
                {
                    return NotFound();
                }

                return Ok(transactions);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddTransaction([FromBody] Transaction model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var transactionId = await transactionService.AddTransaction(model);
                    if (transactionId > 0)
                    {
                        return Ok(transactionId);
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
        public async Task<IActionResult> DeleteTransaction(int? transactionId)
        {
            int result = 0;

            if (transactionId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await transactionService.DeleteTransaction(transactionId);
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
        public async Task<IActionResult> UpdateTransaction(Transaction model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await transactionService.UpdateTransaction(model);

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
