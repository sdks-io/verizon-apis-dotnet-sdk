// <copyright file="ChangeConfigurationResponse.cs" company="APIMatic">
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
    /// ChangeConfigurationResponse.
    /// </summary>
    public class ChangeConfigurationResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfigurationResponse"/> class.
        /// </summary>
        public ChangeConfigurationResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeConfigurationResponse"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="deviceid">deviceid.</param>
        /// <param name="fields">fields.</param>
        /// <param name="foreignid">foreignid.</param>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="state">state.</param>
        /// <param name="transactionid">transactionid.</param>
        /// <param name="version">version.</param>
        public ChangeConfigurationResponse(
            string action = null,
            string createdon = null,
            string deviceid = null,
            Models.Fields fields = null,
            string foreignid = null,
            string id = null,
            string kind = null,
            string lastupdated = null,
            string name = null,
            string state = null,
            string transactionid = null,
            string version = null)
        {
            this.Action = action;
            this.Createdon = createdon;
            this.Deviceid = deviceid;
            this.Fields = fields;
            this.Foreignid = foreignid;
            this.Id = id;
            this.Kind = kind;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.State = state;
            this.Transactionid = transactionid;
            this.Version = version;
        }

        /// <summary>
        /// The action requested in this event; “change” for device configuration changes.
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// The date and time of the change request.
        /// </summary>
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public string Createdon { get; set; }

        /// <summary>
        /// The device’s ThingSpace UUID.
        /// </summary>
        [JsonProperty("deviceid", NullValueHandling = NullValueHandling.Ignore)]
        public string Deviceid { get; set; }

        /// <summary>
        /// List of fields affected by the event.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fields Fields { get; set; }

        /// <summary>
        /// foreign id
        /// </summary>
        [JsonProperty("foreignid", NullValueHandling = NullValueHandling.Ignore)]
        public string Foreignid { get; set; }

        /// <summary>
        /// The unique ID of this ts.event.configuration event.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The kind of the ThingSpace resource that is being reported
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The date and time that the event was last updated.
        /// </summary>
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// The name of the event; “SetConfigurationReq” for device configuration changes.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The current status of the request. The value will be “pending” until the device wakes up and ThingSpace can send the request to the device.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// transaction id
        /// </summary>
        [JsonProperty("transactionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Transactionid { get; set; }

        /// <summary>
        /// version
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChangeConfigurationResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChangeConfigurationResponse other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Createdon == null && other.Createdon == null) || (this.Createdon?.Equals(other.Createdon) == true)) &&
                ((this.Deviceid == null && other.Deviceid == null) || (this.Deviceid?.Equals(other.Deviceid) == true)) &&
                ((this.Fields == null && other.Fields == null) || (this.Fields?.Equals(other.Fields) == true)) &&
                ((this.Foreignid == null && other.Foreignid == null) || (this.Foreignid?.Equals(other.Foreignid) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Lastupdated == null && other.Lastupdated == null) || (this.Lastupdated?.Equals(other.Lastupdated) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Transactionid == null && other.Transactionid == null) || (this.Transactionid?.Equals(other.Transactionid) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
            toStringOutput.Add($"this.Createdon = {(this.Createdon == null ? "null" : this.Createdon)}");
            toStringOutput.Add($"this.Deviceid = {(this.Deviceid == null ? "null" : this.Deviceid)}");
            toStringOutput.Add($"this.Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"this.Foreignid = {(this.Foreignid == null ? "null" : this.Foreignid)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Transactionid = {(this.Transactionid == null ? "null" : this.Transactionid)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
        }
    }
}