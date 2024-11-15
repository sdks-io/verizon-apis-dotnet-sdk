// <copyright file="DeviceGroupUpdateRequest.cs" company="APIMatic">
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
    /// DeviceGroupUpdateRequest.
    /// </summary>
    public class DeviceGroupUpdateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupUpdateRequest"/> class.
        /// </summary>
        public DeviceGroupUpdateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroupUpdateRequest"/> class.
        /// </summary>
        /// <param name="devicesToAdd">devicesToAdd.</param>
        /// <param name="devicesToRemove">devicesToRemove.</param>
        /// <param name="newGroupDescription">newGroupDescription.</param>
        /// <param name="newGroupName">newGroupName.</param>
        public DeviceGroupUpdateRequest(
            List<Models.DeviceId> devicesToAdd = null,
            List<Models.DeviceId> devicesToRemove = null,
            string newGroupDescription = null,
            string newGroupName = null)
        {
            this.DevicesToAdd = devicesToAdd;
            this.DevicesToRemove = devicesToRemove;
            this.NewGroupDescription = newGroupDescription;
            this.NewGroupName = newGroupName;
        }

        /// <summary>
        /// Zero or more devices to add to the device group, specified by device ID. The devices will be removed from their current device groups. You can use POST /devices/actions/list to get a list of all devices in the account.
        /// </summary>
        [JsonProperty("devicesToAdd", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToAdd { get; set; }

        /// <summary>
        /// Zero or more devices to remove from the device group, specified by device ID. The devices will be added to the default device group.
        /// </summary>
        [JsonProperty("devicesToRemove", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId> DevicesToRemove { get; set; }

        /// <summary>
        /// A new description for the device group. Do not include this parameter to leave the group description unchanged.
        /// </summary>
        [JsonProperty("newGroupDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupDescription { get; set; }

        /// <summary>
        /// A new name for the device group. Do not include this parameter if you want to leave the group name unchanged.
        /// </summary>
        [JsonProperty("newGroupName", NullValueHandling = NullValueHandling.Ignore)]
        public string NewGroupName { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceGroupUpdateRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceGroupUpdateRequest other &&                ((this.DevicesToAdd == null && other.DevicesToAdd == null) || (this.DevicesToAdd?.Equals(other.DevicesToAdd) == true)) &&
                ((this.DevicesToRemove == null && other.DevicesToRemove == null) || (this.DevicesToRemove?.Equals(other.DevicesToRemove) == true)) &&
                ((this.NewGroupDescription == null && other.NewGroupDescription == null) || (this.NewGroupDescription?.Equals(other.NewGroupDescription) == true)) &&
                ((this.NewGroupName == null && other.NewGroupName == null) || (this.NewGroupName?.Equals(other.NewGroupName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DevicesToAdd = {(this.DevicesToAdd == null ? "null" : $"[{string.Join(", ", this.DevicesToAdd)} ]")}");
            toStringOutput.Add($"this.DevicesToRemove = {(this.DevicesToRemove == null ? "null" : $"[{string.Join(", ", this.DevicesToRemove)} ]")}");
            toStringOutput.Add($"this.NewGroupDescription = {(this.NewGroupDescription == null ? "null" : this.NewGroupDescription)}");
            toStringOutput.Add($"this.NewGroupName = {(this.NewGroupName == null ? "null" : this.NewGroupName)}");
        }
    }
}