// <copyright file="RepositoryResTypeEnum.cs" company="APIMatic">
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
    /// RepositoryResTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryResTypeEnum
    {
        /// <summary>
        /// Git.
        /// </summary>
        [EnumMember(Value = "Git")]
        Git,

        /// <summary>
        /// Helm.
        /// </summary>
        [EnumMember(Value = "Helm")]
        Helm,

        /// <summary>
        /// UserUpload.
        /// </summary>
        [EnumMember(Value = "userUpload")]
        UserUpload
    }
}