﻿// Copyright (c) Microsoft. All rights reserved.
//
// Licensed under the MIT license.

using System;
using NuGetCredentialProvider.Logging;

namespace NuGetCredentialProvider.CredentialProviders.Vsts
{
    internal class MsalTokenProviderFactory : IMsalTokenProviderFactory
    {
        private const string Resource = "499b84ac-1321-427f-aa17-267ca6975798/.default";
        private const string ClientId = "872cd9fa-d31f-45e0-9eab-6e460a02d1f1";

        public IMsalTokenProvider Get(Uri authority, bool brokerEnabled, ILogger logger)
        {
            return new MsalTokenProvider(authority, Resource, ClientId, brokerEnabled, logger);
        }
    }
}
