// <copyright file="CloudDestributionEnum.cs" company="APIMatic">
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
    /// CloudDestributionEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CloudDestributionEnum
    {
        /// <summary>
        /// AmazonEKS.
        /// </summary>
        [EnumMember(Value = "AmazonEKS")]
        AmazonEKS,

        /// <summary>
        /// EnumUpstreamKubernetes.
        /// </summary>
        [EnumMember(Value = "Upstream Kubernetes")]
        EnumUpstreamKubernetes,

        /// <summary>
        /// EnumAzureAKS.
        /// </summary>
        [EnumMember(Value = "Azure AKS")]
        EnumAzureAKS,

        /// <summary>
        /// EnumAmazonEKSDistro.
        /// </summary>
        [EnumMember(Value = "Amazon EKS distro")]
        EnumAmazonEKSDistro,

        /// <summary>
        /// EnumGCPGKE.
        /// </summary>
        [EnumMember(Value = "GCP GKE")]
        EnumGCPGKE
    }
}