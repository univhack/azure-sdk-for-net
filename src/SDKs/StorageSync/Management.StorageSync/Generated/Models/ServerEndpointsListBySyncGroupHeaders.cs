// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for ListBySyncGroup operation.
    /// </summary>
    public partial class ServerEndpointsListBySyncGroupHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ServerEndpointsListBySyncGroupHeaders class.
        /// </summary>
        public ServerEndpointsListBySyncGroupHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ServerEndpointsListBySyncGroupHeaders class.
        /// </summary>
        /// <param name="location">Operation Status Location URI</param>
        /// <param name="xMsRequestId">request id.</param>
        /// <param name="xMsCorrelationRequestId">correlation request
        /// id.</param>
        public ServerEndpointsListBySyncGroupHeaders(string location = default(string), string xMsRequestId = default(string), string xMsCorrelationRequestId = default(string))
        {
            Location = location;
            XMsRequestId = xMsRequestId;
            XMsCorrelationRequestId = xMsCorrelationRequestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets operation Status Location URI
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets request id.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-request-id")]
        public string XMsRequestId { get; set; }

        /// <summary>
        /// Gets or sets correlation request id.
        /// </summary>
        [JsonProperty(PropertyName = "x-ms-correlation-request-id")]
        public string XMsCorrelationRequestId { get; set; }

    }
}
