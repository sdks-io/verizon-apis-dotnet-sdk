// <copyright file="V2ListOfLicensesToRemoveResult.cs" company="APIMatic">
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
    /// V2ListOfLicensesToRemoveResult.
    /// </summary>
    public class V2ListOfLicensesToRemoveResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemoveResult"/> class.
        /// </summary>
        public V2ListOfLicensesToRemoveResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V2ListOfLicensesToRemoveResult"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="deviceList">deviceList.</param>
        public V2ListOfLicensesToRemoveResult(
            int count,
            List<string> deviceList)
        {
            this.Count = count;
            this.DeviceList = deviceList;
        }

        /// <summary>
        /// The number of devices.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Device IMEI list.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<string> DeviceList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"V2ListOfLicensesToRemoveResult : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is V2ListOfLicensesToRemoveResult other &&
                (this.Count.Equals(other.Count)) &&
                (this.DeviceList == null && other.DeviceList == null ||
                 this.DeviceList?.Equals(other.DeviceList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Count = {this.Count}");
            toStringOutput.Add($"DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
        }
    }
}