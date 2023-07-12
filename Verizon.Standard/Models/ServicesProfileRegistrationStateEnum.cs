// <copyright file="ServicesProfileRegistrationStateEnum.cs" company="APIMatic">
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
    /// ServicesProfileRegistrationStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServicesProfileRegistrationStateEnum
    {
        /// <summary>
        /// DRAFT.
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT,

        /// <summary>
        /// READYTOUSE.
        /// </summary>
        [EnumMember(Value = "READY_TO_USE")]
        READYTOUSE,

        /// <summary>
        /// INUSE.
        /// </summary>
        [EnumMember(Value = "IN_USE")]
        INUSE
    }
}