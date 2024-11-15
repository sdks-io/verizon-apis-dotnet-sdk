// <copyright file="Triggervalues2.cs" company="APIMatic">
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
    /// Triggervalues2.
    /// </summary>
    public class Triggervalues2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Triggervalues2"/> class.
        /// </summary>
        public Triggervalues2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triggervalues2"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="triggerCategory">triggerCategory.</param>
        /// <param name="promoAlerts">promoAlerts.</param>
        /// <param name="active">active.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="modifiedAt">modifiedAt.</param>
        public Triggervalues2(
            string triggerId = null,
            string triggerName = null,
            string accountName = null,
            string organizationName = null,
            string triggerCategory = null,
            List<Models.PromoAlert> promoAlerts = null,
            bool? active = null,
            DateTime? createdAt = null,
            DateTime? modifiedAt = null)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.OrganizationName = organizationName;
            this.TriggerCategory = triggerCategory;
            this.PromoAlerts = promoAlerts;
            this.Active = active;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Gets or sets TriggerId.
        /// </summary>
        [JsonProperty("triggerId", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerId { get; set; }

        /// <summary>
        /// Gets or sets TriggerName.
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets OrganizationName.
        /// </summary>
        [JsonProperty("organizationName", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets TriggerCategory.
        /// </summary>
        [JsonProperty("triggerCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerCategory { get; set; }

        /// <summary>
        /// Gets or sets PromoAlerts.
        /// </summary>
        [JsonProperty("promoAlerts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PromoAlert> PromoAlerts { get; set; }

        /// <summary>
        /// Gets or sets Active.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("modifiedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ModifiedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Triggervalues2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Triggervalues2 other &&                ((this.TriggerId == null && other.TriggerId == null) || (this.TriggerId?.Equals(other.TriggerId) == true)) &&
                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.OrganizationName == null && other.OrganizationName == null) || (this.OrganizationName?.Equals(other.OrganizationName) == true)) &&
                ((this.TriggerCategory == null && other.TriggerCategory == null) || (this.TriggerCategory?.Equals(other.TriggerCategory) == true)) &&
                ((this.PromoAlerts == null && other.PromoAlerts == null) || (this.PromoAlerts?.Equals(other.PromoAlerts) == true)) &&
                ((this.Active == null && other.Active == null) || (this.Active?.Equals(other.Active) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TriggerId = {(this.TriggerId == null ? "null" : this.TriggerId)}");
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.OrganizationName = {(this.OrganizationName == null ? "null" : this.OrganizationName)}");
            toStringOutput.Add($"this.TriggerCategory = {(this.TriggerCategory == null ? "null" : this.TriggerCategory)}");
            toStringOutput.Add($"this.PromoAlerts = {(this.PromoAlerts == null ? "null" : $"[{string.Join(", ", this.PromoAlerts)} ]")}");
            toStringOutput.Add($"this.Active = {(this.Active == null ? "null" : this.Active.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt.ToString())}");
        }
    }
}