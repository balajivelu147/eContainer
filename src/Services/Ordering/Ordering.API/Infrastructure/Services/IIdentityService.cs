﻿namespace Microsoft.MPGC.Services.Ordering.API.Infrastructure.Services;

public interface IIdentityService
{
    string GetUserIdentity();

    string GetUserName();
}

