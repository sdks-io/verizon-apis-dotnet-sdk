// <copyright file="SMSSendRequest.cs" company="APIMatic">
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
    /// SMSSendRequest.
    /// </summary>
    public class SMSSendRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSSendRequest"/> class.
        /// </summary>
        public SMSSendRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSSendRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="smsMessage">smsMessage.</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="dataEncoding">dataEncoding.</param>
        /// <param name="deviceIds">deviceIds.</param>
        /// <param name="groupName">groupName.</param>
        /// <param name="servicePlan">servicePlan.</param>
        public SMSSendRequest(
            string accountName,
            string smsMessage,
            List<Models.CustomFields> customFields = null,
            string dataEncoding = null,
            List<Models.DeviceId> deviceIds = null,
            string groupName = null,
            string servicePlan = null)
        {
            this.AccountName = accountName;
            this.SmsMessage = smsMessage;
            this.CustomFields = customFields;
            this.DataEncoding = dataEncoding;
            this.DeviceIds = deviceIds;
            this.GroupName = groupName;
            this.ServicePlan = servicePlan;
        }

        /// <summary>
        /// The name of a billing account.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The contents of the SMS message. The SMS message is limited to 160 characters in 7-bit format, or 140 characters in 8-bit format.
        /// </summary>
        [JsonProperty("smsMessage")]
        public string SmsMessage { get; set; }

        /// <summary>
        /// The names and values of custom fields, if you want to only include devices that have matching custom fields.
        /// </summary>
        [JsonProperty("customFields", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> CustomFields { get; set; }

        /// <summary>
        /// The SMS message encoding, which can be 7-bit (default), 8-bit-ASCII, 8-bit-UTF-8, 8-bit-DATA.
        /// </summary>
        [JsonProperty("dataEncoding", NullValueHandling = NullValueHandling.Ignore)]
        public string DataEncoding { get; set; }

        /// <summary>
        /// The devices that you want to send the message to, specified by device identifier.
        /// </summary>
        [JsonProperty("deviceIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DeviceIds { get; set; }

        /// <summary>
        /// The name of a device group, if you want to send the SMS message to all devices in the device group.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// The name of a service plan, if you want to only include devices that have that service plan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SMSSendRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SMSSendRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.SmsMessage == null && other.SmsMessage == null) || (this.SmsMessage?.Equals(other.SmsMessage) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true)) &&
                ((this.DataEncoding == null && other.DataEncoding == null) || (this.DataEncoding?.Equals(other.DataEncoding) == true)) &&
                ((this.DeviceIds == null && other.DeviceIds == null) || (this.DeviceIds?.Equals(other.DeviceIds) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true)) &&
                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.SmsMessage = {(this.SmsMessage == null ? "null" : this.SmsMessage)}");
            toStringOutput.Add($"this.CustomFields = {(this.CustomFields == null ? "null" : $"[{string.Join(", ", this.CustomFields)} ]")}");
            toStringOutput.Add($"this.DataEncoding = {(this.DataEncoding == null ? "null" : this.DataEncoding)}");
            toStringOutput.Add($"this.DeviceIds = {(this.DeviceIds == null ? "null" : $"[{string.Join(", ", this.DeviceIds)} ]")}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName)}");
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
        }
    }
}