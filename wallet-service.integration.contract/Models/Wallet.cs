using System.Collections.Generic;
using System.Linq;
using wallet_service.integration.contract.Models.BaseModel;

namespace wallet_service.integration.contract.Models
{
    public class Wallet : AbstractModel
    {
        public string ReferenceNumber { get; set; }
        public decimal Balance 
        {
            get 
            {
                return !Transactions.Any()
                    ? 0.00M
                    : (Transactions.Where(type => type.Type == Transaction.TransactionType.Credit).Sum(x => x.Amount) -
                    Transactions.Where(type => type.Type == Transaction.TransactionType.Debit).Sum(x => x.Amount));
            }
        }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
