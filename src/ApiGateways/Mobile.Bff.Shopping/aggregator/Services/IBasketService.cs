namespace Microsoft.MPGC.Mobile.Shopping.HttpAggregator.Services;

public interface IBasketService
{
    Task<BasketData> GetByIdAsync(string id);

    Task UpdateAsync(BasketData currentBasket);
}
