// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StringBeginsWith Filter
    /// </summary>
    [Newtonsoft.Json.JsonObject("StringBeginsWith")]
    public partial class StringBeginsWithAdvancedFilter : AdvancedFilter
    {
        /// <summary>
        /// Initializes a new instance of the StringBeginsWithAdvancedFilter
        /// class.
        /// </summary>
        public StringBeginsWithAdvancedFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StringBeginsWithAdvancedFilter
        /// class.
        /// </summary>
        /// <param name="key">The filter key. Represents an event property with
        /// upto two levels of nesting.</param>
        /// <param name="values">The set of filter values</param>
        public StringBeginsWithAdvancedFilter(string key = default(string), IList<string> values = default(IList<string>))
            : base(key)
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of filter values
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

    }
}
