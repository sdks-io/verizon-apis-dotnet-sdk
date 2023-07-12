// <copyright file="WorkflowTypeEnum.cs" company="APIMatic">
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
    /// WorkflowTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkflowTypeEnum
    {
        /// <summary>
        /// INSTALLATION.
        /// </summary>
        [EnumMember(Value = "INSTALLATION")]
        INSTALLATION,

        /// <summary>
        /// OPERATIONS.
        /// </summary>
        [EnumMember(Value = "OPERATIONS")]
        OPERATIONS,

        /// <summary>
        /// CUSTOM.
        /// </summary>
        [EnumMember(Value = "CUSTOM")]
        CUSTOM
    }
}