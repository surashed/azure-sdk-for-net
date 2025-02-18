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
    /// Extension methods for AllowedConnectionsOperations.
    /// </summary>
    public static partial class AllowedConnectionsOperationsExtensions
    {
            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<AllowedConnectionsResource> List(this IAllowedConnectionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<AllowedConnectionsResource>> ListAsync(this IAllowedConnectionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='ascLocation'>
            /// The location where ASC stores the data of the subscription. can be
            /// retrieved from Get locations
            /// </param>
            public static IPage<AllowedConnectionsResource> ListByHomeRegion(this IAllowedConnectionsOperations operations, string ascLocation)
            {
                return operations.ListByHomeRegionAsync(ascLocation).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location.
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
            public static async Task<IPage<AllowedConnectionsResource>> ListByHomeRegionAsync(this IAllowedConnectionsOperations operations, string ascLocation, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionWithHttpMessagesAsync(ascLocation, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location, based on connection type.
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
            /// <param name='connectionType'>
            /// The type of allowed connections (Internal, External). Possible values
            /// include: 'Internal', 'External'
            /// </param>
            public static AllowedConnectionsResource Get(this IAllowedConnectionsOperations operations, string resourceGroupName, string ascLocation, string connectionType)
            {
                return operations.GetAsync(resourceGroupName, ascLocation, connectionType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location, based on connection type.
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
            /// <param name='connectionType'>
            /// The type of allowed connections (Internal, External). Possible values
            /// include: 'Internal', 'External'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AllowedConnectionsResource> GetAsync(this IAllowedConnectionsOperations operations, string resourceGroupName, string ascLocation, string connectionType, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, ascLocation, connectionType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AllowedConnectionsResource> ListNext(this IAllowedConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription
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
            public static async Task<IPage<AllowedConnectionsResource>> ListNextAsync(this IAllowedConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<AllowedConnectionsResource> ListByHomeRegionNext(this IAllowedConnectionsOperations operations, string nextPageLink)
            {
                return operations.ListByHomeRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the list of all possible traffic between resources for the
            /// subscription and location.
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
            public static async Task<IPage<AllowedConnectionsResource>> ListByHomeRegionNextAsync(this IAllowedConnectionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
