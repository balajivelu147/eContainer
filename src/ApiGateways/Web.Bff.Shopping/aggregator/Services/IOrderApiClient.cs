namespace Microsoft.MPGC.Web.Shopping.HttpAggregator.Services;

public interface IOrderApiClient
{
    Task<OrderData> GetOrderDraftFromBasketAsync(BasketData basket);
}
