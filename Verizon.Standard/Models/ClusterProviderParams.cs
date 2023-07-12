// <copyright file="ClusterProviderParams.cs" company="APIMatic">
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
    /// ClusterProviderParams.
    /// </summary>
    public class ClusterProviderParams
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterProviderParams"/> class.
        /// </summary>
        public ClusterProviderParams()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClusterProviderParams"/> class.
        /// </summary>
        /// <param name="createdAt">created_at.</param>
        /// <param name="modifiedAt">modified_at.</param>
        /// <param name="mParams">params.</param>
        /// <param name="paramsType">params_type.</param>
        /// <param name="genData">gen_data.</param>
        public ClusterProviderParams(
            string createdAt = null,
            string modifiedAt = null,
            string mParams = null,
            int? paramsType = null,
            string genData = null)
        {
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.MParams = mParams;
            this.ParamsType = paramsType;
            this.GenData = genData;
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets ModifiedAt.
        /// </summary>
        [JsonProperty("modified_at", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }

        /// <summary>
        /// Gets or sets MParams.
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public string MParams { get; set; }

        /// <summary>
        /// Gets or sets ParamsType.
        /// </summary>
        [JsonProperty("params_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParamsType { get; set; }

        /// <summary>
        /// Gets or sets GenData.
        /// </summary>
        [JsonProperty("gen_data", NullValueHandling = NullValueHandling.Ignore)]
        public string GenData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ClusterProviderParams : ({string.Join(", ", toStringOutput)})";
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
            return obj is ClusterProviderParams other &&                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.ModifiedAt == null && other.ModifiedAt == null) || (this.ModifiedAt?.Equals(other.ModifiedAt) == true)) &&
                ((this.MParams == null && other.MParams == null) || (this.MParams?.Equals(other.MParams) == true)) &&
                ((this.ParamsType == null && other.ParamsType == null) || (this.ParamsType?.Equals(other.ParamsType) == true)) &&
                ((this.GenData == null && other.GenData == null) || (this.GenData?.Equals(other.GenData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt == string.Empty ? "" : this.CreatedAt)}");
            toStringOutput.Add($"this.ModifiedAt = {(this.ModifiedAt == null ? "null" : this.ModifiedAt == string.Empty ? "" : this.ModifiedAt)}");
            toStringOutput.Add($"this.MParams = {(this.MParams == null ? "null" : this.MParams == string.Empty ? "" : this.MParams)}");
            toStringOutput.Add($"this.ParamsType = {(this.ParamsType == null ? "null" : this.ParamsType.ToString())}");
            toStringOutput.Add($"this.GenData = {(this.GenData == null ? "null" : this.GenData == string.Empty ? "" : this.GenData)}");
        }
    }
}