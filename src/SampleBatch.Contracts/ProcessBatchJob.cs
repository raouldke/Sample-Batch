﻿using SampleBatch.Contracts.Enums;
using System;

namespace SampleBatch.Contracts
{
    public interface ProcessBatchJob
    {
        Guid BatchJobId { get; set; }
        Guid BatchId { get; set; }
        DateTime Timestamp { get; set; }
        Guid OrderId { get; set; }
        BatchAction Action { get; set; }
    }
}
