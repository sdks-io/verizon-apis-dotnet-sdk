// <copyright file="ReportStatusEnum.cs" company="APIMatic">
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
    /// ReportStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReportStatusEnum
    {
        /// <summary>
        /// QUEUED.
        /// </summary>
        [EnumMember(Value = "QUEUED")]
        QUEUED,

        /// <summary>
        /// INPROGRESS.
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS,

        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED
    }
}