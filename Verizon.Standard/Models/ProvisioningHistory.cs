// <copyright file="ProvisioningHistory.cs" company="APIMatic">
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
    /// ProvisioningHistory.
    /// </summary>
    public class ProvisioningHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningHistory"/> class.
        /// </summary>
        public ProvisioningHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProvisioningHistory"/> class.
        /// </summary>
        /// <param name="occurredAt">occurredAt.</param>
        /// <param name="status">status.</param>
        /// <param name="eventBy">eventBy.</param>
        /// <param name="eventType">eventType.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="msisdn">msisdn.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        public ProvisioningHistory(
            string occurredAt = null,
            string status = null,
            string eventBy = null,
            string eventType = null,
            string mdn = null,
            string msisdn = null,
            string servicePlan = null,
            List<Models.CustomFields> extendedAttributes = null)
        {
            this.OccurredAt = occurredAt;
            this.Status = status;
            this.EventBy = eventBy;
            this.EventType = eventType;
            this.Mdn = mdn;
            this.Msisdn = msisdn;
            this.ServicePlan = servicePlan;
            this.ExtendedAttributes = extendedAttributes;
        }

        /// <summary>
        /// The date and time when the provisioning event occured.
        /// </summary>
        [JsonProperty("occurredAt", NullValueHandling = NullValueHandling.Ignore)]
        public string OccurredAt { get; set; }

        /// <summary>
        /// The success or failure of the provisioning event.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// The user who performed the provisioning event.
        /// </summary>
        [JsonProperty("eventBy", NullValueHandling = NullValueHandling.Ignore)]
        public string EventBy { get; set; }

        /// <summary>
        /// The provisioning action:Activate,Suspend,Restore,Deactivate,Device Move.
        /// </summary>
        [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
        public string EventType { get; set; }

        /// <summary>
        /// The MDN assigned to the device after the provisioning event.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The MSISDN assigned to the device after the provisioning event.
        /// </summary>
        [JsonProperty("msisdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Msisdn { get; set; }

        /// <summary>
        /// The service plan of the device after the provisioning event occurred.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Any extended attributes for the event, as Key and Value pairs.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProvisioningHistory : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProvisioningHistory other &&                ((this.OccurredAt == null && other.OccurredAt == null) || (this.OccurredAt?.Equals(other.OccurredAt) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.EventBy == null && other.EventBy == null) || (this.EventBy?.Equals(other.EventBy) == true)) &&
                ((this.EventType == null && other.EventType == null) || (this.EventType?.Equals(other.EventType) == true)) &&
                ((this.Mdn == null && other.Mdn == null) || (this.Mdn?.Equals(other.Mdn) == true)) &&
                ((this.Msisdn == null && other.Msisdn == null) || (this.Msisdn?.Equals(other.Msisdn) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.OccurredAt = {(this.OccurredAt == null ? "null" : this.OccurredAt == string.Empty ? "" : this.OccurredAt)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status == string.Empty ? "" : this.Status)}");
            toStringOutput.Add($"this.EventBy = {(this.EventBy == null ? "null" : this.EventBy == string.Empty ? "" : this.EventBy)}");
            toStringOutput.Add($"this.EventType = {(this.EventType == null ? "null" : this.EventType == string.Empty ? "" : this.EventType)}");
            toStringOutput.Add($"this.Mdn = {(this.Mdn == null ? "null" : this.Mdn == string.Empty ? "" : this.Mdn)}");
            toStringOutput.Add($"this.Msisdn = {(this.Msisdn == null ? "null" : this.Msisdn == string.Empty ? "" : this.Msisdn)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan == string.Empty ? "" : this.ServicePlan)}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
        }
    }
}