﻿namespace Ordering.BackgroundTasks.Events
{
    using Microsoft.MPGC.BuildingBlocks.EventBus.Events;

    public record GracePeriodConfirmedIntegrationEvent : IntegrationEvent
    {
        public int OrderId { get; }

        public GracePeriodConfirmedIntegrationEvent(int orderId) =>
            OrderId = orderId;
    }
}
