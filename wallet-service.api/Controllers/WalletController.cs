using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Newtonsoft.Json;
using System;
using wallet_service.api.ViewModels;
using wallet_service.integration.contract.Repositories;

namespace wallet_service.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        #region Constructors

        public WalletController(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        #endregion

        [HttpGet("{referenceNumber}")]
        public ActionResult<WalletDto> Get(string referenceNumber)
        {
            var wallet = _walletRepository.GetWalletByReference(referenceNumber);
            Console.WriteLine("Wallet SystemRefId: {0}", wallet.SystemRefId);
            return Ok(new WalletDto
            {
                ReferenceNumber = referenceNumber,
                Currency = "ZAR",
                Balance = 5000.00M
            });
        }

        #region Fields

        public readonly IWalletRepository _walletRepository;

        #endregion
    }
}
