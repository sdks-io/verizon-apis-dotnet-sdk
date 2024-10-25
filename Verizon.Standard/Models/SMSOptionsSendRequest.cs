// <copyright file="SMSOptionsSendRequest.cs" company="APIMatic">
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
    /// SMSOptionsSendRequest.
    /// </summary>
    public class SMSOptionsSendRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SMSOptionsSendRequest"/> class.
        /// </summary>
        public SMSOptionsSendRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMSOptionsSendRequest"/> class.
        /// </summary>
        /// <param name="servicePlan">servicePlan.</param>
        /// <param name="smsMessage">smsMessage.</param>
        public SMSOptionsSendRequest(
            string servicePlan = null,
            string smsMessage = null)
        {
            this.ServicePlan = servicePlan;
            this.SmsMessage = smsMessage;
        }

        /// <summary>
        /// Gets or sets ServicePlan.
        /// </summary>
        [JsonProperty("servicePlan", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlan { get; set; }

        /// <summary>
        /// Gets or sets SmsMessage.
        /// </summary>
        [JsonProperty("smsMessage", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsMessage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SMSOptionsSendRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SMSOptionsSendRequest other &&                ((this.ServicePlan == null && other.ServicePlan == null) || (this.ServicePlan?.Equals(other.ServicePlan) == true)) &&
                ((this.SmsMessage == null && other.SmsMessage == null) || (this.SmsMessage?.Equals(other.SmsMessage) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServicePlan = {(this.ServicePlan == null ? "null" : this.ServicePlan)}");
            toStringOutput.Add($"this.SmsMessage = {(this.SmsMessage == null ? "null" : this.SmsMessage)}");
        }
    }
}