// <copyright file="ServiceLaunchRequestResult.cs" company="APIMatic">
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
    /// ServiceLaunchRequestResult.
    /// </summary>
    public class ServiceLaunchRequestResult
    {
        private List<Models.LinkedServiceInstance> linkedServiceInstances;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "linkedServiceInstances", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchRequestResult"/> class.
        /// </summary>
        public ServiceLaunchRequestResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLaunchRequestResult"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="state">state.</param>
        /// <param name="serviceVersion">serviceVersion.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="serviceProfileId">serviceProfileId.</param>
        /// <param name="cspProfileId">cspProfileId.</param>
        /// <param name="configFiles">configFiles.</param>
        /// <param name="linkedServiceInstances">linkedServiceInstances.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public ServiceLaunchRequestResult(
            Guid? id = null,
            string name = null,
            string serviceName = null,
            Models.ServiceLaunchStateEnum? state = null,
            string serviceVersion = null,
            string serviceId = null,
            string serviceProfileId = null,
            string cspProfileId = null,
            List<Models.ConfigFileItem> configFiles = null,
            List<Models.LinkedServiceInstance> linkedServiceInstances = null,
            DateTime? createdAt = null,
            DateTime? updatedAt = null,
            string updatedBy = null)
        {
            this.Id = id;
            this.Name = name;
            this.ServiceName = serviceName;
            this.State = state;
            this.ServiceVersion = serviceVersion;
            this.ServiceId = serviceId;
            this.ServiceProfileId = serviceProfileId;
            this.CspProfileId = cspProfileId;
            this.ConfigFiles = configFiles;
            if (linkedServiceInstances != null)
            {
                this.LinkedServiceInstances = linkedServiceInstances;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Unique service profile ID.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Service request name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Service being deployed.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceLaunchStateEnum? State { get; set; }

        /// <summary>
        /// Service version being deployed.
        /// </summary>
        [JsonProperty("serviceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// Gets or sets ServiceId.
        /// </summary>
        [JsonProperty("serviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The service profile ID that is created during the post-service API.
        /// </summary>
        [JsonProperty("serviceProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceProfileId { get; set; }

        /// <summary>
        /// Gets or sets CspProfileId.
        /// </summary>
        [JsonProperty("cspProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string CspProfileId { get; set; }

        /// <summary>
        /// Gets or sets ConfigFiles.
        /// </summary>
        [JsonProperty("configFiles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ConfigFileItem> ConfigFiles { get; set; }

        /// <summary>
        /// Gets or sets LinkedServiceInstances.
        /// </summary>
        [JsonProperty("linkedServiceInstances")]
        public List<Models.LinkedServiceInstance> LinkedServiceInstances
        {
            get
            {
                return this.linkedServiceInstances;
            }

            set
            {
                this.shouldSerialize["linkedServiceInstances"] = true;
                this.linkedServiceInstances = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedBy.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceLaunchRequestResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLinkedServiceInstances()
        {
            this.shouldSerialize["linkedServiceInstances"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLinkedServiceInstances()
        {
            return this.shouldSerialize["linkedServiceInstances"];
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
            return obj is ServiceLaunchRequestResult other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.ServiceVersion == null && other.ServiceVersion == null) || (this.ServiceVersion?.Equals(other.ServiceVersion) == true)) &&
                ((this.ServiceId == null && other.ServiceId == null) || (this.ServiceId?.Equals(other.ServiceId) == true)) &&
                ((this.ServiceProfileId == null && other.ServiceProfileId == null) || (this.ServiceProfileId?.Equals(other.ServiceProfileId) == true)) &&
                ((this.CspProfileId == null && other.CspProfileId == null) || (this.CspProfileId?.Equals(other.CspProfileId) == true)) &&
                ((this.ConfigFiles == null && other.ConfigFiles == null) || (this.ConfigFiles?.Equals(other.ConfigFiles) == true)) &&
                ((this.LinkedServiceInstances == null && other.LinkedServiceInstances == null) || (this.LinkedServiceInstances?.Equals(other.LinkedServiceInstances) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.ServiceVersion = {(this.ServiceVersion == null ? "null" : this.ServiceVersion == string.Empty ? "" : this.ServiceVersion)}");
            toStringOutput.Add($"this.ServiceId = {(this.ServiceId == null ? "null" : this.ServiceId == string.Empty ? "" : this.ServiceId)}");
            toStringOutput.Add($"this.ServiceProfileId = {(this.ServiceProfileId == null ? "null" : this.ServiceProfileId == string.Empty ? "" : this.ServiceProfileId)}");
            toStringOutput.Add($"this.CspProfileId = {(this.CspProfileId == null ? "null" : this.CspProfileId == string.Empty ? "" : this.CspProfileId)}");
            toStringOutput.Add($"this.ConfigFiles = {(this.ConfigFiles == null ? "null" : $"[{string.Join(", ", this.ConfigFiles)} ]")}");
            toStringOutput.Add($"this.LinkedServiceInstances = {(this.LinkedServiceInstances == null ? "null" : $"[{string.Join(", ", this.LinkedServiceInstances)} ]")}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
        }
    }
}