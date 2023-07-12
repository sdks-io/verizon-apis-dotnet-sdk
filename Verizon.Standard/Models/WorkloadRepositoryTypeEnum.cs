// <copyright file="WorkloadRepositoryTypeEnum.cs" company="APIMatic">
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
    /// WorkloadRepositoryTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkloadRepositoryTypeEnum
    {
        /// <summary>
        /// GIT.
        /// </summary>
        [EnumMember(Value = "GIT")]
        GIT,

        /// <summary>
        /// HELM.
        /// </summary>
        [EnumMember(Value = "HELM")]
        HELM
    }
}