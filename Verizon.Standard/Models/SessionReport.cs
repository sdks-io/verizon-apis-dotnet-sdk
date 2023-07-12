// <copyright file="SessionReport.cs" company="APIMatic">
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
    /// SessionReport.
    /// </summary>
    public class SessionReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReport"/> class.
        /// </summary>
        public SessionReport()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionReport"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sessions">sessions.</param>
        /// <param name="txid">txid.</param>
        /// <param name="example">example.</param>
        public SessionReport(
            string id,
            List<Models.DailyUsageItem> sessions = null,
            string txid = null,
            object example = null)
        {
            this.Sessions = sessions;
            this.Id = id;
            this.Txid = txid;
            this.Example = example;
        }

        /// <summary>
        /// An object containing the start and end time of the session with the amount of data transferred.
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DailyUsageItem> Sessions { get; set; }

        /// <summary>
        /// The 10-digit ID of the device.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A unique string that associates the request with the location report information that is sent in asynchronous callback message.ThingSpace will send a separate callback message for each device that was in the request. All of the callback messages will have the same txid.
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Include)]
        public string Txid { get; set; }

        /// <summary>
        /// Gets or sets Example.
        /// </summary>
        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public object Example { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SessionReport : ({string.Join(", ", toStringOutput)})";
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
            return obj is SessionReport other &&                ((this.Sessions == null && other.Sessions == null) || (this.Sessions?.Equals(other.Sessions) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true)) &&
                ((this.Example == null && other.Example == null) || (this.Example?.Equals(other.Example) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Sessions = {(this.Sessions == null ? "null" : $"[{string.Join(", ", this.Sessions)} ]")}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid == string.Empty ? "" : this.Txid)}");
            toStringOutput.Add($"Example = {(this.Example == null ? "null" : this.Example.ToString())}");
        }
    }
}