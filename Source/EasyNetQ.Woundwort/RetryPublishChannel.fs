﻿namespace EasyNetQ.Woundwort

type RetryPublishChannel =
    inherit WrappedPublishChannel
    new (channel) = { inherit WrappedPublishChannel(Retry.Retry, channel) }


