// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MatchRecordV2dot1
    {
        /// <summary>
        /// Initializes a new instance of the MatchRecordV2dot1 class.
        /// </summary>
        public MatchRecordV2dot1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MatchRecordV2dot1 class.
        /// </summary>
        /// <param name="text">Entity text as appears in the request.</param>
        /// <param name="offset">Start position (in Unicode characters) for the
        /// entity match text.</param>
        /// <param name="length">Length (in Unicode characters) for the entity
        /// match text.</param>
        public MatchRecordV2dot1(string text = default(string), int? offset = default(int?), int? length = default(int?))
        {
            Text = text;
            Offset = offset;
            Length = length;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets entity text as appears in the request.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets start position (in Unicode characters) for the entity
        /// match text.
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Gets or sets length (in Unicode characters) for the entity match
        /// text.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int? Length { get; set; }

    }
}
