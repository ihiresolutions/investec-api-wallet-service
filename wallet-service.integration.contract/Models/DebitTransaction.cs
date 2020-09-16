using System;
using System.Collections.Generic;
using System.Text;

namespace wallet_service.integration.contract.Models
{
    public class DebitTransaction : Transaction
    {
        public string Recipient { get; set; }
    }
}
