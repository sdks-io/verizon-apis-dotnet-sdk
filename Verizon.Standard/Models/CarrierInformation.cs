// <copyright file="CarrierInformation.cs" company="APIMatic">
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
    /// CarrierInformation.
    /// </summary>
    public class CarrierInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierInformation"/> class.
        /// </summary>
        public CarrierInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierInformation"/> class.
        /// </summary>
        /// <param name="carrierName">carrierName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="state">state.</param>
        public CarrierInformation(
            string carrierName = null,
            string servicePlan = null,
            string state = null)
        {
            this.CarrierName = carrierName;
            this.ServicePlan = servicePlan;
            this.State = state;
        }

        /// <summary>
        /// The carrier that will perform the activation. This parameter is only required if you have more than one carrier.
        /// </summary>
        [JsonProperty("carrierName", NullValueHandling = NullValueHandling.Ignore)]
        public string CarrierName { get; set; }

        /// <summary>
        /// The service plan code that is assigned to the device.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// The device state. Valid values include: Activate, Suspend, Deactive, Pre-active.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CarrierInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is CarrierInformation other &&                ((this.CarrierName == null && other.CarrierName == null) || (this.CarrierName?.Equals(other.CarrierName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CarrierName = {(this.CarrierName == null ? "null" : this.CarrierName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
        }
    }
}