// <copyright file="HookTypeEnum.cs" company="APIMatic">
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
    /// HookTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HookTypeEnum
    {
        /// <summary>
        /// PREINSTALLATION.
        /// </summary>
        [EnumMember(Value = "PRE_INSTALLATION")]
        PREINSTALLATION,

        /// <summary>
        /// POSTINSTALLATION.
        /// </summary>
        [EnumMember(Value = "POST_INSTALLATION")]
        POSTINSTALLATION
    }
}