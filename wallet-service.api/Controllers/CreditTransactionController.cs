using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using wallet_service.api.Mappers;
using wallet_service.api.ViewModels;
using wallet_service.integration.contract.Models;
using wallet_service.integration.contract.Repositories;

namespace wallet_service.api.Controllers
{
    [Route("api/wallet/[controller]")]
    [ApiController]
    public class CreditTransactionController : ControllerBase
    {
        #region Constructors

        public CreditTransactionController(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        #endregion

        [HttpPost("{referenceNumber}")]
        public ActionResult<WalletDto> AddCreditTransaction(string referenceNumber, [FromBody] CreditTransactionDto transaction)
        {
            var wallet = _walletRepository.GetWalletByReference(referenceNumber);
            if (wallet == null)
            {
                return NotFound();
            }
            else
            {
                var transactionEntry = Transaction.New
                (
                    wallet, integration.contract.Models.TransactionType.Credit, transaction.Amount, transaction.Currency,
                    transaction.Trigger.Map(), transaction.TransactionDate
                );
                try
                {
                    var updatedWallet = _walletRepository.AddWalletTransaction(transactionEntry);
                    return Created("/api/something", new WalletDto 
                    {
                        ReferenceNumber = updatedWallet.ReferenceNumber,
                        Currency = "ZAR",
                        Balance = updatedWallet.Balance
                    });
                }
                catch(Exception exception)
                {
                    Console.WriteLine("Error adding credit transaction. ERROR [{0}]", exception.Message);
                    return StatusCode(500);
                }
            }
        }

        #region Fields

        public readonly IWalletRepository _walletRepository;

        #endregion
    }
}
