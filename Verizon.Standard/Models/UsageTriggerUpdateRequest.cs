// <copyright file="UsageTriggerUpdateRequest.cs" company="APIMatic">
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
    /// UsageTriggerUpdateRequest.
    /// </summary>
    public class UsageTriggerUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerUpdateRequest"/> class.
        /// </summary>
        public UsageTriggerUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerUpdateRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="thresholdValue">thresholdValue.</param>
        /// <param name="smsPhoneNumbers">smsPhoneNumbers.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        public UsageTriggerUpdateRequest(
            string accountName,
            string triggerName = null,
            string thresholdValue = null,
            string smsPhoneNumbers = null,
            string emailAddresses = null)
        {
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.ThresholdValue = thresholdValue;
            this.SmsPhoneNumbers = smsPhoneNumbers;
            this.EmailAddresses = emailAddresses;
        }

        /// <summary>
        /// Usage trigger name
        /// </summary>
        [JsonProperty("triggerName", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// The percent of subscribed usage required to activate the trigger, such as 90 or 100.
        /// </summary>
        [JsonProperty("thresholdValue", NullValueHandling = NullValueHandling.Ignore)]
        public string ThresholdValue { get; set; }

        /// <summary>
        /// Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
        /// </summary>
        [JsonProperty("smsPhoneNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsPhoneNumbers { get; set; }

        /// <summary>
        /// Comma-separated list of email addresses to send alerts to.
        /// </summary>
        [JsonProperty("emailAddresses", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddresses { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsageTriggerUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsageTriggerUpdateRequest other &&                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.ThresholdValue == null && other.ThresholdValue == null) || (this.ThresholdValue?.Equals(other.ThresholdValue) == true)) &&
                ((this.SmsPhoneNumbers == null && other.SmsPhoneNumbers == null) || (this.SmsPhoneNumbers?.Equals(other.SmsPhoneNumbers) == true)) &&
                ((this.EmailAddresses == null && other.EmailAddresses == null) || (this.EmailAddresses?.Equals(other.EmailAddresses) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.ThresholdValue = {(this.ThresholdValue == null ? "null" : this.ThresholdValue)}");
            toStringOutput.Add($"this.SmsPhoneNumbers = {(this.SmsPhoneNumbers == null ? "null" : this.SmsPhoneNumbers)}");
            toStringOutput.Add($"this.EmailAddresses = {(this.EmailAddresses == null ? "null" : this.EmailAddresses)}");
        }
    }
}