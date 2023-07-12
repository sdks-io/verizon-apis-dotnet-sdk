// <copyright file="SandBoxStateEnum.cs" company="APIMatic">
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
    /// SandBoxStateEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SandBoxStateEnum
    {
        /// <summary>
        /// NOTSTARTED.
        /// </summary>
        [EnumMember(Value = "NOT_STARTED")]
        NOTSTARTED,

        /// <summary>
        /// STARTED.
        /// </summary>
        [EnumMember(Value = "STARTED")]
        STARTED,

        /// <summary>
        /// STOPPED.
        /// </summary>
        [EnumMember(Value = "STOPPED")]
        STOPPED,

        /// <summary>
        /// PAUSED.
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        PAUSED,

        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        /// <summary>
        /// DELETED.
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED,

        /// <summary>
        /// STOPINPROGRESS.
        /// </summary>
        [EnumMember(Value = "STOP_IN_PROGRESS")]
        STOPINPROGRESS,

        /// <summary>
        /// PAUSEINPROGRESS.
        /// </summary>
        [EnumMember(Value = "PAUSE_IN_PROGRESS")]
        PAUSEINPROGRESS,

        /// <summary>
        /// TESTINPROGRESS.
        /// </summary>
        [EnumMember(Value = "TEST_IN_PROGRESS")]
        TESTINPROGRESS,

        /// <summary>
        /// MARKFORDELETION.
        /// </summary>
        [EnumMember(Value = "MARK_FOR_DELETION")]
        MARKFORDELETION
    }
}