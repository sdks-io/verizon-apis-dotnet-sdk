// <copyright file="KindEnum.cs" company="APIMatic">
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
    /// KindEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KindEnum
    {
        /// <summary>
        /// Imei.
        /// </summary>
        [EnumMember(Value = "imei")]
        Imei,

        /// <summary>
        /// Eid.
        /// </summary>
        [EnumMember(Value = "eid")]
        Eid,

        /// <summary>
        /// Esn.
        /// </summary>
        [EnumMember(Value = "esn")]
        Esn,

        /// <summary>
        /// Iccid.
        /// </summary>
        [EnumMember(Value = "iccid")]
        Iccid
    }
}