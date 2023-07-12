// <copyright file="CSPProfileTypeEnum.cs" company="APIMatic">
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
    /// CSPProfileTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CSPProfileTypeEnum
    {
        /// <summary>
        /// AWS.
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,

        /// <summary>
        /// AZURE.
        /// </summary>
        [EnumMember(Value = "AZURE")]
        AZURE
    }
}