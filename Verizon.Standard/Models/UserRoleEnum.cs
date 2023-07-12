// <copyright file="UserRoleEnum.cs" company="APIMatic">
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
    /// UserRoleEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserRoleEnum
    {
        /// <summary>
        /// ADMIN.
        /// </summary>
        [EnumMember(Value = "ADMIN")]
        ADMIN,

        /// <summary>
        /// USER.
        /// </summary>
        [EnumMember(Value = "USER")]
        USER,

        /// <summary>
        /// ORGADMIN.
        /// </summary>
        [EnumMember(Value = "ORGADMIN")]
        ORGADMIN
    }
}