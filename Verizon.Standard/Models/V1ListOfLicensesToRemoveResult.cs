// <copyright file="V1ListOfLicensesToRemoveResult.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace Verizon.Standard.Models
{
    /// <summary>
    /// V1ListOfLicensesToRemoveResult.
    /// </summary>
    public class V1ListOfLicensesToRemoveResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemoveResult"/> class.
        /// </summary>
        public V1ListOfLicensesToRemoveResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1ListOfLicensesToRemoveResult"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="deviceList">deviceList.</param>
        public V1ListOfLicensesToRemoveResult(
            int? count = null,
            List<string> deviceList = null)
        {
            this.Count = count;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// The total number of devices on the cancellation candidate list.
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// The IMEIs of the devices.
        /// </summary>
        [JsonProperty("deviceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V1ListOfLicensesToRemoveResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V1ListOfLicensesToRemoveResult other &&
                (this.Count == null && other.Count == null ||
                 this.Count?.Equals(other.Count) == true) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Count = {(this.Count == null ? "null" : this.Count.ToString())}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}