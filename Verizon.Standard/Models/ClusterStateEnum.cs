// <copyright file="ClusterStateEnum.cs" company="APIMatic">
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
    /// ClusterStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClusterStateEnum
    {
        /// <summary>
        /// READY.
        /// </summary>
        [EnumMember(Value = "READY")]
        READY,

        /// <summary>
        /// NOTREADY.
        /// </summary>
        [EnumMember(Value = "NOT_READY")]
        NOTREADY
    }
}