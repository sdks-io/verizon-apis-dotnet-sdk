// <copyright file="ServiceDependency.cs" company="APIMatic">
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
    /// ServiceDependency.
    /// </summary>
    public class ServiceDependency
    {
        private Models.ServiceDependencyPackageTypeEnum? packageType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "packageType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDependency"/> class.
        /// </summary>
        public ServiceDependency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceDependency"/> class.
        /// </summary>
        /// <param name="rank">rank.</param>
        /// <param name="type">type.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="version">version.</param>
        /// <param name="packageType">packageType.</param>
        public ServiceDependency(
            int? rank = null,
            Models.ServiceTypeEnum? type = null,
            string serviceName = null,
            string version = null,
            Models.ServiceDependencyPackageTypeEnum? packageType = null)
        {
            this.Rank = rank;
            this.Type = type;
            this.ServiceName = serviceName;
            this.Version = version;
            if (packageType != null)
            {
                this.PackageType = packageType;
            }

        }

        /// <summary>
        /// The dependency rank.
        /// </summary>
        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rank { get; set; }

        /// <summary>
        /// Service Type e.g. Installation, Operations, Custom.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceTypeEnum? Type { get; set; }

        /// <summary>
        /// Name of the dependent service.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Version of the service being used.
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// Deployment package type.
        /// </summary>
        [JsonProperty("packageType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.ServiceDependencyPackageTypeEnum? PackageType
        {
            get
            {
                return this.packageType;
            }

            set
            {
                this.shouldSerialize["packageType"] = true;
                this.packageType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceDependency : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPackageType()
        {
            this.shouldSerialize["packageType"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePackageType()
        {
            return this.shouldSerialize["packageType"];
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
            return obj is ServiceDependency other &&                ((this.Rank == null && other.Rank == null) || (this.Rank?.Equals(other.Rank) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.PackageType == null && other.PackageType == null) || (this.PackageType?.Equals(other.PackageType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Rank = {(this.Rank == null ? "null" : this.Rank.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version == string.Empty ? "" : this.Version)}");
            toStringOutput.Add($"this.PackageType = {(this.PackageType == null ? "null" : this.PackageType.ToString())}");
        }
    }
}