// <copyright file="ProfileStatusFilterEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// ProfileStatusFilterEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProfileStatusFilterEnum
    {
        /// <summary>
        /// ENABLE.
        /// </summary>
        [EnumMember(Value = "ENABLE")]
        ENABLE,

        /// <summary>
        /// DISABLE.
        /// </summary>
        [EnumMember(Value = "DISABLE")]
        DISABLE,

        /// <summary>
        /// DOWNLOADDISABLE.
        /// </summary>
        [EnumMember(Value = "DOWNLOAD_DISABLE")]
        DOWNLOADDISABLE,

        /// <summary>
        /// DOWNLOADENABLE.
        /// </summary>
        [EnumMember(Value = "DOWNLOAD_ENABLE")]
        DOWNLOADENABLE,

        /// <summary>
        /// NOTDOWNLOADED.
        /// </summary>
        [EnumMember(Value = "NOT_DOWNLOADED")]
        NOTDOWNLOADED,

        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// DELETE.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE
    }
}