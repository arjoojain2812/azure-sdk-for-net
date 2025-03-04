// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        #region DeploymentExtended
        /// <summary> Gets an object representing a DeploymentExtendedContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="DeploymentExtendedContainer" /> object. </returns>
        public static DeploymentExtendedContainer GetDeploymentExtendeds(this Subscription subscription)
        {
            return new DeploymentExtendedContainer(subscription);
        }
        #endregion

        #region Application
        private static ApplicationsRestOperations GetApplicationsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new ApplicationsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the Applications for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<Application> GetApplicationsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetApplications");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetApplications");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the Applications for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<Application> GetApplications(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetApplicationsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<Application> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetApplications");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscription(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetApplications");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscriptionNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Application(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of Applications for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetApplicationByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Application.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of Applications for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetApplicationByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(Application.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region JitRequestDefinition
        private static JitRequestsRestOperations GetJitRequestsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new JitRequestsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<IReadOnlyList<JitRequestDefinition>>> GetJitRequestDefinitionsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return await subscription.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJitRequestsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJitRequestDefinitions");
                scope.Start();
                try
                {
                    var response = await restOperations.GetAllBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(subscription, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Retrieves all JIT requests within the subscription. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<IReadOnlyList<JitRequestDefinition>> GetJitRequestDefinitions(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetJitRequestsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetJitRequestDefinitions");
                scope.Start();
                try
                {
                    var response = restOperations.GetAllBySubscription(cancellationToken);
                    return Response.FromValue(response.Value.Value.Select(data => new JitRequestDefinition(subscription, data)).ToArray() as IReadOnlyList<JitRequestDefinition>, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }

        /// <summary> Filters the list of JitRequestDefinitions for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetJitRequestDefinitionByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JitRequestDefinition.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of JitRequestDefinitions for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetJitRequestDefinitionByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(JitRequestDefinition.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region DeploymentScript
        private static DeploymentScriptsRestOperations GetDeploymentScriptsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new DeploymentScriptsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the DeploymentScripts for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DeploymentScript> GetDeploymentScriptsAsync(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<DeploymentScript>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<DeploymentScript>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the DeploymentScripts for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<DeploymentScript> GetDeploymentScripts(this Subscription subscription, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetDeploymentScriptsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<DeploymentScript> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscription(cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<DeploymentScript> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetDeploymentScripts");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscriptionNextPage(nextLink, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new DeploymentScript(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of DeploymentScripts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetDeploymentScriptByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScript.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of DeploymentScripts for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetDeploymentScriptByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(DeploymentScript.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion

        #region TemplateSpec
        private static TemplateSpecsRestOperations GetTemplateSpecsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new TemplateSpecsRestOperations(clientDiagnostics, pipeline, clientOptions, subscriptionId, endpoint);
        }

        /// <summary> Lists the TemplateSpecs for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TemplateSpec> GetTemplateSpecsAsync(this Subscription subscription, TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetTemplateSpecsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<TemplateSpec>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetTemplateSpecs");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionAsync(expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new TemplateSpec(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<TemplateSpec>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetTemplateSpecs");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.GetAllBySubscriptionNextPageAsync(nextLink, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new TemplateSpec(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the TemplateSpecs for this <see cref="Subscription" />. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="expand"> Allows for expansion of additional Template Spec details in the response. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<TemplateSpec> GetTemplateSpecs(this Subscription subscription, TemplateSpecExpandKind? expand = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetTemplateSpecsRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<TemplateSpec> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetTemplateSpecs");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscription(expand, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new TemplateSpec(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<TemplateSpec> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("SubscriptionExtensions.GetTemplateSpecs");
                    scope.Start();
                    try
                    {
                        var response = restOperations.GetAllBySubscriptionNextPage(nextLink, expand, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new TemplateSpec(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of TemplateSpecs for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<GenericResource> GetTemplateSpecByNameAsync(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(TemplateSpec.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContextAsync(subscription, filters, expand, top, cancellationToken);
        }

        /// <summary> Filters the list of TemplateSpecs for a <see cref="Subscription" /> represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of resource operations that may take multiple service requests to iterate over. </returns>
        public static Pageable<GenericResource> GetTemplateSpecByName(this Subscription subscription, string filter, string expand, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(TemplateSpec.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.GetAtContext(subscription, filters, expand, top, cancellationToken);
        }
        #endregion
    }
}
