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
    public class CreditTransactionController : ControllerBase
    {
        #region Constructors
        #endregion
        [HttpPost("{referenceNumber}")]
        public ActionResult<WalletDto> AddCreditTransaction(string referenceNumber, [FromBody] CreditTransactionDto transaction)
        {
            Console.WriteLine("Credit Transaction properties: {0}", JsonConvert.SerializeObject(transaction));
            Console.WriteLine("Param Reference Number: {0}", referenceNumber);
            return Created("api/something", new WalletDto
            {
                ReferenceNumber = referenceNumber,
                Currency = "ZAR",
                Balance = 5000.00M
            });
        }
    }
}
