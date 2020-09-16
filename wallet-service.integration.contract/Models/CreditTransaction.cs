using System;
using System.Collections.Generic;
using System.Text;

namespace wallet_service.integration.contract.Models
{
    public class CreditTransaction : Transaction
    {
        public string Source { get; set; }
    }
}
