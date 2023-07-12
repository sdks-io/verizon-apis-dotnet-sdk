// <copyright file="EdgeServiceOnboardingDeleteResult.cs" company="APIMatic">
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
    /// EdgeServiceOnboardingDeleteResult.
    /// </summary>
    public class EdgeServiceOnboardingDeleteResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceOnboardingDeleteResult"/> class.
        /// </summary>
        public EdgeServiceOnboardingDeleteResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceOnboardingDeleteResult"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="status">status.</param>
        /// <param name="subStatus">subStatus.</param>
        public EdgeServiceOnboardingDeleteResult(
            string message = null,
            string status = null,
            string subStatus = null)
        {
            this.Message = message;
            this.Status = status;
            this.SubStatus = subStatus;
        }

        /// <summary>
        /// Message confirms if the action was success or failure.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Will provide the current status of the action.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Displays the proper response with status.
        /// </summary>
        [JsonProperty("subStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string SubStatus { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EdgeServiceOnboardingDeleteResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is EdgeServiceOnboardingDeleteResult other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.SubStatus == null && other.SubStatus == null) || (this.SubStatus?.Equals(other.SubStatus) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.SubStatus = {(this.SubStatus == null ? "null" : this.SubStatus == string.Empty ? "" : this.SubStatus)}");
        }
    }
}