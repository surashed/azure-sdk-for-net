// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Online endpoint configuration. </summary>
    public partial class MachineLearningOnlineEndpointProperties : MachineLearningEndpointProperties
    {
        /// <summary> Initializes a new instance of MachineLearningOnlineEndpointProperties. </summary>
        /// <param name="authMode"> [Required] Use &apos;Key&apos; for key based authentication and &apos;AMLToken&apos; for Azure Machine Learning token-based authentication. &apos;Key&apos; doesn&apos;t expire but &apos;AMLToken&apos; does. </param>
        public MachineLearningOnlineEndpointProperties(MachineLearningEndpointAuthMode authMode) : base(authMode)
        {
            Traffic = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of MachineLearningOnlineEndpointProperties. </summary>
        /// <param name="authMode"> [Required] Use &apos;Key&apos; for key based authentication and &apos;AMLToken&apos; for Azure Machine Learning token-based authentication. &apos;Key&apos; doesn&apos;t expire but &apos;AMLToken&apos; does. </param>
        /// <param name="description"> Description of the inference endpoint. </param>
        /// <param name="keys">
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="scoringUri"> Endpoint URI. </param>
        /// <param name="swaggerUri"> Endpoint Swagger URI. </param>
        /// <param name="compute">
        /// ARM resource ID of the compute if it exists.
        /// optional
        /// </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint. </param>
        /// <param name="publicNetworkAccess"> Set to &quot;Enabled&quot; for endpoints that should allow public access when Private Link is enabled. </param>
        /// <param name="traffic"> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </param>
        internal MachineLearningOnlineEndpointProperties(MachineLearningEndpointAuthMode authMode, string description, MachineLearningEndpointAuthKeys keys, IDictionary<string, string> properties, Uri scoringUri, Uri swaggerUri, string compute, MachineLearningEndpointProvisioningState? provisioningState, MachineLearningPublicNetworkAccessType? publicNetworkAccess, IDictionary<string, int> traffic) : base(authMode, description, keys, properties, scoringUri, swaggerUri)
        {
            Compute = compute;
            ProvisioningState = provisioningState;
            PublicNetworkAccess = publicNetworkAccess;
            Traffic = traffic;
        }

        /// <summary>
        /// ARM resource ID of the compute if it exists.
        /// optional
        /// </summary>
        public string Compute { get; set; }
        /// <summary> Provisioning state for the endpoint. </summary>
        public MachineLearningEndpointProvisioningState? ProvisioningState { get; }
        /// <summary> Set to &quot;Enabled&quot; for endpoints that should allow public access when Private Link is enabled. </summary>
        public MachineLearningPublicNetworkAccessType? PublicNetworkAccess { get; set; }
        /// <summary> Percentage of traffic from endpoint to divert to each deployment. Traffic values need to sum to 100. </summary>
        public IDictionary<string, int> Traffic { get; set; }
    }
}
