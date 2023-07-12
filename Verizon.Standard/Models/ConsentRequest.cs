// <copyright file="ConsentRequest.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// ConsentRequest.
    /// </summary>
    public class ConsentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequest"/> class.
        /// </summary>
        public ConsentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="allDevice">allDevice.</param>
        /// <param name="type">type.</param>
        /// <param name="exclusion">exclusion.</param>
        public ConsentRequest(
            string accountName = null,
            bool? allDevice = null,
            string type = null,
            List<string> exclusion = null)
        {
            this.AccountName = accountName;
            this.AllDevice = allDevice;
            this.Type = type;
            this.Exclusion = exclusion;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Exclude all devices or not.
        /// </summary>
        [JsonProperty("allDevice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllDevice { get; set; }

        /// <summary>
        /// The change to make: append or replace.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// Device ID list.
        /// </summary>
        [JsonProperty("exclusion", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Exclusion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConsentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConsentRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AllDevice == null && other.AllDevice == null) || (this.AllDevice?.Equals(other.AllDevice) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Exclusion == null && other.Exclusion == null) || (this.Exclusion?.Equals(other.Exclusion) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.AllDevice = {(this.AllDevice == null ? "null" : this.AllDevice.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type == string.Empty ? "" : this.Type)}");
            toStringOutput.Add($"this.Exclusion = {(this.Exclusion == null ? "null" : $"[{string.Join(", ", this.Exclusion)} ]")}");
        }
    }
}