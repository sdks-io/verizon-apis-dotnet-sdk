// <copyright file="ResponseCodeEnum.cs" company="APIMatic">
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
    /// ResponseCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseCodeEnum
    {
        /// <summary>
        /// INVALIDACCESS.
        /// </summary>
        [EnumMember(Value = "INVALID_ACCESS")]
        INVALIDACCESS,

        /// <summary>
        /// INVALIDPARAMETER.
        /// </summary>
        [EnumMember(Value = "INVALID_PARAMETER")]
        INVALIDPARAMETER,

        /// <summary>
        /// INTERNALERROR.
        /// </summary>
        [EnumMember(Value = "INTERNAL_ERROR")]
        INTERNALERROR,

        /// <summary>
        /// SUCCESS.
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        SUCCESS
    }
}