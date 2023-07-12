// <copyright file="LocationRequest.cs" company="APIMatic">
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
    /// LocationRequest.
    /// </summary>
    public class LocationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRequest"/> class.
        /// </summary>
        public LocationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="accuracyMode">accuracyMode.</param>
        /// <param name="cacheMode">cacheMode.</param>
        /// <param name="deviceList">deviceList.</param>
        public LocationRequest(
            string accountName,
            int accuracyMode,
            Models.CacheModeEnum cacheMode,
            List<Models.DeviceInfo> deviceList)
        {
            this.AccountName = accountName;
            this.AccuracyMode = accuracyMode;
            this.CacheMode = cacheMode;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// Account identifier in "##########-#####".
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Accurary, currently only 0-coarse supported.
        /// </summary>
        [JsonProperty("accuracyMode")]
        public int AccuracyMode { get; set; }

        /// <summary>
        /// Location cache mode.
        /// </summary>
        [JsonProperty("cacheMode", ItemConverterType = typeof(StringEnumConverter))]
        public Models.CacheModeEnum CacheMode { get; set; }

        /// <summary>
        /// Device list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.DeviceInfo> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LocationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is LocationRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                this.AccuracyMode.Equals(other.AccuracyMode) &&
                this.CacheMode.Equals(other.CacheMode) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.AccuracyMode = {this.AccuracyMode}");
            toStringOutput.Add($"this.CacheMode = {this.CacheMode}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}