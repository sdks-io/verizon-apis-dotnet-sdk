// <copyright file="CSPCompatibilityEnum.cs" company="APIMatic">
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
    /// CSPCompatibilityEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CSPCompatibilityEnum
    {
        /// <summary>
        /// AWSPUBLICCLOUD.
        /// </summary>
        [EnumMember(Value = "AWS_PUBLIC_CLOUD")]
        AWSPUBLICCLOUD,

        /// <summary>
        /// AWSWL.
        /// </summary>
        [EnumMember(Value = "AWS_WL")]
        AWSWL,

        /// <summary>
        /// AWSOUTPOST.
        /// </summary>
        [EnumMember(Value = "AWS_OUTPOST")]
        AWSOUTPOST,

        /// <summary>
        /// AZUREPUBLICCLOUD.
        /// </summary>
        [EnumMember(Value = "AZURE_PUBLIC_CLOUD")]
        AZUREPUBLICCLOUD,

        /// <summary>
        /// AZUREEDGE.
        /// </summary>
        [EnumMember(Value = "AZURE_EDGE")]
        AZUREEDGE
    }
}