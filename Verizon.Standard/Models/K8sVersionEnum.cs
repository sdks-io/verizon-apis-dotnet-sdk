// <copyright file="K8sVersionEnum.cs" company="APIMatic">
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
    /// K8sVersionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum K8sVersionEnum
    {
        /// <summary>
        /// Enum115.
        /// </summary>
        [EnumMember(Value = "1.15")]
        Enum115,

        /// <summary>
        /// Enum116.
        /// </summary>
        [EnumMember(Value = "1.16")]
        Enum116,

        /// <summary>
        /// Enum117.
        /// </summary>
        [EnumMember(Value = "1.17")]
        Enum117,

        /// <summary>
        /// Enum118.
        /// </summary>
        [EnumMember(Value = "1.18")]
        Enum118,

        /// <summary>
        /// Enum121.
        /// </summary>
        [EnumMember(Value = "1.21")]
        Enum121
    }
}