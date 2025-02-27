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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Server endpoint recall error object
    /// </summary>
    public partial class ServerEndpointRecallError
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointRecallError class.
        /// </summary>
        public ServerEndpointRecallError()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointRecallError class.
        /// </summary>
        /// <param name="errorCode">Error code (HResult)</param>
        /// <param name="count">Count of occurences of the error</param>
        public ServerEndpointRecallError(int? errorCode = default(int?), long? count = default(long?))
        {
            ErrorCode = errorCode;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets error code (HResult)
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; private set; }

        /// <summary>
        /// Gets count of occurences of the error
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Count != null)
            {
                if (Count < 0)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Count", 0);
                }
            }
        }
    }
}
