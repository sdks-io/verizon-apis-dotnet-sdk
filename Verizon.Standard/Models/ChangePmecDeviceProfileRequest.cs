// <copyright file="ChangePmecDeviceProfileRequest.cs" company="APIMatic">
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
    /// ChangePmecDeviceProfileRequest.
    /// </summary>
    public class ChangePmecDeviceProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePmecDeviceProfileRequest"/> class.
        /// </summary>
        public ChangePmecDeviceProfileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePmecDeviceProfileRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="deviceList">deviceList.</param>
        /// <param name="newProfile">newProfile.</param>
        public ChangePmecDeviceProfileRequest(
            string accountName,
            List<Models.MECDeviceList> deviceList,
            string newProfile)
        {
            this.AccountName = accountName;
            this.DeviceList = deviceList;
            this.NewProfile = newProfile;
        }

        /// <summary>
        /// Gets or sets AccountName.
        /// </summary>
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets DeviceList.
        /// </summary>
        [JsonProperty("deviceList")]
        public List<Models.MECDeviceList> DeviceList { get; set; }

        /// <summary>
        /// Gets or sets NewProfile.
        /// </summary>
        [JsonProperty("newProfile")]
        public string NewProfile { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ChangePmecDeviceProfileRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ChangePmecDeviceProfileRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DeviceList == null && other.DeviceList == null) || (this.DeviceList?.Equals(other.DeviceList) == true)) &&
                ((this.NewProfile == null && other.NewProfile == null) || (this.NewProfile?.Equals(other.NewProfile) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DeviceList = {(this.DeviceList == null ? "null" : $"[{string.Join(", ", this.DeviceList)} ]")}");
            toStringOutput.Add($"this.NewProfile = {(this.NewProfile == null ? "null" : this.NewProfile)}");
        }
    }
}