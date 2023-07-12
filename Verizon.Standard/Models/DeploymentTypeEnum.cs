// <copyright file="DeploymentTypeEnum.cs" company="APIMatic">
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
    /// DeploymentTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentTypeEnum
    {
        /// <summary>
        /// PublicMEC.
        /// </summary>
        [EnumMember(Value = "PublicMEC")]
        PublicMEC,

        /// <summary>
        /// PrivateMEC.
        /// </summary>
        [EnumMember(Value = "PrivateMEC")]
        PrivateMEC,

        /// <summary>
        /// OnPremiseMEC.
        /// </summary>
        [EnumMember(Value = "OnPremiseMEC")]
        OnPremiseMEC
    }
}