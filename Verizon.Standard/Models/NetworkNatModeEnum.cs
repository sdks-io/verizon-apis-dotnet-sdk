// <copyright file="NetworkNatModeEnum.cs" company="APIMatic">
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
    /// NetworkNatModeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NetworkNatModeEnum
    {
        /// <summary>
        /// HighAvailable.
        /// </summary>
        [EnumMember(Value = "highAvailable")]
        HighAvailable,

        /// <summary>
        /// Single.
        /// </summary>
        [EnumMember(Value = "single")]
        Single,

        /// <summary>
        /// Disable.
        /// </summary>
        [EnumMember(Value = "disable")]
        Disable
    }
}