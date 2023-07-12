// <copyright file="RepositoryCredentialTypeEnum.cs" company="APIMatic">
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
    /// RepositoryCredentialTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RepositoryCredentialTypeEnum
    {
        /// <summary>
        /// UserPassCredentials.
        /// </summary>
        [EnumMember(Value = "UserPassCredentials")]
        UserPassCredentials,

        /// <summary>
        /// SSHCredentials.
        /// </summary>
        [EnumMember(Value = "SSHCredentials")]
        SSHCredentials
    }
}