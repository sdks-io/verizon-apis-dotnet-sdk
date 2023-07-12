// <copyright file="TemplateTypeEnum.cs" company="APIMatic">
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
    /// TemplateTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateTypeEnum
    {
        /// <summary>
        /// Terraform.
        /// </summary>
        [EnumMember(Value = "Terraform")]
        Terraform,

        /// <summary>
        /// Heat.
        /// </summary>
        [EnumMember(Value = "Heat")]
        Heat,

        /// <summary>
        /// CloudFormation.
        /// </summary>
        [EnumMember(Value = "CloudFormation")]
        CloudFormation,

        /// <summary>
        /// TOSCA.
        /// </summary>
        [EnumMember(Value = "TOSCA")]
        TOSCA
    }
}