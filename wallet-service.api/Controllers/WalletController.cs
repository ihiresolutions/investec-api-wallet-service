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
            if (wallet == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(new WalletDto
                {
                    ReferenceNumber = wallet.ReferenceNumber,
                    Currency = "ZAR",
                    Balance = wallet.Balance
                });
            }
        }

        #region Fields

        public readonly IWalletRepository _walletRepository;

        #endregion
    }
}
