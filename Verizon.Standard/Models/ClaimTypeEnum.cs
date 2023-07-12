// <copyright file="ClaimTypeEnum.cs" company="APIMatic">
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
    /// ClaimTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClaimTypeEnum
    {
        /// <summary>
        /// PUBLICMEC.
        /// </summary>
        [EnumMember(Value = "PUBLIC_MEC")]
        PUBLICMEC,

        /// <summary>
        /// PRIVATEMEC.
        /// </summary>
        [EnumMember(Value = "PRIVATE_MEC")]
        PRIVATEMEC
    }
}