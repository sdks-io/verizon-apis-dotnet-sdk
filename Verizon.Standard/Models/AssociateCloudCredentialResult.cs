// <copyright file="AssociateCloudCredentialResult.cs" company="APIMatic">
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
    /// AssociateCloudCredentialResult.
    /// </summary>
    public class AssociateCloudCredentialResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateCloudCredentialResult"/> class.
        /// </summary>
        public AssociateCloudCredentialResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateCloudCredentialResult"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        public AssociateCloudCredentialResult(
            string message = null)
        {
            this.Message = message;
        }

        /// <summary>
        /// Brief description of the response in the form of a message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociateCloudCredentialResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociateCloudCredentialResult other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
        }
    }
}