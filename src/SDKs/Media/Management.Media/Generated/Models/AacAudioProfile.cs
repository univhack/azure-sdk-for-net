// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AacAudioProfile.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AacAudioProfile
    {
        /// <summary>
        /// Specifies that the output audio is to be encoded into AAC Low
        /// Complexity profile (AAC-LC).
        /// </summary>
        [EnumMember(Value = "AacLc")]
        AacLc,
        /// <summary>
        /// Specifies that the output audio is to be encoded into HE-AAC v1
        /// profile.
        /// </summary>
        [EnumMember(Value = "HeAacV1")]
        HeAacV1,
        /// <summary>
        /// Specifies that the output audio is to be encoded into HE-AAC v2
        /// profile.
        /// </summary>
        [EnumMember(Value = "HeAacV2")]
        HeAacV2
    }
    internal static class AacAudioProfileEnumExtension
    {
        internal static string ToSerializedValue(this AacAudioProfile? value)
        {
            return value == null ? null : ((AacAudioProfile)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AacAudioProfile value)
        {
            switch( value )
            {
                case AacAudioProfile.AacLc:
                    return "AacLc";
                case AacAudioProfile.HeAacV1:
                    return "HeAacV1";
                case AacAudioProfile.HeAacV2:
                    return "HeAacV2";
            }
            return null;
        }

        internal static AacAudioProfile? ParseAacAudioProfile(this string value)
        {
            switch( value )
            {
                case "AacLc":
                    return AacAudioProfile.AacLc;
                case "HeAacV1":
                    return AacAudioProfile.HeAacV1;
                case "HeAacV2":
                    return AacAudioProfile.HeAacV2;
            }
            return null;
        }
    }
}
