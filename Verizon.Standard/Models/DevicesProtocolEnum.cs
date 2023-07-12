// <copyright file="DevicesProtocolEnum.cs" company="APIMatic">
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
    /// DevicesProtocolEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DevicesProtocolEnum
    {
        /// <summary>
        /// LWM2m.
        /// </summary>
        [EnumMember(Value = "LWM2M")]
        LWM2m,

        /// <summary>
        /// OMDADM.
        /// </summary>
        [EnumMember(Value = "OMDADM")]
        OMDADM,

        /// <summary>
        /// HTTP.
        /// </summary>
        [EnumMember(Value = "HTTP")]
        HTTP
    }
}