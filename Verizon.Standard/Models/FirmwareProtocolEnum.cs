// <copyright file="FirmwareProtocolEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// FirmwareProtocolEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FirmwareProtocolEnum
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
        OMDDM,

        /// <summary>
        /// All.
        /// </summary>
        [EnumMember(Value = "all")]
        All
    }
}