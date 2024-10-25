// <copyright file="CacheModeEnum.cs" company="APIMatic">
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
    /// CacheModeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CacheModeEnum
    {
        /// <summary>
        /// Enum0.
        /// </summary>
        [EnumMember(Value = "0")]
        Enum0,

        /// <summary>
        /// Enum1.
        /// </summary>
        [EnumMember(Value = "1")]
        Enum1,

        /// <summary>
        /// Enum2.
        /// </summary>
        [EnumMember(Value = "2")]
        Enum2
    }
}