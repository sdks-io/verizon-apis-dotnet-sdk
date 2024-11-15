// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Verizon.Standard
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
        /// MockServerForLimitedAvailabilitySeeQuickStart.
        /// </summary>
        [EnumMember(Value = "Mock server for limited availability, see quick start")]
        MockServerForLimitedAvailabilitySeeQuickStart,
    }
}
