// <copyright file="DevicesProtocolEnum.cs" company="APIMatic">
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