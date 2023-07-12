// <copyright file="SandBoxStatusEnum.cs" company="APIMatic">
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
    /// SandBoxStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SandBoxStatusEnum
    {
        /// <summary>
        /// NA.
        /// </summary>
        [EnumMember(Value = "NA")]
        NA,

        /// <summary>
        /// INPROGRESS.
        /// </summary>
        [EnumMember(Value = "INPROGRESS")]
        INPROGRESS,

        /// <summary>
        /// SUCCESS.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED
    }
}