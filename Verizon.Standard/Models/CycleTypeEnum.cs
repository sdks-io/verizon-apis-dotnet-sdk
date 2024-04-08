// <copyright file="CycleTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// CycleTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CycleTypeEnum
    {
        /// <summary>
        /// Cycleone.
        /// </summary>
        [EnumMember(Value = "cycleone")]
        Cycleone,

        /// <summary>
        /// Cycletwo.
        /// </summary>
        [EnumMember(Value = "cycletwo")]
        Cycletwo
    }
}