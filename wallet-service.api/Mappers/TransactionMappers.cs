namespace wallet_service.api.Mappers
{
    public static class TransactionMappers
    {
        public static integration.contract.Models.TransactionTrigger Map( this api.ViewModels.TransactionTrigger transactionTriggerDto)
        {
            switch(transactionTriggerDto)
            {
                case ViewModels.TransactionTrigger.Bank:
                    return integration.contract.Models.TransactionTrigger.Bank;
                case ViewModels.TransactionTrigger.Wallet:
                    return integration.contract.Models.TransactionTrigger.Wallet;
                case ViewModels.TransactionTrigger.None:
                default:
                    return integration.contract.Models.TransactionTrigger.None;
            }
        }
    }
}
