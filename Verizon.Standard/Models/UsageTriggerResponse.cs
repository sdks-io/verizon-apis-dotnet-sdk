// <copyright file="UsageTriggerResponse.cs" company="APIMatic">
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
    /// UsageTriggerResponse.
    /// </summary>
    public class UsageTriggerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerResponse"/> class.
        /// </summary>
        public UsageTriggerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageTriggerResponse"/> class.
        /// </summary>
        /// <param name="triggerId">triggerId.</param>
        /// <param name="triggerName">triggerName.</param>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="thresholdValue">thresholdValue.</param>
        /// <param name="allowExcess">allowExcess.</param>
        /// <param name="sendSmsNotification">sendSmsNotification.</param>
        /// <param name="smsPhoneNumbers">smsPhoneNumbers.</param>
        /// <param name="sendEmailNotification">sendEmailNotification.</param>
        /// <param name="emailAddresses">emailAddresses.</param>
        /// <param name="createDate">createDate.</param>
        /// <param name="updateDate">updateDate.</param>
        public UsageTriggerResponse(
            string triggerId,
            string triggerName,
            string accountName,
            Models.ServiceNameEnum serviceName,
            string thresholdValue,
            bool allowExcess,
            bool sendSmsNotification,
            string smsPhoneNumbers,
            bool sendEmailNotification,
            string emailAddresses,
            string createDate,
            string updateDate)
        {
            this.TriggerId = triggerId;
            this.TriggerName = triggerName;
            this.AccountName = accountName;
            this.ServiceName = serviceName;
            this.ThresholdValue = thresholdValue;
            this.AllowExcess = allowExcess;
            this.SendSmsNotification = sendSmsNotification;
            this.SmsPhoneNumbers = smsPhoneNumbers;
            this.SendEmailNotification = sendEmailNotification;
            this.EmailAddresses = emailAddresses;
            this.CreateDate = createDate;
            this.UpdateDate = updateDate;
        }

        /// <summary>
        /// Unique usage triggerId
        /// </summary>
        [JsonProperty("triggerId")]
        public string TriggerId { get; set; }

        /// <summary>
        /// Usage trigger name
        /// </summary>
        [JsonProperty("triggerName")]
        public string TriggerName { get; set; }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Service name
        /// </summary>
        [JsonProperty("serviceName")]
        public Models.ServiceNameEnum ServiceName { get; set; }

        /// <summary>
        /// Percent of subscription at which trigger will send an alert
        /// </summary>
        [JsonProperty("thresholdValue")]
        public string ThresholdValue { get; set; }

        /// <summary>
        /// allowExcess determines whether to restrict usage after exceeds limits
        /// </summary>
        [JsonProperty("allowExcess")]
        public bool AllowExcess { get; set; }

        /// <summary>
        /// Send SMS (text) alerts when the thresholdValue is reached.
        /// </summary>
        [JsonProperty("sendSmsNotification")]
        public bool SendSmsNotification { get; set; }

        /// <summary>
        /// comma seperated value of list of Phone numbers for SMS notifications
        /// </summary>
        [JsonProperty("smsPhoneNumbers")]
        public string SmsPhoneNumbers { get; set; }

        /// <summary>
        /// Send email alerts when the thresholdValue is reached.
        /// </summary>
        [JsonProperty("sendEmailNotification")]
        public bool SendEmailNotification { get; set; }

        /// <summary>
        /// comma seperated value of list of Email addresses for Email notifications
        /// </summary>
        [JsonProperty("emailAddresses")]
        public string EmailAddresses { get; set; }

        /// <summary>
        /// UTC Date when the usage trigger was created
        /// </summary>
        [JsonProperty("createDate")]
        public string CreateDate { get; set; }

        /// <summary>
        /// UTC Date when the usage trigger was last updated
        /// </summary>
        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UsageTriggerResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UsageTriggerResponse other &&
                (this.TriggerId == null && other.TriggerId == null ||
                 this.TriggerId?.Equals(other.TriggerId) == true) &&
                (this.TriggerName == null && other.TriggerName == null ||
                 this.TriggerName?.Equals(other.TriggerName) == true) &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ServiceName.Equals(other.ServiceName)) &&
                (this.ThresholdValue == null && other.ThresholdValue == null ||
                 this.ThresholdValue?.Equals(other.ThresholdValue) == true) &&
                (this.AllowExcess.Equals(other.AllowExcess)) &&
                (this.SendSmsNotification.Equals(other.SendSmsNotification)) &&
                (this.SmsPhoneNumbers == null && other.SmsPhoneNumbers == null ||
                 this.SmsPhoneNumbers?.Equals(other.SmsPhoneNumbers) == true) &&
                (this.SendEmailNotification.Equals(other.SendEmailNotification)) &&
                (this.EmailAddresses == null && other.EmailAddresses == null ||
                 this.EmailAddresses?.Equals(other.EmailAddresses) == true) &&
                (this.CreateDate == null && other.CreateDate == null ||
                 this.CreateDate?.Equals(other.CreateDate) == true) &&
                (this.UpdateDate == null && other.UpdateDate == null ||
                 this.UpdateDate?.Equals(other.UpdateDate) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"TriggerId = {this.TriggerId ?? "null"}");
            toStringOutput.Add($"TriggerName = {this.TriggerName ?? "null"}");
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ServiceName = {this.ServiceName}");
            toStringOutput.Add($"ThresholdValue = {this.ThresholdValue ?? "null"}");
            toStringOutput.Add($"AllowExcess = {this.AllowExcess}");
            toStringOutput.Add($"SendSmsNotification = {this.SendSmsNotification}");
            toStringOutput.Add($"SmsPhoneNumbers = {this.SmsPhoneNumbers ?? "null"}");
            toStringOutput.Add($"SendEmailNotification = {this.SendEmailNotification}");
            toStringOutput.Add($"EmailAddresses = {this.EmailAddresses ?? "null"}");
            toStringOutput.Add($"CreateDate = {this.CreateDate ?? "null"}");
            toStringOutput.Add($"UpdateDate = {this.UpdateDate ?? "null"}");
        }
    }
}