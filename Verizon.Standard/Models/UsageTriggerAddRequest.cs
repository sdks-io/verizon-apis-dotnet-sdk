// <copyright file="UsageTriggerAddRequest.cs" company="APIMatic">
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
    /// UsageTriggerAddRequest.
    /// </summary>
    public class UsageTriggerAddRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerAddRequest"/> class.
        /// </summary>
        public UsageTriggerAddRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerAddRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="thresholdValue">thresholdValue.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="allowExcess">allowExcess.</param>
        /// <param name="sendSmsNotification">sendSmsNotification.</param>
        /// <param name="smsPhoneNumbers">smsPhoneNumbers.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        public UsageTriggerAddRequest(
            string accountName,
            Models.ServiceNameEnum serviceName,
            string thresholdValue,
            string triggerName = null,
            bool? allowExcess = null,
            bool? sendSmsNotification = null,
            string smsPhoneNumbers = null,
            bool? sendEmailNotification = null,
            string emailAddresses = null)
        {
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.ServiceName = serviceName;
            this.ThresholdValue = thresholdValue;
            this.AllowExcess = allowExcess;
            this.SendSmsNotification = sendSmsNotification;
            this.SmsPhoneNumbers = smsPhoneNumbers;
            this.SendEmailNotification = sendEmailNotification;
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
        /// Service name
        /// </summary>
        [JsonProperty("serviceName", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ServiceNameEnum ServiceName { get; set; }

        /// <summary>
        /// The percent of subscribed usage required to activate the trigger, such as 90 or 100.
        /// </summary>
        [JsonProperty("thresholdValue")]
        public string ThresholdValue { get; set; }

        /// <summary>
        /// Allow additional requests after thresholdValue is reached. (currently not functional)
        /// </summary>
        [JsonProperty("allowExcess", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowExcess { get; set; }

        /// <summary>
        /// Send SMS (text) alerts when the thresholdValue is reached.
        /// </summary>
        [JsonProperty("sendSmsNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendSmsNotification { get; set; }

        /// <summary>
        /// Comma-separated list of phone numbers to send SMS alerts to. Digits only; no dashes or parentheses, etc.
        /// </summary>
        [JsonProperty("smsPhoneNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsPhoneNumbers { get; set; }

        /// <summary>
        /// Send email alerts when the thresholdValue is reached.
        /// </summary>
        [JsonProperty("sendEmailNotification", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendEmailNotification { get; set; }

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

            return $"UsageTriggerAddRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UsageTriggerAddRequest other &&                ((this.TriggerName == null && other.TriggerName == null) || (this.TriggerName?.Equals(other.TriggerName) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.ServiceName.Equals(other.ServiceName) &&
                ((this.ThresholdValue == null && other.ThresholdValue == null) || (this.ThresholdValue?.Equals(other.ThresholdValue) == true)) &&
                ((this.AllowExcess == null && other.AllowExcess == null) || (this.AllowExcess?.Equals(other.AllowExcess) == true)) &&
                ((this.SendSmsNotification == null && other.SendSmsNotification == null) || (this.SendSmsNotification?.Equals(other.SendSmsNotification) == true)) &&
                ((this.SmsPhoneNumbers == null && other.SmsPhoneNumbers == null) || (this.SmsPhoneNumbers?.Equals(other.SmsPhoneNumbers) == true)) &&
                ((this.SendEmailNotification == null && other.SendEmailNotification == null) || (this.SendEmailNotification?.Equals(other.SendEmailNotification) == true)) &&
                ((this.EmailAddresses == null && other.EmailAddresses == null) || (this.EmailAddresses?.Equals(other.EmailAddresses) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TriggerName = {(this.TriggerName == null ? "null" : this.TriggerName == string.Empty ? "" : this.TriggerName)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.ServiceName = {this.ServiceName}");
            toStringOutput.Add($"this.ThresholdValue = {(this.ThresholdValue == null ? "null" : this.ThresholdValue == string.Empty ? "" : this.ThresholdValue)}");
            toStringOutput.Add($"this.AllowExcess = {(this.AllowExcess == null ? "null" : this.AllowExcess.ToString())}");
            toStringOutput.Add($"this.SendSmsNotification = {(this.SendSmsNotification == null ? "null" : this.SendSmsNotification.ToString())}");
            toStringOutput.Add($"this.SmsPhoneNumbers = {(this.SmsPhoneNumbers == null ? "null" : this.SmsPhoneNumbers == string.Empty ? "" : this.SmsPhoneNumbers)}");
            toStringOutput.Add($"this.SendEmailNotification = {(this.SendEmailNotification == null ? "null" : this.SendEmailNotification.ToString())}");
            toStringOutput.Add($"this.EmailAddresses = {(this.EmailAddresses == null ? "null" : this.EmailAddresses == string.Empty ? "" : this.EmailAddresses)}");
        }
    }
}