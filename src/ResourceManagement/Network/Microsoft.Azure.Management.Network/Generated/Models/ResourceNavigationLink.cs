// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// ResourceNavigationLink resource
    /// </summary>
    [JsonTransformation]
    public partial class ResourceNavigationLink : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the ResourceNavigationLink class.
        /// </summary>
        public ResourceNavigationLink() { }

        /// <summary>
        /// Initializes a new instance of the ResourceNavigationLink class.
        /// </summary>
        public ResourceNavigationLink(string id = default(string), string linkedResourceType = default(string), string link = default(string), string provisioningState = default(string), string name = default(string), string etag = default(string))
            : base(id)
        {
            LinkedResourceType = linkedResourceType;
            Link = link;
            ProvisioningState = provisioningState;
            Name = name;
            Etag = etag;
        }

        /// <summary>
        /// Resource type of the linked resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.linkedResourceType")]
        public string LinkedResourceType { get; set; }

        /// <summary>
        /// Link to the external resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.link")]
        public string Link { get; set; }

        /// <summary>
        /// Provisioning state of the ResourceNavigationLink resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Name of the resource that is unique within a resource group. This
        /// name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
