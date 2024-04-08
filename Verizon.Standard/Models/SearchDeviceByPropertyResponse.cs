// <copyright file="SearchDeviceByPropertyResponse.cs" company="APIMatic">
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
    /// SearchDeviceByPropertyResponse.
    /// </summary>
    public class SearchDeviceByPropertyResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyResponse"/> class.
        /// </summary>
        public SearchDeviceByPropertyResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyResponse"/> class.
        /// </summary>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="eventretention">eventretention.</param>
        /// <param name="fields">fields.</param>
        /// <param name="iccid">iccid.</param>
        /// <param name="id">id.</param>
        /// <param name="imei">imei.</param>
        /// <param name="kind">kind.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="providerid">providerid.</param>
        /// <param name="refid">refid.</param>
        /// <param name="refidtype">refidtype.</param>
        /// <param name="state">state.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        public SearchDeviceByPropertyResponse(
            string billingaccountid = null,
            string createdon = null,
            string eventretention = null,
            Models.Fields1 fields = null,
            string iccid = null,
            string id = null,
            string imei = null,
            string kind = null,
            string lastupdated = null,
            string providerid = null,
            string refid = null,
            string refidtype = null,
            string state = null,
            string version = null,
            string versionid = null)
        {
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Eventretention = eventretention;
            this.Fields = fields;
            this.Iccid = iccid;
            this.Id = id;
            this.Imei = imei;
            this.Kind = kind;
            this.Lastupdated = lastupdated;
            this.Providerid = providerid;
            this.Refid = refid;
            this.Refidtype = refidtype;
            this.State = state;
            this.Version = version;
            this.Versionid = versionid;
        }

        /// <summary>
        /// Billing account ID of the resource.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The date the resource was created.
        /// </summary>
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public string Createdon { get; set; }

        /// <summary>
        /// Gets or sets Eventretention.
        /// </summary>
        [JsonProperty("eventretention", NullValueHandling = NullValueHandling.Ignore)]
        public string Eventretention { get; set; }

        /// <summary>
        /// Gets or sets Fields.
        /// </summary>
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Fields1 Fields { get; set; }

        /// <summary>
        /// Cellular SIM card identifier.
        /// </summary>
        [JsonProperty("iccid", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <summary>
        /// ThingSpace unique ID for the device that was added.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 4G hardware device identifier.
        /// </summary>
        [JsonProperty("imei", NullValueHandling = NullValueHandling.Ignore)]
        public string Imei { get; set; }

        /// <summary>
        /// Identifies the resource kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The date the resource was last updated.
        /// </summary>
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// The device’s service provider.
        /// </summary>
        [JsonProperty("providerid", NullValueHandling = NullValueHandling.Ignore)]
        public string Providerid { get; set; }

        /// <summary>
        /// The value of the refidtype identifier.
        /// </summary>
        [JsonProperty("refid", NullValueHandling = NullValueHandling.Ignore)]
        public string Refid { get; set; }

        /// <summary>
        /// The device identifier type used to refer to this device.
        /// </summary>
        [JsonProperty("refidtype", NullValueHandling = NullValueHandling.Ignore)]
        public string Refidtype { get; set; }

        /// <summary>
        /// Service state of the device.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Version of the underlying schema resource.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// The version of the resource.
        /// </summary>
        [JsonProperty("versionid", NullValueHandling = NullValueHandling.Ignore)]
        public string Versionid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchDeviceByPropertyResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchDeviceByPropertyResponse other &&                ((this.Billingaccountid == null && other.Billingaccountid == null) || (this.Billingaccountid?.Equals(other.Billingaccountid) == true)) &&
                ((this.Createdon == null && other.Createdon == null) || (this.Createdon?.Equals(other.Createdon) == true)) &&
                ((this.Eventretention == null && other.Eventretention == null) || (this.Eventretention?.Equals(other.Eventretention) == true)) &&
                ((this.Fields == null && other.Fields == null) || (this.Fields?.Equals(other.Fields) == true)) &&
                ((this.Iccid == null && other.Iccid == null) || (this.Iccid?.Equals(other.Iccid) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Imei == null && other.Imei == null) || (this.Imei?.Equals(other.Imei) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Lastupdated == null && other.Lastupdated == null) || (this.Lastupdated?.Equals(other.Lastupdated) == true)) &&
                ((this.Providerid == null && other.Providerid == null) || (this.Providerid?.Equals(other.Providerid) == true)) &&
                ((this.Refid == null && other.Refid == null) || (this.Refid?.Equals(other.Refid) == true)) &&
                ((this.Refidtype == null && other.Refidtype == null) || (this.Refidtype?.Equals(other.Refidtype) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Versionid == null && other.Versionid == null) || (this.Versionid?.Equals(other.Versionid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Billingaccountid = {(this.Billingaccountid == null ? "null" : this.Billingaccountid)}");
            toStringOutput.Add($"this.Createdon = {(this.Createdon == null ? "null" : this.Createdon)}");
            toStringOutput.Add($"this.Eventretention = {(this.Eventretention == null ? "null" : this.Eventretention)}");
            toStringOutput.Add($"this.Fields = {(this.Fields == null ? "null" : this.Fields.ToString())}");
            toStringOutput.Add($"this.Iccid = {(this.Iccid == null ? "null" : this.Iccid)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Imei = {(this.Imei == null ? "null" : this.Imei)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated)}");
            toStringOutput.Add($"this.Providerid = {(this.Providerid == null ? "null" : this.Providerid)}");
            toStringOutput.Add($"this.Refid = {(this.Refid == null ? "null" : this.Refid)}");
            toStringOutput.Add($"this.Refidtype = {(this.Refidtype == null ? "null" : this.Refidtype)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.Versionid = {(this.Versionid == null ? "null" : this.Versionid)}");
        }
    }
}