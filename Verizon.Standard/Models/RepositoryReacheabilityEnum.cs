// <copyright file="RepositoryReacheabilityEnum.cs" company="APIMatic">
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
    /// RepositoryReacheabilityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryReacheabilityEnum
    {
        /// <summary>
        /// Internet.
        /// </summary>
        [EnumMember(Value = "Internet")]
        Internet,

        /// <summary>
        /// EnumPrivateNetwork.
        /// </summary>
        [EnumMember(Value = "Private Network")]
        EnumPrivateNetwork
    }
}