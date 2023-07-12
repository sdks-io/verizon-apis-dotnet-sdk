// <copyright file="SourceCodeTypeEnum.cs" company="APIMatic">
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
    /// SourceCodeTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SourceCodeTypeEnum
    {
        /// <summary>
        /// JAVA.
        /// </summary>
        [EnumMember(Value = "JAVA")]
        JAVA,

        /// <summary>
        /// GO.
        /// </summary>
        [EnumMember(Value = "GO")]
        GO
    }
}