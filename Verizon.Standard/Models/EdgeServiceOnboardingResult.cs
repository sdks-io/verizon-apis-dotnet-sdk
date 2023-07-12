// <copyright file="EdgeServiceOnboardingResult.cs" company="APIMatic">
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
    /// EdgeServiceOnboardingResult.
    /// </summary>
    public class EdgeServiceOnboardingResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceOnboardingResult"/> class.
        /// </summary>
        public EdgeServiceOnboardingResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeServiceOnboardingResult"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        /// <param name="remedyMessage">remedyMessage.</param>
        public EdgeServiceOnboardingResult(
            string code = null,
            string message = null,
            string remedyMessage = null)
        {
            this.Code = code;
            this.Message = message;
            this.RemedyMessage = remedyMessage;
        }

        /// <summary>
        /// Code of the error. eg: SDMS_000_000.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// Brief description of the error in the form of a message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Suggestion on how to fix the issue.
        /// </summary>
        [JsonProperty("remedyMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string RemedyMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EdgeServiceOnboardingResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is EdgeServiceOnboardingResult other &&                ((this.Code == null && other.Code == null) || (this.Code?.Equals(other.Code) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.RemedyMessage == null && other.RemedyMessage == null) || (this.RemedyMessage?.Equals(other.RemedyMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Code = {(this.Code == null ? "null" : this.Code == string.Empty ? "" : this.Code)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
            toStringOutput.Add($"this.RemedyMessage = {(this.RemedyMessage == null ? "null" : this.RemedyMessage == string.Empty ? "" : this.RemedyMessage)}");
        }
    }
}