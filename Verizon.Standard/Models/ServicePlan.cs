// <copyright file="ServicePlan.cs" company="APIMatic">
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
    /// ServicePlan.
    /// </summary>
    public class ServicePlan
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlan"/> class.
        /// </summary>
        public ServicePlan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlan"/> class.
        /// </summary>
        /// <param name="carrierServicePlanCode">carrierServicePlanCode.</param>
        /// <param name="code">code.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="name">name.</param>
        /// <param name="sizeKb">sizeKb.</param>
        public ServicePlan(
            string carrierServicePlanCode = null,
            string code = null,
            List<Models.CustomFields> extendedAttributes = null,
            string name = null,
            long? sizeKb = null)
        {
            this.CarrierServicePlanCode = carrierServicePlanCode;
            this.Code = code;
            this.ExtendedAttributes = extendedAttributes;
            this.Name = name;
            this.SizeKb = sizeKb;
        }

        /// <summary>
        /// The code that is used by the carrier for the service plan.
        /// </summary>
        [JsonProperty("carrierServicePlanCode", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierServicePlanCode { get; set; }

        /// <summary>
        /// The code of the service plan, which may not be the same as the name.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Any extended attributes for the service plan, as Key and Value pairs.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <summary>
        /// The name of the service plan.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The size of the service plan in kilobytes.
        /// </summary>
        [JsonProperty("sizeKb", NullValueHandling = NullValueHandling.Ignore)]
        public long? SizeKb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServicePlan : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ServicePlan other &&                ((this.CarrierServicePlanCode == null && other.CarrierServicePlanCode == null) || (this.CarrierServicePlanCode?.Equals(other.CarrierServicePlanCode) == true)) &&
                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.SizeKb == null && other.SizeKb == null) || (this.SizeKb?.Equals(other.SizeKb) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CarrierServicePlanCode = {(this.CarrierServicePlanCode == null ? "null" : this.CarrierServicePlanCode)}");
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code)}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.SizeKb = {(this.SizeKb == null ? "null" : this.SizeKb.ToString())}");
        }
    }
}