// <copyright file="DeviceGroup.cs" company="APIMatic">
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
    /// DeviceGroup.
    /// </summary>
    public class DeviceGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroup"/> class.
        /// </summary>
        public DeviceGroup()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGroup"/> class.
        /// </summary>
        /// <param name="description">description.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="isDefaultGroup">isDefaultGroup.</param>
        /// <param name="name">name.</param>
        public DeviceGroup(
            string description = null,
            List<Models.CustomFields> extendedAttributes = null,
            bool? isDefaultGroup = null,
            string name = null)
        {
            this.Description = description;
            this.ExtendedAttributes = extendedAttributes;
            this.IsDefaultGroup = isDefaultGroup;
            this.Name = name;
        }

        /// <summary>
        /// The description of the device group.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Any extended attributes for the device group, as Key and Value pairs.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <summary>
        /// Identifies the default device group.
        /// </summary>
        [JsonProperty("isDefaultGroup", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultGroup { get; set; }

        /// <summary>
        /// The name of the device group.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceGroup : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceGroup other &&                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true)) &&
                ((this.IsDefaultGroup == null && other.IsDefaultGroup == null) || (this.IsDefaultGroup?.Equals(other.IsDefaultGroup) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"this.IsDefaultGroup = {(this.IsDefaultGroup == null ? "null" : this.IsDefaultGroup.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}