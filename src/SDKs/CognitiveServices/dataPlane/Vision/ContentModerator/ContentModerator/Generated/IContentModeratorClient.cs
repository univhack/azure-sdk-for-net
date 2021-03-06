// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// You use the API to scan your content as it is generated. Content
    /// Moderator then processes your content and sends the results along with
    /// relevant information either back to your systems or to the built-in
    /// review tool. You can use this information to take decisions e.g. take
    /// it down, send to human judge, etc.
    ///
    /// When using the API, images need to have a minimum of 128 pixels and a
    /// maximum file size of 4MB.
    /// Text can be at most 1024 characters long.
    /// If the content passed to the text API or the image API exceeds the size
    /// limits, the API will return an error code that informs about the issue.
    /// </summary>
    public partial interface IContentModeratorClient : System.IDisposable
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
        /// Gets the IImageModeration.
        /// </summary>
        IImageModeration ImageModeration { get; }

        /// <summary>
        /// Gets the ITextModeration.
        /// </summary>
        ITextModeration TextModeration { get; }

        /// <summary>
        /// Gets the IListManagementImageLists.
        /// </summary>
        IListManagementImageLists ListManagementImageLists { get; }

        /// <summary>
        /// Gets the IListManagementTermLists.
        /// </summary>
        IListManagementTermLists ListManagementTermLists { get; }

        /// <summary>
        /// Gets the IListManagementImage.
        /// </summary>
        IListManagementImage ListManagementImage { get; }

        /// <summary>
        /// Gets the IListManagementTerm.
        /// </summary>
        IListManagementTerm ListManagementTerm { get; }

        /// <summary>
        /// Gets the IReviews.
        /// </summary>
        IReviews Reviews { get; }

    }
}
