// <copyright file="CampaignMetaInfoProtocolEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// CampaignMetaInfoProtocolEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignMetaInfoProtocolEnum
    {
        /// <summary>
        /// LWM2m.
        /// </summary>
        [EnumMember(Value = "LWM2M")]
        LWM2m,

        /// <summary>
        /// OMDDM.
        /// </summary>
        [EnumMember(Value = "OMD-DM")]
        OMDDM
    }
}