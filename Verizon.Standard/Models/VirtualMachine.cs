// <copyright file="VirtualMachine.cs" company="APIMatic">
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
    /// VirtualMachine.
    /// </summary>
    public class VirtualMachine
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachine"/> class.
        /// </summary>
        public VirtualMachine()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachine"/> class.
        /// </summary>
        /// <param name="repository">repository.</param>
        /// <param name="templateType">templateType.</param>
        /// <param name="revision">revision.</param>
        /// <param name="values">values.</param>
        /// <param name="provider">provider.</param>
        public VirtualMachine(
            Models.EdgeServiceRepository repository,
            Models.TemplateTypeEnum templateType,
            Models.Revision revision = null,
            Models.EdgeServiceRepository values = null,
            Models.CloudProviderEnum? provider = null)
        {
            this.Repository = repository;
            this.Revision = revision;
            this.TemplateType = templateType;
            this.Values = values;
            this.Provider = provider;
        }

        /// <summary>
        /// Gets or sets Repository.
        /// </summary>
        [JsonProperty("repository")]
        public Models.EdgeServiceRepository Repository { get; set; }

        /// <summary>
        /// Gets or sets Revision.
        /// </summary>
        [JsonProperty("revision", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Revision Revision { get; set; }

        /// <summary>
        /// Type of the template to be used for deployment.
        /// </summary>
        [JsonProperty("templateType", ItemConverterType = typeof(StringEnumConverter))]
        public Models.TemplateTypeEnum TemplateType { get; set; }

        /// <summary>
        /// Gets or sets Values.
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Models.EdgeServiceRepository Values { get; set; }

        /// <summary>
        /// Cloud provider where you plan to provision and operate your Kubernetes cluster.
        /// </summary>
        [JsonProperty("provider", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CloudProviderEnum? Provider { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VirtualMachine : ({string.Join(", ", toStringOutput)})";
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
            return obj is VirtualMachine other &&                ((this.Repository == null && other.Repository == null) || (this.Repository?.Equals(other.Repository) == true)) &&
                ((this.Revision == null && other.Revision == null) || (this.Revision?.Equals(other.Revision) == true)) &&
                this.TemplateType.Equals(other.TemplateType) &&
                ((this.Values == null && other.Values == null) || (this.Values?.Equals(other.Values) == true)) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Repository = {(this.Repository == null ? "null" : this.Repository.ToString())}");
            toStringOutput.Add($"this.Revision = {(this.Revision == null ? "null" : this.Revision.ToString())}");
            toStringOutput.Add($"this.TemplateType = {this.TemplateType}");
            toStringOutput.Add($"this.Values = {(this.Values == null ? "null" : this.Values.ToString())}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
        }
    }
}