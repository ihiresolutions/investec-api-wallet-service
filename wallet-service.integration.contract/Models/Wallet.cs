using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using wallet_service.integration.contract.Models.BaseModel;

namespace wallet_service.integration.contract.Models
{
    public class Wallet : AbstractModel
    {
        public Wallet()
        {
            Transactions = new Collection<Transaction>();
        }

        public string ReferenceNumber { get; set; }
        public decimal Balance 
        {
            get 
            {
                return !Transactions.Any()
                    ? 0.00M
                    : (Transactions.Where(type => type.TransactionType == TransactionType.Credit).Sum(x => x.Amount) -
                    Transactions.Where(type => type.TransactionType == TransactionType.Debit).Sum(x => x.Amount));
            }
        }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
