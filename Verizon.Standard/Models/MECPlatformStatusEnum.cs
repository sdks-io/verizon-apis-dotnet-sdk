// <copyright file="MECPlatformStatusEnum.cs" company="APIMatic">
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
    /// MECPlatformStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MECPlatformStatusEnum
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Inactive.
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown
    }
}