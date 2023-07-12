// <copyright file="DataBackupProviderEnum.cs" company="APIMatic">
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
    /// DataBackupProviderEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataBackupProviderEnum
    {
        /// <summary>
        /// AWS.
        /// </summary>
        [EnumMember(Value = "AWS")]
        AWS,

        /// <summary>
        /// MINIO.
        /// </summary>
        [EnumMember(Value = "MINIO")]
        MINIO
    }
}