using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wallet_service.api.ViewModels
{
    public class TransactionDto
    {
        public string WalletReferenceNumber { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Currency { get; set; }
        public TransactionTrigger Trigger { get; set; }
    }

    public enum TransactionType
    {
        None = 0,
        Credit = 1,
        Debit = 2
    }

    public enum TransactionTrigger
    {
        None = 0,
        Bank = 1,
        Wallet = 2
    }
}
