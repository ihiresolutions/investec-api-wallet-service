using System;
using System.Collections.Generic;
using System.Text;

namespace wallet_service.integration.contract.Models.BaseModel
{
    public abstract class AbstractModel
    {
        #region Properties

        public long Id { get; set; }
        public Guid SystemRefId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }

        #endregion
    }
}
