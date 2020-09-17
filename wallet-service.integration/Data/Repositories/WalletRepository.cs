using Microsoft.EntityFrameworkCore;
using System.Linq;
using wallet_service.integration.contract.Models;
using wallet_service.integration.contract.Repositories;
using wallet_service.integration.Data.Contexts;

namespace wallet_service.integration.Data.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        #region Constructors

        public WalletRepository(WalletsContext context) 
            => _context = context;

        #endregion

        #region IWalletRepository Implementation
        public Wallet AddWalletTransaction(Transaction transaction)
            => _context.Transactions.Add(transaction).Entity.Wallet;

        public Wallet GetWalletByReference(string referenceNumber)
            => _context.Wallets
            .Include(c => c.Transactions)
            .SingleOrDefault(x => x.ReferenceNumber.Equals(referenceNumber));

        #endregion

        #region Fields

        private readonly WalletsContext _context;

        #endregion
    }
}
