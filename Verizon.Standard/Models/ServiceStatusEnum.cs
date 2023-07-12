// <copyright file="ServiceStatusEnum.cs" company="APIMatic">
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
    /// ServiceStatusEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceStatusEnum
    {
        /// <summary>
        /// DRAFTINPROGRESS.
        /// </summary>
        [EnumMember(Value = "DRAFT_INPROGRESS")]
        DRAFTINPROGRESS,

        /// <summary>
        /// DRAFTCOMPLETE.
        /// </summary>
        [EnumMember(Value = "DRAFT_COMPLETE")]
        DRAFTCOMPLETE,

        /// <summary>
        /// DESIGNINPROGRESS.
        /// </summary>
        [EnumMember(Value = "DESIGN_INPROGRESS")]
        DESIGNINPROGRESS,

        /// <summary>
        /// DESIGNFAILED.
        /// </summary>
        [EnumMember(Value = "DESIGN_FAILED")]
        DESIGNFAILED,

        /// <summary>
        /// DESIGNCOMPLETED.
        /// </summary>
        [EnumMember(Value = "DESIGN_COMPLETED")]
        DESIGNCOMPLETED,

        /// <summary>
        /// VALIDATIONINPROGRESS.
        /// </summary>
        [EnumMember(Value = "VALIDATION_INPROGRESS")]
        VALIDATIONINPROGRESS,

        /// <summary>
        /// VALIDATIONFAILED.
        /// </summary>
        [EnumMember(Value = "VALIDATION_FAILED")]
        VALIDATIONFAILED,

        /// <summary>
        /// VALIDATIONCOMPLETED.
        /// </summary>
        [EnumMember(Value = "VALIDATION_COMPLETED")]
        VALIDATIONCOMPLETED,

        /// <summary>
        /// TESTINGINPROGRESS.
        /// </summary>
        [EnumMember(Value = "TESTING_INPROGRESS")]
        TESTINGINPROGRESS,

        /// <summary>
        /// TESTINGFAILED.
        /// </summary>
        [EnumMember(Value = "TESTING_FAILED")]
        TESTINGFAILED,

        /// <summary>
        /// TESTINGCOMPLETED.
        /// </summary>
        [EnumMember(Value = "TESTING_COMPLETED")]
        TESTINGCOMPLETED,

        /// <summary>
        /// READYTOUSEINPROGRESS.
        /// </summary>
        [EnumMember(Value = "READY_TO_USE_INPROGRESS")]
        READYTOUSEINPROGRESS,

        /// <summary>
        /// READYTOUSEFAILED.
        /// </summary>
        [EnumMember(Value = "READY_TO_USE_FAILED")]
        READYTOUSEFAILED,

        /// <summary>
        /// READYTOUSECOMPLETED.
        /// </summary>
        [EnumMember(Value = "READY_TO_USE_COMPLETED")]
        READYTOUSECOMPLETED,

        /// <summary>
        /// READYTOPRIVATEUSEINPROGRESS.
        /// </summary>
        [EnumMember(Value = "READY_TO_PRIVATE_USE_INPROGRESS")]
        READYTOPRIVATEUSEINPROGRESS,

        /// <summary>
        /// READYTOPRIVATEUSEFAILED.
        /// </summary>
        [EnumMember(Value = "READY_TO_PRIVATE_USE_FAILED")]
        READYTOPRIVATEUSEFAILED,

        /// <summary>
        /// READYTOPRIVATEUSECOMPLETED.
        /// </summary>
        [EnumMember(Value = "READY_TO_PRIVATE_USE_COMPLETED")]
        READYTOPRIVATEUSECOMPLETED,

        /// <summary>
        /// PUBLISHINPROGRESS.
        /// </summary>
        [EnumMember(Value = "PUBLISH_INPROGRESS")]
        PUBLISHINPROGRESS,

        /// <summary>
        /// PUBLISHFAILED.
        /// </summary>
        [EnumMember(Value = "PUBLISH_FAILED")]
        PUBLISHFAILED,

        /// <summary>
        /// PUBLISHCOMPLETED.
        /// </summary>
        [EnumMember(Value = "PUBLISH_COMPLETED")]
        PUBLISHCOMPLETED,

        /// <summary>
        /// CERTIFYINPROGRESS.
        /// </summary>
        [EnumMember(Value = "CERTIFY_INPROGRESS")]
        CERTIFYINPROGRESS,

        /// <summary>
        /// CERTIFYFAILED.
        /// </summary>
        [EnumMember(Value = "CERTIFY_FAILED")]
        CERTIFYFAILED,

        /// <summary>
        /// CERTIFYCOMPLETED.
        /// </summary>
        [EnumMember(Value = "CERTIFY_COMPLETED")]
        CERTIFYCOMPLETED,

        /// <summary>
        /// DEPRECATEINPROGRESS.
        /// </summary>
        [EnumMember(Value = "DEPRECATE_INPROGRESS")]
        DEPRECATEINPROGRESS,

        /// <summary>
        /// DEPRECATEFAILED.
        /// </summary>
        [EnumMember(Value = "DEPRECATE_FAILED")]
        DEPRECATEFAILED,

        /// <summary>
        /// DEPRECATECOMPLETED.
        /// </summary>
        [EnumMember(Value = "DEPRECATE_COMPLETED")]
        DEPRECATECOMPLETED,

        /// <summary>
        /// MARKDELETEINPROGRESS.
        /// </summary>
        [EnumMember(Value = "MARKDELETE_INPROGRESS")]
        MARKDELETEINPROGRESS,

        /// <summary>
        /// MARKDELETEFAILED.
        /// </summary>
        [EnumMember(Value = "MARKDELETE_FAILED")]
        MARKDELETEFAILED,

        /// <summary>
        /// MARKDELETECOMPLETED.
        /// </summary>
        [EnumMember(Value = "MARKDELETE_COMPLETED")]
        MARKDELETECOMPLETED
    }
}