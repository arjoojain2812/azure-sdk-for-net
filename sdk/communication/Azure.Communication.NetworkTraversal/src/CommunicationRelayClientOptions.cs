﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;

namespace Azure.Communication.NetworkTraversal
{
    /// <summary>
    /// The options for communication <see cref="CommunicationRelayClientOptions"/>.
    /// </summary>
    public class CommunicationRelayClientOptions : ClientOptions
    {
        /// <summary>
        /// The latest version of the networking service.
        /// </summary>
        internal const ServiceVersion LatestVersion = ServiceVersion.V2021_06_21_preview;

        internal string ApiVersion { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunicationRelayClientOptions"/>.
        /// </summary>
        public CommunicationRelayClientOptions(ServiceVersion version = LatestVersion)
        {
            ApiVersion = version switch
            {
                ServiceVersion.V2021_06_21_preview  => "2021-06-21-preview",
                _ => throw new ArgumentOutOfRangeException(nameof(version)),
            };
        }

        /// <summary>
        /// The token service version.
        /// </summary>
        public enum ServiceVersion
        {
#pragma warning disable CA1707 // Identifiers should not contain underscores
            /// <summary>
            /// The V2021_06_21_preview of the networking service.
            /// </summary>
#pragma warning disable AZC0016 // Invalid ServiceVersion member name.
            V2021_06_21_preview = 1,
#pragma warning restore AZC0016 // Invalid ServiceVersion member name.
#pragma warning restore CA1707 // Identifiers should not contain underscores
        }
    }
}
