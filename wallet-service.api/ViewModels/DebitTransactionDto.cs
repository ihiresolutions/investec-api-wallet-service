using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wallet_service.api.ViewModels
{
    public class DebitTransactionDto : TransactionDto
    {
        public string Recipient { get; set; }
    }
}
