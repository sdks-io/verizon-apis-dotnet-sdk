// <copyright file="AggregatedReportCallbackStatusEnum.cs" company="APIMatic">
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
    /// AggregatedReportCallbackStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AggregatedReportCallbackStatusEnum
    {
        /// <summary>
        /// QUEUED.
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED
    }
}