// <copyright file="AttributeIdentifierEnum.cs" company="APIMatic">
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
    /// AttributeIdentifierEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttributeIdentifierEnum
    {
        /// <summary>
        /// NETWORKBEARER.
        /// </summary>
        [EnumMember(Value = "NETWORK_BEARER")]
        NETWORKBEARER,

        /// <summary>
        /// RADIOSIGNALSTRENGTH.
        /// </summary>
        [EnumMember(Value = "RADIO_SIGNAL_STRENGTH")]
        RADIOSIGNALSTRENGTH,

        /// <summary>
        /// LINKQUALITY.
        /// </summary>
        [EnumMember(Value = "LINK_QUALITY")]
        LINKQUALITY,

        /// <summary>
        /// CELLID.
        /// </summary>
        [EnumMember(Value = "CELL_ID")]
        CELLID,

        /// <summary>
        /// MANUFACTURER.
        /// </summary>
        [EnumMember(Value = "MANUFACTURER")]
        MANUFACTURER
    }
}