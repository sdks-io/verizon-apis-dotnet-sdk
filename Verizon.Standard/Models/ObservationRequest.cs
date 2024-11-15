// <copyright file="ObservationRequest.cs" company="APIMatic">
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
    /// ObservationRequest.
    /// </summary>
    public class ObservationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationRequest"/> class.
        /// </summary>
        public ObservationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devices">devices.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="duration">duration.</param>
        public ObservationRequest(
            string accountName,
            List<Models.Device> devices,
            List<Models.ObservationRequestAttribute> attributes,
            Models.NumericalData frequency = null,
            Models.NumericalData duration = null)
        {
            this.AccountName = accountName;
            this.Devices = devices;
            this.Attributes = attributes;
            this.Frequency = frequency;
            this.Duration = duration;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// List of devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Models.Device> Devices { get; set; }

        /// <summary>
        /// Attributes are streaming RF parameters that you want to observe.
        /// </summary>
        [JsonProperty("attributes")]
        public List<Models.ObservationRequestAttribute> Attributes { get; set; }

        /// <summary>
        /// Describes value and unit of time.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalData Frequency { get; set; }

        /// <summary>
        /// Describes value and unit of time.
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalData Duration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ObservationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ObservationRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Devices == null && other.Devices == null) || (this.Devices?.Equals(other.Devices) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                ((this.Duration == null && other.Duration == null) || (this.Duration?.Equals(other.Duration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Devices = {(this.Devices == null ? "null" : $"[{string.Join(", ", this.Devices)} ]")}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : $"[{string.Join(", ", this.Attributes)} ]")}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");
            toStringOutput.Add($"this.Duration = {(this.Duration == null ? "null" : this.Duration.ToString())}");
        }
    }
}