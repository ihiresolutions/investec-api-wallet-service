using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using wallet_service.api.ViewModels;

namespace wallet_service.api.Controllers
{
    [Route("api/wallet/[controller]")]
    [ApiController]
    public class DebitTransactionController : ControllerBase
    {
        [HttpPost("{referenceNumber}")]
        public ActionResult<WalletDto> AddDebitTransaction(string referenceNumber, [FromBody] DebitTransactionDto transaction)
        {
            Console.WriteLine("Debit Transaction properties: {0}", JsonConvert.SerializeObject(transaction));
            return Created("api/something", new WalletDto
            {
                ReferenceNumber = referenceNumber,
                Currency = "ZAR",
                Balance = 5000.00M
            });
        }
    }
}
