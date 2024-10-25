// <copyright file="ProvisioningStatusFilterEnum.cs" company="APIMatic">
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
    /// ProvisioningStatusFilterEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningStatusFilterEnum
    {
        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// DEACTIVATED.
        /// </summary>
        [EnumMember(Value = "DEACTIVATED")]
        DEACTIVATED,

        /// <summary>
        /// ACTIVATED.
        /// </summary>
        [EnumMember(Value = "ACTIVATED")]
        ACTIVATED,

        /// <summary>
        /// DEACTIVE.
        /// </summary>
        [EnumMember(Value = "DEACTIVE")]
        DEACTIVE,

        /// <summary>
        /// ACTIVE.
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        /// <summary>
        /// SUSPEND.
        /// </summary>
        [EnumMember(Value = "SUSPEND")]
        SUSPEND,

        /// <summary>
        /// PENDINGACTIVATION.
        /// </summary>
        [EnumMember(Value = "PENDING_ACTIVATION")]
        PENDINGACTIVATION,

        /// <summary>
        /// PENDINGDEACTIVATION.
        /// </summary>
        [EnumMember(Value = "PENDING_DEACTIVATION")]
        PENDINGDEACTIVATION,

        /// <summary>
        /// PREACTIVE.
        /// </summary>
        [EnumMember(Value = "PRE_ACTIVE")]
        PREACTIVE,

        /// <summary>
        /// ACTIVATIONREADY.
        /// </summary>
        [EnumMember(Value = "ACTIVATION_READY")]
        ACTIVATIONREADY,

        /// <summary>
        /// INVENTORY.
        /// </summary>
        [EnumMember(Value = "INVENTORY")]
        INVENTORY,

        /// <summary>
        /// PURGED.
        /// </summary>
        [EnumMember(Value = "PURGED")]
        PURGED,

        /// <summary>
        /// REPLACED.
        /// </summary>
        [EnumMember(Value = "REPLACED")]
        REPLACED,

        /// <summary>
        /// RETIRED.
        /// </summary>
        [EnumMember(Value = "RETIRED")]
        RETIRED,

        /// <summary>
        /// TESTREADY.
        /// </summary>
        [EnumMember(Value = "TEST_READY")]
        TESTREADY
    }
}