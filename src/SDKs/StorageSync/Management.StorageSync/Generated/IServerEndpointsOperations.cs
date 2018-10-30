// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ServerEndpointsOperations operations.
    /// </summary>
    public partial interface IServerEndpointsOperations
    {
        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Server Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServerEndpoint,ServerEndpointsCreateHeaders>> CreateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Any of the properties applicable in PUT request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServerEndpoint,ServerEndpointsUpdateHeaders>> UpdateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServerEndpoint,ServerEndpointsGetHeaders>> GetWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ServerEndpointsDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a ServerEndpoint list.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<ServerEndpoint>,ServerEndpointsListBySyncGroupHeaders>> ListBySyncGroupWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Recall a serverendpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Recall Action object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ServerEndpointsRecallActionHeaders>> RecallActionWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Server Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServerEndpoint,ServerEndpointsCreateHeaders>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointCreateParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch a given ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Any of the properties applicable in PUT request.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ServerEndpoint,ServerEndpointsUpdateHeaders>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, ServerEndpointUpdateParameters parameters = default(ServerEndpointUpdateParameters), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a given ServerEndpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ServerEndpointsDeleteHeaders>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Recall a serverendpoint.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='storageSyncServiceName'>
        /// Name of Storage Sync Service resource.
        /// </param>
        /// <param name='syncGroupName'>
        /// Name of Sync Group resource.
        /// </param>
        /// <param name='serverEndpointName'>
        /// Name of Server Endpoint object.
        /// </param>
        /// <param name='parameters'>
        /// Body of Recall Action object.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="StorageSyncErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationHeaderResponse<ServerEndpointsRecallActionHeaders>> BeginRecallActionWithHttpMessagesAsync(string resourceGroupName, string storageSyncServiceName, string syncGroupName, string serverEndpointName, RecallActionParameters parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
