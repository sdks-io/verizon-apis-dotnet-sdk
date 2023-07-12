// <copyright file="EventTypeEnum.cs" company="APIMatic">
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
    /// EventTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventTypeEnum
    {
        /// <summary>
        /// BACKUP.
        /// </summary>
        [EnumMember(Value = "BACKUP")]
        BACKUP,

        /// <summary>
        /// RESTORE.
        /// </summary>
        [EnumMember(Value = "RESTORE")]
        RESTORE,

        /// <summary>
        /// MOVE.
        /// </summary>
        [EnumMember(Value = "MOVE")]
        MOVE,

        /// <summary>
        /// SUSPEND.
        /// </summary>
        [EnumMember(Value = "SUSPEND")]
        SUSPEND,

        /// <summary>
        /// STOP.
        /// </summary>
        [EnumMember(Value = "STOP")]
        STOP,

        /// <summary>
        /// AUTOSCALE.
        /// </summary>
        [EnumMember(Value = "AUTOSCALE")]
        AUTOSCALE,

        /// <summary>
        /// DEPRECATE.
        /// </summary>
        [EnumMember(Value = "DEPRECATE")]
        DEPRECATE
    }
}