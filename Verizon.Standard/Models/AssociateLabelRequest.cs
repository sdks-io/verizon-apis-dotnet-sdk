// <copyright file="AssociateLabelRequest.cs" company="APIMatic">
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
    /// AssociateLabelRequest.
    /// </summary>
    public class AssociateLabelRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateLabelRequest"/> class.
        /// </summary>
        public AssociateLabelRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociateLabelRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="labels">labels.</param>
        public AssociateLabelRequest(
            string accountName,
            Models.AccountLabels labels)
        {
            this.AccountName = accountName;
            this.Labels = labels;
        }

        /// <summary>
        /// The name of a billing account. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Maximum of 2,000 objects are allowed in the array.
        /// </summary>
        [JsonProperty("labels")]
        public Models.AccountLabels Labels { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociateLabelRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociateLabelRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
        }
    }
}