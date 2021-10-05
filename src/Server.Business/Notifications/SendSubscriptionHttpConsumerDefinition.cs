﻿using MassTransit;
using MassTransit.ConsumeConfigurators;
using MassTransit.Definition;

namespace Server.Notifications
{
    public class SendSubscriptionHttpConsumerDefinition : ConsumerDefinition<SendSubscriptionHttpConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator,
            IConsumerConfigurator<SendSubscriptionHttpConsumer> e)
        {
            e.UseDelayedRedelivery(HttpRetryPolicy.ConfigureHttpRetry);
        }
    }
}