// <copyright file="EdgeServiceRepositoryTypeEnum.cs" company="APIMatic">
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
    /// EdgeServiceRepositoryTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EdgeServiceRepositoryTypeEnum
    {
        /// <summary>
        /// Git.
        /// </summary>
        [EnumMember(Value = "Git")]
        Git,

        /// <summary>
        /// Helm.
        /// </summary>
        [EnumMember(Value = "Helm")]
        Helm
    }
}