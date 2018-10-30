// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface ILUISAuthoringClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Cognitive Services endpoints (protocol and hostname, for
        /// example: https://westus.api.cognitive.microsoft.com).
        /// </summary>
        string Endpoint { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IFeatures.
        /// </summary>
        IFeatures Features { get; }

        /// <summary>
        /// Gets the IExamples.
        /// </summary>
        IExamples Examples { get; }

        /// <summary>
        /// Gets the IModel.
        /// </summary>
        IModel Model { get; }

        /// <summary>
        /// Gets the IApps.
        /// </summary>
        IApps Apps { get; }

        /// <summary>
        /// Gets the IVersions.
        /// </summary>
        IVersions Versions { get; }

        /// <summary>
        /// Gets the ITrain.
        /// </summary>
        ITrain Train { get; }

        /// <summary>
        /// Gets the IPermissions.
        /// </summary>
        IPermissions Permissions { get; }

        /// <summary>
        /// Gets the IPattern.
        /// </summary>
        IPattern Pattern { get; }

    }
}
