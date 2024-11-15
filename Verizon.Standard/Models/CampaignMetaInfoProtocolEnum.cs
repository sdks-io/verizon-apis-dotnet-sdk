// <copyright file="CampaignMetaInfoProtocolEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
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