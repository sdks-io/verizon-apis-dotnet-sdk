// <copyright file="EndPointAccessTypeEnum.cs" company="APIMatic">
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
    /// EndPointAccessTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EndPointAccessTypeEnum
    {
        /// <summary>
        /// Private.
        /// </summary>
        [EnumMember(Value = "private")]
        Private,

        /// <summary>
        /// Public.
        /// </summary>
        [EnumMember(Value = "public")]
        Public,

        /// <summary>
        /// PrivateAndPublic.
        /// </summary>
        [EnumMember(Value = "private_and_public")]
        PrivateAndPublic
    }
}