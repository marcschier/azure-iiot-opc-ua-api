// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Twin.Models {
    using Newtonsoft.Json;

    /// <summary>
    /// Browse nodes by path
    /// </summary>
    public class BrowsePathRequestApiModel {

        /// <summary>
        /// Node to browse.
        /// (default: RootFolder).
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// The path elements of the path to browse from node.
        /// (mandatory)
        /// </summary>
        [JsonProperty(PropertyName = "pathElements")]
        public string[] PathElements { get; set; }

        /// <summary>
        /// Whether to read variable values on target nodes.
        /// (default is false)
        /// </summary>
        [JsonProperty(PropertyName = "readVariableValues",
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadVariableValues { get; set; }

        /// <summary>
        /// Optional User elevation
        /// </summary>
        [JsonProperty(PropertyName = "elevation",
            NullValueHandling = NullValueHandling.Ignore)]
        public CredentialApiModel Elevation { get; set; }

        /// <summary>
        /// Optional diagnostics configuration
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics",
            NullValueHandling = NullValueHandling.Ignore)]
        public DiagnosticsApiModel Diagnostics { get; set; }
    }
}
