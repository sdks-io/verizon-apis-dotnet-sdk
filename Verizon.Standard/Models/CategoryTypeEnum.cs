// <copyright file="CategoryTypeEnum.cs" company="APIMatic">
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
    /// CategoryTypeEnum.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryTypeEnum
    {
        /// <summary>
        /// GENERALVALIDATION.
        /// </summary>
        [EnumMember(Value = "GENERAL_VALIDATION")]
        GENERALVALIDATION,

        /// <summary>
        /// OBSERVABILITYTEMPLATE.
        /// </summary>
        [EnumMember(Value = "OBSERVABILITY_TEMPLATE")]
        OBSERVABILITYTEMPLATE,

        /// <summary>
        /// SWAGGERSPEC.
        /// </summary>
        [EnumMember(Value = "SWAGGER_SPEC")]
        SWAGGERSPEC,

        /// <summary>
        /// DEPENDENTSERVICEVALUES.
        /// </summary>
        [EnumMember(Value = "DEPENDENT_SERVICE_VALUES")]
        DEPENDENTSERVICEVALUES,

        /// <summary>
        /// WORKLOADTGZ.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_TGZ")]
        WORKLOADTGZ,

        /// <summary>
        /// WORKLOADVALUE.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_VALUE")]
        WORKLOADVALUE,

        /// <summary>
        /// WORKLOADYAML.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_YAML")]
        WORKLOADYAML,

        /// <summary>
        /// WORKLOADTERRAFORMZIP.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_TERRAFORM_ZIP")]
        WORKLOADTERRAFORMZIP,

        /// <summary>
        /// WORKLOADTERRAFORMTF.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_TERRAFORM_TF")]
        WORKLOADTERRAFORMTF,

        /// <summary>
        /// WORKLOADTERRAFORMTFVAR.
        /// </summary>
        [EnumMember(Value = "WORKLOAD_TERRAFORM_TFVAR")]
        WORKLOADTERRAFORMTFVAR,

        /// <summary>
        /// WORKFLOWSOURCEFILE.
        /// </summary>
        [EnumMember(Value = "WORKFLOW_SOURCE_FILE")]
        WORKFLOWSOURCEFILE,

        /// <summary>
        /// WORKFLOWINPUTSCHEMA.
        /// </summary>
        [EnumMember(Value = "WORKFLOW_INPUT_SCHEMA")]
        WORKFLOWINPUTSCHEMA,

        /// <summary>
        /// WORKFLOWTGZ.
        /// </summary>
        [EnumMember(Value = "WORKFLOW_TGZ")]
        WORKFLOWTGZ
    }
}