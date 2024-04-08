// <copyright file="Engagement.cs" company="APIMatic">
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
    /// Engagement.
    /// </summary>
    public class Engagement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Engagement"/> class.
        /// </summary>
        public Engagement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Engagement"/> class.
        /// </summary>
        /// <param name="engagementId">engagementId.</param>
        /// <param name="chargingGroup">chargingGroup.</param>
        /// <param name="services">services.</param>
        public Engagement(
            string engagementId = null,
            string chargingGroup = null,
            List<Models.AccountService> services = null)
        {
            this.EngagementId = engagementId;
            this.ChargingGroup = chargingGroup;
            this.Services = services;
        }

        /// <summary>
        /// The engagement ID.
        /// </summary>
        [JsonProperty("engagementId", NullValueHandling = NullValueHandling.Ignore)]
        public string EngagementId { get; set; }

        /// <summary>
        /// The charging group name.
        /// </summary>
        [JsonProperty("chargingGroup", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargingGroup { get; set; }

        /// <summary>
        /// The services associated with the account.
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountService> Services { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Engagement : ({string.Join(", ", toStringOutput)})";
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
            return obj is Engagement other &&                ((this.EngagementId == null && other.EngagementId == null) || (this.EngagementId?.Equals(other.EngagementId) == true)) &&
                ((this.ChargingGroup == null && other.ChargingGroup == null) || (this.ChargingGroup?.Equals(other.ChargingGroup) == true)) &&
                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EngagementId = {(this.EngagementId == null ? "null" : this.EngagementId)}");
            toStringOutput.Add($"this.ChargingGroup = {(this.ChargingGroup == null ? "null" : this.ChargingGroup)}");
            toStringOutput.Add($"this.Services = {(this.Services == null ? "null" : $"[{string.Join(", ", this.Services)} ]")}");
        }
    }
}