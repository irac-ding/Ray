﻿using Ray.DistributedTx.Abstractions;

namespace Transfer.IGrains.TransactionUnits
{
    public class TransferInput
    {
        public long FromId { get; set; }
        public long ToId { get; set; }
        public decimal Amount { get; set; }
    }
    public interface ITransferUnit : IDistributedTxUnit<TransferInput, bool>
    {
    }
}
