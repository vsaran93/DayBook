using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayBook.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DayBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateTransaction([FromBody] Transaction transaction)
        {
            try
            {
                return Ok("Transaction");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("all")]
        public IActionResult GetTransactions()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTransactionById()
        {
            try
            {
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTransaction(int id)
        {
            try
            {
                if (id == null)
                {
                    return BadRequest("Id is missing");
                }
                return Ok();

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
