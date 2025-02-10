// <copyright file="CarrierServicePlan.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Verizon.Standard;
using Verizon.Standard.Utilities;

namespace Verizon.Standard.Models
{
    /// <summary>
    /// CarrierServicePlan.
    /// </summary>
    public class CarrierServicePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicePlan"/> class.
        /// </summary>
        public CarrierServicePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServicePlan"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="sizeKb">sizeKb.</param>
        /// <param name="carrierServicePlanCode">carrierServicePlanCode.</param>
        public CarrierServicePlan(
            string name = null,
            string code = null,
            string sizeKb = null,
            string carrierServicePlanCode = null)
        {
            this.Name = name;
            this.Code = code;
            this.SizeKb = sizeKb;
            this.CarrierServicePlanCode = carrierServicePlanCode;
        }

        /// <summary>
        /// The name of the service plan
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The inventory name or system name of the service plan
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// The ammount of space the service plan will occupy on the Subscriber Information Module (SIM)
        /// </summary>
        [JsonProperty("sizeKb", NullValueHandling = NullValueHandling.Ignore)]
        public string SizeKb { get; set; }

        /// <summary>
        /// The billing record ID. This can be numeric, alpha or alphanumeric.
        /// </summary>
        [JsonProperty("carrierServicePlanCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierServicePlanCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CarrierServicePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CarrierServicePlan other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                (this.SizeKb == null && other.SizeKb == null ||
                 this.SizeKb?.Equals(other.SizeKb) == true) &&
                (this.CarrierServicePlanCode == null && other.CarrierServicePlanCode == null ||
                 this.CarrierServicePlanCode?.Equals(other.CarrierServicePlanCode) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Code = {this.Code ?? "null"}");
            toStringOutput.Add($"SizeKb = {this.SizeKb ?? "null"}");
            toStringOutput.Add($"CarrierServicePlanCode = {this.CarrierServicePlanCode ?? "null"}");
        }
    }
}