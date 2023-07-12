// <copyright file="CloudProviderEnum.cs" company="APIMatic">
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
    /// CloudProviderEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CloudProviderEnum
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
        AZURE,

        /// <summary>
        /// GCP.
        /// </summary>
        [EnumMember(Value = "GCP")]
        GCP
    }
}