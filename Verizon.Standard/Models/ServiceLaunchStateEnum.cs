// <copyright file="ServiceLaunchStateEnum.cs" company="APIMatic">
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
    /// ServiceLaunchStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceLaunchStateEnum
    {
        /// <summary>
        /// DRAFT.
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        /// <summary>
        /// INSTANTIATED.
        /// </summary>
        [EnumMember(Value = "INSTANTIATED")]
        INSTANTIATED,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }
}