// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ContainerOperations operations.
    /// </summary>
    public partial interface IContainerOperations
    {
        /// <summary>
        /// Get the logs for a specified container instance.
        /// </summary>
        /// <remarks>
        /// Get the logs for a specified container instance in a specified
        /// resource group and container group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='containerGroupName'>
        /// The name of the container group.
        /// </param>
        /// <param name='containerName'>
        /// The name of the container instance.
        /// </param>
        /// <param name='tail'>
        /// The number of lines to show from the tail of the container instance
        /// log. If not provided, all available logs are shown up to 4mb.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<Logs>> ListLogsWithHttpMessagesAsync(string resourceGroupName, string containerGroupName, string containerName, int? tail = default(int?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Executes a command in a specific container instance.
        /// </summary>
        /// <remarks>
        /// Executes a command for a specific container instance in a specified
        /// resource group and container group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='containerGroupName'>
        /// The name of the container group.
        /// </param>
        /// <param name='containerName'>
        /// The name of the container instance.
        /// </param>
        /// <param name='containerExecRequest'>
        /// The request for the exec command.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ContainerExecResponse>> ExecuteCommandWithHttpMessagesAsync(string resourceGroupName, string containerGroupName, string containerName, ContainerExecRequest containerExecRequest, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
