// <copyright file="DataCenterDistributionEnum.cs" company="APIMatic">
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
    /// DataCenterDistributionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataCenterDistributionEnum
    {
        /// <summary>
        /// EnumUpstreamKubernetes.
        /// </summary>
        [EnumMember(Value = "Upstream Kubernetes")]
        EnumUpstreamKubernetes,

        /// <summary>
        /// EnumAmazonEKSDistro.
        /// </summary>
        [EnumMember(Value = "Amazon EKS distro")]
        EnumAmazonEKSDistro
    }
}