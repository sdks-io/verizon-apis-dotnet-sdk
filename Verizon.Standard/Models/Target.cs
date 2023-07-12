// <copyright file="Target.cs" company="APIMatic">
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
    /// Target.
    /// </summary>
    public class Target
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        public Target()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Target"/> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="addressscheme">addressscheme.</param>
        /// <param name="billingaccountid">billingaccountid.</param>
        /// <param name="createdon">createdon.</param>
        /// <param name="externalid">externalid.</param>
        /// <param name="id">id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="lastupdated">lastupdated.</param>
        /// <param name="name">name.</param>
        /// <param name="region">region.</param>
        /// <param name="version">version.</param>
        /// <param name="versionid">versionid.</param>
        /// <param name="description">description.</param>
        public Target(
            string address = null,
            string addressscheme = null,
            string billingaccountid = null,
            string createdon = null,
            string externalid = null,
            string id = null,
            string kind = null,
            string lastupdated = null,
            string name = null,
            string region = null,
            string version = null,
            string versionid = null,
            string description = null)
        {
            this.Address = address;
            this.Addressscheme = addressscheme;
            this.Billingaccountid = billingaccountid;
            this.Createdon = createdon;
            this.Externalid = externalid;
            this.Id = id;
            this.Kind = kind;
            this.Lastupdated = lastupdated;
            this.Name = name;
            this.Region = region;
            this.Version = version;
            this.Versionid = versionid;
            this.Description = description;
        }

        /// <summary>
        /// The endpoint for data streams.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// The transport format.
        /// </summary>
        [JsonProperty("addressscheme", NullValueHandling = NullValueHandling.Ignore)]
        public string Addressscheme { get; set; }

        /// <summary>
        /// The billing account ID.
        /// </summary>
        [JsonProperty("billingaccountid", NullValueHandling = NullValueHandling.Ignore)]
        public string Billingaccountid { get; set; }

        /// <summary>
        /// The date the resource was created.
        /// </summary>
        [JsonProperty("createdon", NullValueHandling = NullValueHandling.Ignore)]
        public string Createdon { get; set; }

        /// <summary>
        /// Security identification string.
        /// </summary>
        [JsonProperty("externalid", NullValueHandling = NullValueHandling.Ignore)]
        public string Externalid { get; set; }

        /// <summary>
        /// ThingSpace unique ID for the target that was created.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Identifies the resource kind. Targets are ts.target.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// The date the resource was last updated.
        /// </summary>
        [JsonProperty("lastupdated", NullValueHandling = NullValueHandling.Ignore)]
        public string Lastupdated { get; set; }

        /// <summary>
        /// Name of the target.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// AWS region value.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

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

        /// <summary>
        /// Description of the target.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Target : ({string.Join(", ", toStringOutput)})";
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
            return obj is Target other &&                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Addressscheme == null && other.Addressscheme == null) || (this.Addressscheme?.Equals(other.Addressscheme) == true)) &&
                ((this.Billingaccountid == null && other.Billingaccountid == null) || (this.Billingaccountid?.Equals(other.Billingaccountid) == true)) &&
                ((this.Createdon == null && other.Createdon == null) || (this.Createdon?.Equals(other.Createdon) == true)) &&
                ((this.Externalid == null && other.Externalid == null) || (this.Externalid?.Equals(other.Externalid) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.Lastupdated == null && other.Lastupdated == null) || (this.Lastupdated?.Equals(other.Lastupdated) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Versionid == null && other.Versionid == null) || (this.Versionid?.Equals(other.Versionid) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address == string.Empty ? "" : this.Address)}");
            toStringOutput.Add($"this.Addressscheme = {(this.Addressscheme == null ? "null" : this.Addressscheme == string.Empty ? "" : this.Addressscheme)}");
            toStringOutput.Add($"this.Billingaccountid = {(this.Billingaccountid == null ? "null" : this.Billingaccountid == string.Empty ? "" : this.Billingaccountid)}");
            toStringOutput.Add($"this.Createdon = {(this.Createdon == null ? "null" : this.Createdon == string.Empty ? "" : this.Createdon)}");
            toStringOutput.Add($"this.Externalid = {(this.Externalid == null ? "null" : this.Externalid == string.Empty ? "" : this.Externalid)}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind == string.Empty ? "" : this.Kind)}");
            toStringOutput.Add($"this.Lastupdated = {(this.Lastupdated == null ? "null" : this.Lastupdated == string.Empty ? "" : this.Lastupdated)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region == string.Empty ? "" : this.Region)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.Versionid = {(this.Versionid == null ? "null" : this.Versionid == string.Empty ? "" : this.Versionid)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description == string.Empty ? "" : this.Description)}");
        }
    }
}