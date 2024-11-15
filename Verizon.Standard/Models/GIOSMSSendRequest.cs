// <copyright file="GIOSMSSendRequest.cs" company="APIMatic">
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
    /// GIOSMSSendRequest.
    /// </summary>
    public class GIOSMSSendRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GIOSMSSendRequest"/> class.
        /// </summary>
        public GIOSMSSendRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GIOSMSSendRequest"/> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="smsMessage">smsMessage.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="dataEncoding">dataEncoding.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="timeToLive">timeToLive.</param>
        public GIOSMSSendRequest(
            List<Models.GIODeviceId> deviceIds,
            string smsMessage,
            string accountName = null,
            List<Models.KvPair> customFields = null,
            string dataEncoding = null,
            string groupName = null,
            string servicePlan = null,
            string timeToLive = null)
        {
            this.AccountName = accountName;
            this.CustomFields = customFields;
            this.DataEncoding = dataEncoding;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
            this.TimeToLive = timeToLive;
            this.DeviceIds = deviceIds;
            this.SmsMessage = smsMessage;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.KvPair> CustomFields { get; set; }

        /// <summary>
        /// Gets or sets DataEncoding.
        /// </summary>
        [JsonProperty("dataEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string DataEncoding { get; set; }

        /// <summary>
        /// Gets or sets GroupName.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets TimeToLive.
        /// </summary>
        [JsonProperty("timeToLive", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeToLive { get; set; }

        /// <summary>
        /// Gets or sets DeviceIds.
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<Models.GIODeviceId> DeviceIds { get; set; }

        /// <summary>
        /// Gets or sets SmsMessage.
        /// </summary>
        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GIOSMSSendRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is GIOSMSSendRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.DataEncoding == null && other.DataEncoding == null) || (this.DataEncoding?.Equals(other.DataEncoding) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.TimeToLive == null && other.TimeToLive == null) || (this.TimeToLive?.Equals(other.TimeToLive) == true)) &&
                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.SmsMessage == null && other.SmsMessage == null) || (this.SmsMessage?.Equals(other.SmsMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.DataEncoding = {(this.DataEncoding == null ? "null" : this.DataEncoding)}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.TimeToLive = {(this.TimeToLive == null ? "null" : this.TimeToLive)}");
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.SmsMessage = {(this.SmsMessage == null ? "null" : this.SmsMessage)}");
        }
    }
}