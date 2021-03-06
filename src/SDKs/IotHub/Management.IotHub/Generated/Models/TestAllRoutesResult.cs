// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of testing all routes
    /// </summary>
    public partial class TestAllRoutesResult
    {
        /// <summary>
        /// Initializes a new instance of the TestAllRoutesResult class.
        /// </summary>
        public TestAllRoutesResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TestAllRoutesResult class.
        /// </summary>
        /// <param name="routes">JSON-serialized array of matched
        /// routes</param>
        public TestAllRoutesResult(IList<MatchedRoute> routes = default(IList<MatchedRoute>))
        {
            Routes = routes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets jSON-serialized array of matched routes
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<MatchedRoute> Routes { get; set; }

    }
}
