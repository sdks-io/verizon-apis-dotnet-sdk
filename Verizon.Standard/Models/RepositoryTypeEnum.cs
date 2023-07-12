// <copyright file="RepositoryTypeEnum.cs" company="APIMatic">
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
    /// RepositoryTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryTypeEnum
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