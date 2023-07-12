// <copyright file="ClusterTypeEnum.cs" company="APIMatic">
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
    /// ClusterTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClusterTypeEnum
    {
        /// <summary>
        /// PublicCloud.
        /// </summary>
        [EnumMember(Value = "publicCloud")]
        PublicCloud,

        /// <summary>
        /// DataCenter.
        /// </summary>
        [EnumMember(Value = "dataCenter")]
        DataCenter
    }
}