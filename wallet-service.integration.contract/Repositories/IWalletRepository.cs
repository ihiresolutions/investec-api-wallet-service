using System;
using System.Collections.Generic;
using System.Text;
using wallet_service.integration.contract.Models;

namespace wallet_service.integration.contract.Repositories
{
    public interface IWalletRepository
    {
        Wallet GetWalletByReference(string referenceNumber);
        Wallet AddWalletTransaction(Transaction transaction);
    }
}
