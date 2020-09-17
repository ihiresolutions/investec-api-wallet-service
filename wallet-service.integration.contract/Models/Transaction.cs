using System;
using System.Collections.Generic;
using System.Text;
using wallet_service.integration.contract.Models.BaseModel;

namespace wallet_service.integration.contract.Models
{
    public class Transaction : AbstractModel
    {
        public virtual Wallet Wallet { get; set; }
        public long WalletId { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public TransactionTrigger TransactionTrigger { get; set; }
    }

    public enum TransactionType
    {
        None = 0,
        Debit, Credit
    }

    public enum TransactionTrigger
    {
        None = 0,
        Bank, Wallet
    }
}
