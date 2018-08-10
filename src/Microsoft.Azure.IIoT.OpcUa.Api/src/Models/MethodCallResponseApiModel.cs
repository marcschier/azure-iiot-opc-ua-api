// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Api.Models {
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Method call response model
    /// </summary>
    public class MethodCallResponseApiModel {

        /// <summary>
        /// Output results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<JToken> Results { get; set; }

        /// <summary>
        /// Optional error diagnostics
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics",
            NullValueHandling = NullValueHandling.Ignore)]
        public JToken Diagnostics { get; set; }
    }
}