// <copyright file="UEIdentityTypeEnum.cs" company="APIMatic">
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
    /// UEIdentityTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UEIdentityTypeEnum
    {
        /// <summary>
        /// IPAddress.
        /// </summary>
        [EnumMember(Value = "IPAddress")]
        IPAddress,

        /// <summary>
        /// MSISDN.
        /// </summary>
        [EnumMember(Value = "MSISDN")]
        MSISDN,

        /// <summary>
        /// IMEI.
        /// </summary>
        [EnumMember(Value = "IMEI")]
        IMEI,

        /// <summary>
        /// MDN.
        /// </summary>
        [EnumMember(Value = "MDN")]
        MDN,

        /// <summary>
        /// GPSI.
        /// </summary>
        [EnumMember(Value = "GPSI")]
        GPSI
    }
}