// <copyright file="AccountLead.cs" company="APIMatic">
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
    /// AccountLead.
    /// </summary>
    public class AccountLead
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLead"/> class.
        /// </summary>
        public AccountLead()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLead"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="leadId">leadId.</param>
        /// <param name="leadState">leadState.</param>
        public AccountLead(
            Models.Address address = null,
            string leadId = null,
            string leadState = null)
        {
            this.Address = address;
            this.LeadId = leadId;
            this.LeadState = leadState;
        }

        /// <summary>
        /// The customer address for the line's primary place of use, for line usage taxation.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address Address { get; set; }

        /// <summary>
        /// Unique number for each lead. Use this value in the leadId parameter when activating devices to credit the activations to the lead.
        /// </summary>
        [JsonProperty("leadId", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadId { get; set; }

        /// <summary>
        /// The current state of the lead, such as “Qualified” or “Closed.”
        /// </summary>
        [JsonProperty("leadState", NullValueHandling = NullValueHandling.Ignore)]
        public string LeadState { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLead : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLead other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.LeadId == null && other.LeadId == null) || (this.LeadId?.Equals(other.LeadId) == true)) &&
                ((this.LeadState == null && other.LeadState == null) || (this.LeadState?.Equals(other.LeadState) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.LeadId = {(this.LeadId == null ? "null" : this.LeadId == string.Empty ? "" : this.LeadId)}");
            toStringOutput.Add($"this.LeadState = {(this.LeadState == null ? "null" : this.LeadState == string.Empty ? "" : this.LeadState)}");
        }
    }
}