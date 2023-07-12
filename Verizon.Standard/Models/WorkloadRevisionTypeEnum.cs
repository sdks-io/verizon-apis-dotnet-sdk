// <copyright file="WorkloadRevisionTypeEnum.cs" company="APIMatic">
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
    /// WorkloadRevisionTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkloadRevisionTypeEnum
    {
        /// <summary>
        /// BRANCH.
        /// </summary>
        [EnumMember(Value = "BRANCH")]
        BRANCH,

        /// <summary>
        /// TAG.
        /// </summary>
        [EnumMember(Value = "TAG")]
        TAG
    }
}