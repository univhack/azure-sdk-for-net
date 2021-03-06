// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DomainTopicsOperations.
    /// </summary>
    public static partial class DomainTopicsOperationsExtensions
    {
            /// <summary>
            /// Get a domain topic
            /// </summary>
            /// <remarks>
            /// Get properties of a domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='topicName'>
            /// Name of the topic
            /// </param>
            public static DomainTopic Get(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string topicName)
            {
                return operations.GetAsync(resourceGroupName, domainName, topicName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a domain topic
            /// </summary>
            /// <remarks>
            /// Get properties of a domain topic
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='topicName'>
            /// Name of the topic
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainTopic> GetAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, string topicName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, domainName, topicName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Domain name.
            /// </param>
            public static IEnumerable<DomainTopic> ListByDomain(this IDomainTopicsOperations operations, string resourceGroupName, string domainName)
            {
                return operations.ListByDomainAsync(resourceGroupName, domainName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List domain topics.
            /// </summary>
            /// <remarks>
            /// List all the topics in a domain.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription.
            /// </param>
            /// <param name='domainName'>
            /// Domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<DomainTopic>> ListByDomainAsync(this IDomainTopicsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDomainWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
