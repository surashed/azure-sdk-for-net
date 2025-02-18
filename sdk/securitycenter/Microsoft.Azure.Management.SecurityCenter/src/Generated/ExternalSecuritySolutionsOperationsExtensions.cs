// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExternalSecuritySolutionsOperations.
    /// </summary>
    public static partial class ExternalSecuritySolutionsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of external security solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<ExternalSecuritySolution> List(this IExternalSecuritySolutionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of external security solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExternalSecuritySolution>> ListAsync(this IExternalSecuritySolutionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of external Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            public static IPage<ExternalSecuritySolution> ListByHomeRegion(this IExternalSecuritySolutionsOperations operations, string ascLocation)
            {
                return operations.ListByHomeRegionAsync(ascLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of external Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExternalSecuritySolution>> ListByHomeRegionAsync(this IExternalSecuritySolutionsOperations operations, string ascLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionWithHttpMessagesAsync(ascLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a specific external Security Solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='externalSecuritySolutionsName'>
            /// Name of an external security solution.
            /// </param>
            public static ExternalSecuritySolution Get(this IExternalSecuritySolutionsOperations operations, string resourceGroupName, string ascLocation, string externalSecuritySolutionsName)
            {
                return operations.GetAsync(resourceGroupName, ascLocation, externalSecuritySolutionsName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a specific external Security Solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            /// <param name='externalSecuritySolutionsName'>
            /// Name of an external security solution.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExternalSecuritySolution> GetAsync(this IExternalSecuritySolutionsOperations operations, string resourceGroupName, string ascLocation, string externalSecuritySolutionsName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ascLocation, externalSecuritySolutionsName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of external security solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExternalSecuritySolution> ListNext(this IExternalSecuritySolutionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of external security solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExternalSecuritySolution>> ListNextAsync(this IExternalSecuritySolutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of external Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ExternalSecuritySolution> ListByHomeRegionNext(this IExternalSecuritySolutionsOperations operations, string nextPageLink)
            {
                return operations.ListByHomeRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of external Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ExternalSecuritySolution>> ListByHomeRegionNextAsync(this IExternalSecuritySolutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
