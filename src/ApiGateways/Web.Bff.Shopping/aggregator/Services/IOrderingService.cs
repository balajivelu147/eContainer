﻿namespace Microsoft.MPGC.Web.Shopping.HttpAggregator.Services;

public interface IOrderingService
{
    Task<OrderData> GetOrderDraftAsync(BasketData basketData);
}
