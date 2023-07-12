// <copyright file="ClusterConfigEndpointAccessTypeEnum.cs" company="APIMatic">
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
    /// ClusterConfigEndpointAccessTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClusterConfigEndpointAccessTypeEnum
    {
        /// <summary>
        /// PrivateAccess.
        /// </summary>
        [EnumMember(Value = "privateAccess")]
        PrivateAccess,

        /// <summary>
        /// PrivatePublicAccess.
        /// </summary>
        [EnumMember(Value = "privatePublicAccess")]
        PrivatePublicAccess,

        /// <summary>
        /// PublicAccess.
        /// </summary>
        [EnumMember(Value = "publicAccess")]
        PublicAccess
    }
}