// <copyright file="CreateDeviceGroupRequest.cs" company="APIMatic">
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
    /// CreateDeviceGroupRequest.
    /// </summary>
    public class CreateDeviceGroupRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceGroupRequest"/> class.
        /// </summary>
        public CreateDeviceGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDeviceGroupRequest"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        /// <param name="groupDescription">groupDescription.</param>
        /// <param name="groupName">groupName.</param>
        public CreateDeviceGroupRequest(
            string accountName = null,
            List<Models.DeviceId> devicesToAdd = null,
            string groupDescription = null,
            string groupName = null)
        {
            this.AccountName = accountName;
            this.DevicesToAdd = devicesToAdd;
            this.GroupDescription = groupDescription;
            this.GroupName = groupName;
        }

        /// <summary>
        /// The Verizon billing account that the device group will belong to. An account name is usually numeric, and must include any leading zeros.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Zero or more devices to add to the device group. You can use POST /devices/actions/list to get a list of all devices in the account.
        /// </summary>
        [JsonProperty("devicesToAdd", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToAdd { get; set; }

        /// <summary>
        /// A description for the device group.
        /// </summary>
        [JsonProperty("groupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDescription { get; set; }

        /// <summary>
        /// The name for the new device group. This name must be unique within the specified account.
        /// </summary>
        [JsonProperty("groupName", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateDeviceGroupRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateDeviceGroupRequest other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DevicesToAdd == null && other.DevicesToAdd == null) || (this.DevicesToAdd?.Equals(other.DevicesToAdd) == true)) &&
                ((this.GroupDescription == null && other.GroupDescription == null) || (this.GroupDescription?.Equals(other.GroupDescription) == true)) &&
                ((this.GroupName == null && other.GroupName == null) || (this.GroupName?.Equals(other.GroupName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName == string.Empty ? "" : this.AccountName)}");
            toStringOutput.Add($"this.DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");
            toStringOutput.Add($"this.GroupDescription = {(this.GroupDescription == null ? "null" : this.GroupDescription == string.Empty ? "" : this.GroupDescription)}");
            toStringOutput.Add($"this.GroupName = {(this.GroupName == null ? "null" : this.GroupName == string.Empty ? "" : this.GroupName)}");
        }
    }
}