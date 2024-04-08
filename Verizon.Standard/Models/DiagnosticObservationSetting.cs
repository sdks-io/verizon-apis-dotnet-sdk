// <copyright file="DiagnosticObservationSetting.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Verizon.Standard.Models
{
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

    /// <summary>
    /// DiagnosticObservationSetting.
    /// </summary>
    public class DiagnosticObservationSetting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticObservationSetting"/> class.
        /// </summary>
        public DiagnosticObservationSetting()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticObservationSetting"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="device">device.</param>
        /// <param name="attributes">attributes.</param>
        public DiagnosticObservationSetting(
            string accountName = null,
            Models.Device device = null,
            List<Models.AttributeSetting> attributes = null)
        {
            this.AccountName = accountName;
            this.Device = device;
            this.Attributes = attributes;
        }

        /// <summary>
        /// The name of the billing account for which callback messages will be sent. Format: "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Identifies a particular IoT device.
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Device Device { get; set; }

        /// <summary>
        /// Streaming RF parameters for which you want to retrieve diagnostic settings.
        /// </summary>
        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AttributeSetting> Attributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DiagnosticObservationSetting : ({string.Join(", ", toStringOutput)})";
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
            return obj is DiagnosticObservationSetting other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                ((this.Attributes == null && other.Attributes == null) || (this.Attributes?.Equals(other.Attributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device.ToString())}");
            toStringOutput.Add($"this.Attributes = {(this.Attributes == null ? "null" : $"[{string.Join(", ", this.Attributes)} ]")}");
        }
    }
}