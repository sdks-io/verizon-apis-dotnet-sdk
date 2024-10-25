// <copyright file="NumericalDataUnitEnum.cs" company="APIMatic">
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
    /// NumericalDataUnitEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NumericalDataUnitEnum
    {
        /// <summary>
        /// SECOND.
        /// </summary>
        [EnumMember(Value = "SECOND")]
        SECOND,

        /// <summary>
        /// MINUTE.
        /// </summary>
        [EnumMember(Value = "MINUTE")]
        MINUTE,

        /// <summary>
        /// HOUR.
        /// </summary>
        [EnumMember(Value = "HOUR")]
        HOUR,

        /// <summary>
        /// DAY.
        /// </summary>
        [EnumMember(Value = "DAY")]
        DAY
    }
}