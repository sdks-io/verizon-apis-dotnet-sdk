// <copyright file="AdvanceConfiguration.cs" company="APIMatic">
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
    /// AdvanceConfiguration.
    /// </summary>
    public class AdvanceConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceConfiguration"/> class.
        /// </summary>
        public AdvanceConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvanceConfiguration"/> class.
        /// </summary>
        /// <param name="serviceRoleArn">serviceRoleArn.</param>
        /// <param name="serviceRolePermissionBoundary">serviceRolePermissionBoundary.</param>
        /// <param name="enableProxy">enableProxy.</param>
        /// <param name="httpProxy">httpProxy.</param>
        /// <param name="httpsProxy">httpsProxy.</param>
        /// <param name="noProxy">noProxy.</param>
        /// <param name="proxyRootCA">proxyRootCA.</param>
        /// <param name="enableTlsTraffic">enableTlsTraffic.</param>
        /// <param name="enableAutoApprove">enableAutoApprove.</param>
        /// <param name="enableMultiMaster">enableMultiMaster.</param>
        /// <param name="enableDedicatedMaster">enableDedicatedMaster.</param>
        public AdvanceConfiguration(
            string serviceRoleArn = null,
            string serviceRolePermissionBoundary = null,
            bool? enableProxy = false,
            string httpProxy = null,
            string httpsProxy = null,
            string noProxy = null,
            string proxyRootCA = null,
            bool? enableTlsTraffic = false,
            bool? enableAutoApprove = false,
            bool? enableMultiMaster = false,
            bool? enableDedicatedMaster = false)
        {
            this.ServiceRoleArn = serviceRoleArn;
            this.ServiceRolePermissionBoundary = serviceRolePermissionBoundary;
            this.EnableProxy = enableProxy;
            this.HttpProxy = httpProxy;
            this.HttpsProxy = httpsProxy;
            this.NoProxy = noProxy;
            this.ProxyRootCA = proxyRootCA;
            this.EnableTlsTraffic = enableTlsTraffic;
            this.EnableAutoApprove = enableAutoApprove;
            this.EnableMultiMaster = enableMultiMaster;
            this.EnableDedicatedMaster = enableDedicatedMaster;
        }

        /// <summary>
        /// Gets or sets ServiceRoleArn.
        /// </summary>
        [JsonProperty("serviceRoleArn", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceRoleArn { get; set; }

        /// <summary>
        /// Gets or sets ServiceRolePermissionBoundary.
        /// </summary>
        [JsonProperty("serviceRolePermissionBoundary", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceRolePermissionBoundary { get; set; }

        /// <summary>
        /// Gets or sets EnableProxy.
        /// </summary>
        [JsonProperty("enableProxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableProxy { get; set; }

        /// <summary>
        /// Gets or sets HttpProxy.
        /// </summary>
        [JsonProperty("httpProxy", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpProxy { get; set; }

        /// <summary>
        /// Gets or sets HttpsProxy.
        /// </summary>
        [JsonProperty("httpsProxy", NullValueHandling = NullValueHandling.Ignore)]
        public string HttpsProxy { get; set; }

        /// <summary>
        /// Gets or sets NoProxy.
        /// </summary>
        [JsonProperty("noProxy", NullValueHandling = NullValueHandling.Ignore)]
        public string NoProxy { get; set; }

        /// <summary>
        /// Gets or sets ProxyRootCA.
        /// </summary>
        [JsonProperty("proxyRootCA", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyRootCA { get; set; }

        /// <summary>
        /// Gets or sets EnableTlsTraffic.
        /// </summary>
        [JsonProperty("enableTlsTraffic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTlsTraffic { get; set; }

        /// <summary>
        /// Gets or sets EnableAutoApprove.
        /// </summary>
        [JsonProperty("enableAutoApprove", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoApprove { get; set; }

        /// <summary>
        /// Gets or sets EnableMultiMaster.
        /// </summary>
        [JsonProperty("enableMultiMaster", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMultiMaster { get; set; }

        /// <summary>
        /// Gets or sets EnableDedicatedMaster.
        /// </summary>
        [JsonProperty("enableDedicatedMaster", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDedicatedMaster { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdvanceConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdvanceConfiguration other &&                ((this.ServiceRoleArn == null && other.ServiceRoleArn == null) || (this.ServiceRoleArn?.Equals(other.ServiceRoleArn) == true)) &&
                ((this.ServiceRolePermissionBoundary == null && other.ServiceRolePermissionBoundary == null) || (this.ServiceRolePermissionBoundary?.Equals(other.ServiceRolePermissionBoundary) == true)) &&
                ((this.EnableProxy == null && other.EnableProxy == null) || (this.EnableProxy?.Equals(other.EnableProxy) == true)) &&
                ((this.HttpProxy == null && other.HttpProxy == null) || (this.HttpProxy?.Equals(other.HttpProxy) == true)) &&
                ((this.HttpsProxy == null && other.HttpsProxy == null) || (this.HttpsProxy?.Equals(other.HttpsProxy) == true)) &&
                ((this.NoProxy == null && other.NoProxy == null) || (this.NoProxy?.Equals(other.NoProxy) == true)) &&
                ((this.ProxyRootCA == null && other.ProxyRootCA == null) || (this.ProxyRootCA?.Equals(other.ProxyRootCA) == true)) &&
                ((this.EnableTlsTraffic == null && other.EnableTlsTraffic == null) || (this.EnableTlsTraffic?.Equals(other.EnableTlsTraffic) == true)) &&
                ((this.EnableAutoApprove == null && other.EnableAutoApprove == null) || (this.EnableAutoApprove?.Equals(other.EnableAutoApprove) == true)) &&
                ((this.EnableMultiMaster == null && other.EnableMultiMaster == null) || (this.EnableMultiMaster?.Equals(other.EnableMultiMaster) == true)) &&
                ((this.EnableDedicatedMaster == null && other.EnableDedicatedMaster == null) || (this.EnableDedicatedMaster?.Equals(other.EnableDedicatedMaster) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceRoleArn = {(this.ServiceRoleArn == null ? "null" : this.ServiceRoleArn == string.Empty ? "" : this.ServiceRoleArn)}");
            toStringOutput.Add($"this.ServiceRolePermissionBoundary = {(this.ServiceRolePermissionBoundary == null ? "null" : this.ServiceRolePermissionBoundary == string.Empty ? "" : this.ServiceRolePermissionBoundary)}");
            toStringOutput.Add($"this.EnableProxy = {(this.EnableProxy == null ? "null" : this.EnableProxy.ToString())}");
            toStringOutput.Add($"this.HttpProxy = {(this.HttpProxy == null ? "null" : this.HttpProxy == string.Empty ? "" : this.HttpProxy)}");
            toStringOutput.Add($"this.HttpsProxy = {(this.HttpsProxy == null ? "null" : this.HttpsProxy == string.Empty ? "" : this.HttpsProxy)}");
            toStringOutput.Add($"this.NoProxy = {(this.NoProxy == null ? "null" : this.NoProxy == string.Empty ? "" : this.NoProxy)}");
            toStringOutput.Add($"this.ProxyRootCA = {(this.ProxyRootCA == null ? "null" : this.ProxyRootCA == string.Empty ? "" : this.ProxyRootCA)}");
            toStringOutput.Add($"this.EnableTlsTraffic = {(this.EnableTlsTraffic == null ? "null" : this.EnableTlsTraffic.ToString())}");
            toStringOutput.Add($"this.EnableAutoApprove = {(this.EnableAutoApprove == null ? "null" : this.EnableAutoApprove.ToString())}");
            toStringOutput.Add($"this.EnableMultiMaster = {(this.EnableMultiMaster == null ? "null" : this.EnableMultiMaster.ToString())}");
            toStringOutput.Add($"this.EnableDedicatedMaster = {(this.EnableDedicatedMaster == null ? "null" : this.EnableDedicatedMaster.ToString())}");
        }
    }
}