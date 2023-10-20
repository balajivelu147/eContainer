﻿namespace Microsoft.MPGC.Mobile.Shopping.HttpAggregator.Models;

public class UpdateBasketRequest
{
    public string BuyerId { get; set; }

    public IEnumerable<UpdateBasketRequestItemData> Items { get; set; }
}