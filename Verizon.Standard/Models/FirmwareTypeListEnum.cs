// <copyright file="FirmwareTypeListEnum.cs" company="APIMatic">
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
    /// FirmwareTypeListEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FirmwareTypeListEnum
    {
        /// <summary>
        /// Append.
        /// </summary>
        [EnumMember(Value = "append")]
        Append,

        /// <summary>
        /// Remove.
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove
    }
}