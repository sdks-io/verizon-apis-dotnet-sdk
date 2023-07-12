// <copyright file="WorkloadUploadTypeEnum.cs" company="APIMatic">
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
    /// WorkloadUploadTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkloadUploadTypeEnum
    {
        /// <summary>
        /// PULLFROMREPO.
        /// </summary>
        [EnumMember(Value = "PULL_FROM_REPO")]
        PULLFROMREPO,

        /// <summary>
        /// MANUALUPLOAD.
        /// </summary>
        [EnumMember(Value = "MANUAL_UPLOAD")]
        MANUALUPLOAD
    }
}