// <copyright file="FotaV1CallbackRegistrationResult.cs" company="APIMatic">
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
    /// FotaV1CallbackRegistrationResult.
    /// </summary>
    public class FotaV1CallbackRegistrationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1CallbackRegistrationResult"/> class.
        /// </summary>
        public FotaV1CallbackRegistrationResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FotaV1CallbackRegistrationResult"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="serviceName">serviceName.</param>
        public FotaV1CallbackRegistrationResult(
            string accountName = null,
            string serviceName = null)
        {
            this.AccountName = accountName;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// The name of the billing account for which callback messages will be sent.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The name of the callback service, which identifies the type and format of messages that will be sent to the registered URL. This will be 'Fota' for the Software Management Services callback.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FotaV1CallbackRegistrationResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is FotaV1CallbackRegistrationResult other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
        }
    }
}