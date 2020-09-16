using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace wallet_service.api.ViewModels
{
    public class WalletDto
    {
        public string ReferenceNumber { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
    }
}
