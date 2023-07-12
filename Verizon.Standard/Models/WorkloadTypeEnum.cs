// <copyright file="WorkloadTypeEnum.cs" company="APIMatic">
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
    /// WorkloadTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WorkloadTypeEnum
    {
        /// <summary>
        /// Container.
        /// </summary>
        [EnumMember(Value = "container")]
        Container,

        /// <summary>
        /// VirtualMachine.
        /// </summary>
        [EnumMember(Value = "virtualMachine")]
        VirtualMachine
    }
}