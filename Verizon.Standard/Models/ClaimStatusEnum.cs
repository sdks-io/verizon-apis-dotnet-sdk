// <copyright file="ClaimStatusEnum.cs" company="APIMatic">
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
    /// ClaimStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClaimStatusEnum
    {
        /// <summary>
        /// UNVERIFIED.
        /// </summary>
        [EnumMember(Value = "UNVERIFIED")]
        UNVERIFIED,

        /// <summary>
        /// VERIFIED.
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        VERIFIED
    }
}