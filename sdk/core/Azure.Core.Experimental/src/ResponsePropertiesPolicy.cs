﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    /// <summary>
    /// </summary>
    internal class ResponsePropertiesPolicy : HttpPipelinePolicy
    {
        private ClientOptions _clientOptions;

        public ResponsePropertiesPolicy(ClientOptions options)
        {
            _clientOptions = options;
        }

        /// <inheritdoc/>
        public override void Process(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            ProcessAsync(message, pipeline, false).EnsureCompleted();
        }

        /// <inheritdoc/>
        public override ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline)
        {
            return ProcessAsync(message, pipeline, true);
        }

        private async ValueTask ProcessAsync(HttpMessage message, ReadOnlyMemory<HttpPipelinePolicy> pipeline, bool async)
        {
            if (async)
            {
                await ProcessNextAsync(message, pipeline).ConfigureAwait(false);
            }
            else
            {
                ProcessNext(message, pipeline);
            }

            // In the non-experimental version of this policy, these lines reduce to:
            // > message.Response.EvaluateError(message);
            ClassifiedResponse response = new ClassifiedResponse(message.Response);
            response.EvaluateError(message);
            message.Response = response;

            // The non-experimental version of this functionality is roughly described in:
            // https://github.com/Azure/azure-sdk-for-net/pull/24248
            response.ResponseClassifier = new ExceptionFormattingResponseClassifier(message.ResponseClassifier, _clientOptions.Diagnostics);
        }
    }
}
