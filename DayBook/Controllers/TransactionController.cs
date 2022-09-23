using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayBook.Models;
using DayBook.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DayBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        public TransactionService _service;

        public TransactionController(TransactionService transactionService)
        {
            _service = transactionService;
        }

        [HttpPost]
        public IActionResult CreateTransaction([FromBody] TransactionDto transactionDto)
        {
            try
            {
                _service.CreateTransaction(transactionDto);

                return Ok("Transaction Added");
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
                var transactions = _service.GetTransactions();
                return Ok(transactions);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTransactionById(int id)
        {
            try
            {
                var transaction = _service.GetTransactionById(id);
                return Ok(transaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTransaction(int id, [FromBody] TransactionDto transactionDto)
        {
            try
            {
                var transaction = _service.GetTransactionById(id);
                if (transaction == null)
                {
                    return NotFound();
                }
                _service.UpdateTransaction(id, transactionDto);

                return Ok("Item updated");

            } catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTransaction(int id)
        {
            try
            {
                var transaction = _service.GetTransactionById(id);
                if (transaction == null)
                {
                    return NotFound();
                }

                _service.DeleteTransactionById(id);

                return Ok("Item deleted successfully");

            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
