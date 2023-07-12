// <copyright file="DataCenterPackageTypeEnum.cs" company="APIMatic">
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
    /// DataCenterPackageTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataCenterPackageTypeEnum
    {
        /// <summary>
        /// Linux.
        /// </summary>
        [EnumMember(Value = "Linux")]
        Linux,

        /// <summary>
        /// EnumOVAOVF.
        /// </summary>
        [EnumMember(Value = "OVA/OVF")]
        EnumOVAOVF,

        /// <summary>
        /// QCOW2.
        /// </summary>
        [EnumMember(Value = "QCOW2")]
        QCOW2
    }
}