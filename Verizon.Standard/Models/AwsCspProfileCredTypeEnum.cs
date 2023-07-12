// <copyright file="AwsCspProfileCredTypeEnum.cs" company="APIMatic">
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
    /// AwsCspProfileCredTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AwsCspProfileCredTypeEnum
    {
        /// <summary>
        /// ACCESSKEY.
        /// </summary>
        [EnumMember(Value = "ACCESS_KEY")]
        ACCESSKEY,

        /// <summary>
        /// ROLEARN.
        /// </summary>
        [EnumMember(Value = "ROLE_ARN")]
        ROLEARN
    }
}