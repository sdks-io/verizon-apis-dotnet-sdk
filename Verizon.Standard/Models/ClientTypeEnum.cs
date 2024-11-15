// <copyright file="ClientTypeEnum.cs" company="APIMatic">
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
    /// ClientTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientTypeEnum
    {
        /// <summary>
        /// V2X.
        /// </summary>
        [EnumMember(Value = "V2X")]
        V2X,

        /// <summary>
        /// ComputerVision.
        /// </summary>
        [EnumMember(Value = "ComputerVision")]
        ComputerVision,

        /// <summary>
        /// MachineLearning.
        /// </summary>
        [EnumMember(Value = "MachineLearning")]
        MachineLearning,

        /// <summary>
        /// IoT.
        /// </summary>
        [EnumMember(Value = "IoT")]
        IoT,

        /// <summary>
        /// Gaming.
        /// </summary>
        [EnumMember(Value = "Gaming")]
        Gaming,

        /// <summary>
        /// AR.
        /// </summary>
        [EnumMember(Value = "AR")]
        AR,

        /// <summary>
        /// VR.
        /// </summary>
        [EnumMember(Value = "VR")]
        VR,

        /// <summary>
        /// Analytics.
        /// </summary>
        [EnumMember(Value = "Analytics")]
        Analytics,

        /// <summary>
        /// Robotics.
        /// </summary>
        [EnumMember(Value = "Robotics")]
        Robotics
    }
}