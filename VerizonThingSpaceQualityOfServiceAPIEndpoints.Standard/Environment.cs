// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VerizonThingSpaceQualityOfServiceAPIEndpoints.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "Production")]
        Production,

        /// <summary>
        /// Staging.
        /// </summary>
        [EnumMember(Value = "Staging")]
        Staging,
    }
}
