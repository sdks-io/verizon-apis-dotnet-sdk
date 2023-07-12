// <copyright file="SortDirectionEnum.cs" company="APIMatic">
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
    /// SortDirectionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortDirectionEnum
    {
        /// <summary>
        /// ASC.
        /// </summary>
        [EnumMember(Value = "ASC")]
        ASC,

        /// <summary>
        /// DESC.
        /// </summary>
        [EnumMember(Value = "DESC")]
        DESC
    }
}