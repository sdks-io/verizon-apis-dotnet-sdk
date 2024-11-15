// <copyright file="CampaignStatusEnum.cs" company="APIMatic">
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
    /// CampaignStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignStatusEnum
    {
        /// <summary>
        /// CampaignRequestPending.
        /// </summary>
        [EnumMember(Value = "CampaignRequestPending")]
        CampaignRequestPending,

        /// <summary>
        /// CampaignRequestFailed.
        /// </summary>
        [EnumMember(Value = "CampaignRequestFailed")]
        CampaignRequestFailed,

        /// <summary>
        /// CampaignRequestQueued.
        /// </summary>
        [EnumMember(Value = "CampaignRequestQueued")]
        CampaignRequestQueued,

        /// <summary>
        /// CampaignCancelled.
        /// </summary>
        [EnumMember(Value = "CampaignCancelled")]
        CampaignCancelled,

        /// <summary>
        /// CampaignAborted.
        /// </summary>
        [EnumMember(Value = "CampaignAborted")]
        CampaignAborted,

        /// <summary>
        /// CampaignFailed.
        /// </summary>
        [EnumMember(Value = "CampaignFailed")]
        CampaignFailed,

        /// <summary>
        /// CampaignScheduled.
        /// </summary>
        [EnumMember(Value = "CampaignScheduled")]
        CampaignScheduled,

        /// <summary>
        /// CampaignEnded.
        /// </summary>
        [EnumMember(Value = "CampaignEnded")]
        CampaignEnded
    }
}