// <copyright file="ErrorResponseCodeEnum.cs" company="APIMatic">
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
    /// ErrorResponseCodeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ErrorResponseCodeEnum
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