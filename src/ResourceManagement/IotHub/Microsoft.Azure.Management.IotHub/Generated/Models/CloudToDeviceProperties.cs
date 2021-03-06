// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.IotHub.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The Iot Hub Cloud-To-Device messaging properties.
    /// </summary>
    public partial class CloudToDeviceProperties
    {
        /// <summary>
        /// Initializes a new instance of the CloudToDeviceProperties class.
        /// </summary>
        public CloudToDeviceProperties() { }

        /// <summary>
        /// Initializes a new instance of the CloudToDeviceProperties class.
        /// </summary>
        public CloudToDeviceProperties(int? maxDeliveryCount = default(int?), TimeSpan? defaultTtlAsIso8601 = default(TimeSpan?), FeedbackProperties feedback = default(FeedbackProperties))
        {
            MaxDeliveryCount = maxDeliveryCount;
            DefaultTtlAsIso8601 = defaultTtlAsIso8601;
            Feedback = feedback;
        }

        /// <summary>
        /// The max delivery count for the device queue. Range : 1-100.
        /// </summary>
        [JsonProperty(PropertyName = "maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }

        /// <summary>
        /// The default time to live for the device queue. Range : 1 Min
        /// (PT1M) - 2 Days (P2D).
        /// </summary>
        [JsonProperty(PropertyName = "defaultTtlAsIso8601")]
        public TimeSpan? DefaultTtlAsIso8601 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "feedback")]
        public FeedbackProperties Feedback { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.MaxDeliveryCount > 100)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaxDeliveryCount", 100);
            }
            if (this.MaxDeliveryCount < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxDeliveryCount", 1);
            }
            if (this.Feedback != null)
            {
                this.Feedback.Validate();
            }
        }
    }
}
