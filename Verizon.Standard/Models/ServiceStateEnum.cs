// <copyright file="ServiceStateEnum.cs" company="APIMatic">
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
    /// ServiceStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceStateEnum
    {
        /// <summary>
        /// DRAFT.
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        /// <summary>
        /// DESIGN.
        /// </summary>
        [EnumMember(Value = "DESIGN")]
        DESIGN,

        /// <summary>
        /// TESTING.
        /// </summary>
        [EnumMember(Value = "TESTING")]
        TESTING,

        /// <summary>
        /// PUBLISH.
        /// </summary>
        [EnumMember(Value = "PUBLISH")]
        PUBLISH,

        /// <summary>
        /// CERTIFY.
        /// </summary>
        [EnumMember(Value = "CERTIFY")]
        CERTIFY,

        /// <summary>
        /// READYTOUSE.
        /// </summary>
        [EnumMember(Value = "READY_TO_USE")]
        READYTOUSE,

        /// <summary>
        /// DEPRECATE.
        /// </summary>
        [EnumMember(Value = "DEPRECATE")]
        DEPRECATE,

        /// <summary>
        /// DELETED.
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED
    }
}