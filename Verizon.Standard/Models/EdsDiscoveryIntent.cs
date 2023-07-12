// <copyright file="EdsDiscoveryIntent.cs" company="APIMatic">
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
    /// EdsDiscoveryIntent.
    /// </summary>
    public class EdsDiscoveryIntent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdsDiscoveryIntent"/> class.
        /// </summary>
        public EdsDiscoveryIntent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EdsDiscoveryIntent"/> class.
        /// </summary>
        /// <param name="ueIdentity">ueIdentity.</param>
        /// <param name="ueIdentityType">ueIdentityType.</param>
        public EdsDiscoveryIntent(
            string ueIdentity = null,
            Models.UEIdentityTypeEnum? ueIdentityType = Models.UEIdentityTypeEnum.IPAddress)
        {
            this.UeIdentity = ueIdentity;
            this.UeIdentityType = ueIdentityType;
        }

        /// <summary>
        /// UEIdentity to discover EDS location service.
        /// </summary>
        [JsonProperty("ueIdentity", NullValueHandling = NullValueHandling.Ignore)]
        public string UeIdentity { get; set; }

        /// <summary>
        /// Default type for ueIdentityType.
        /// </summary>
        [JsonProperty("ueIdentityType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.UEIdentityTypeEnum? UeIdentityType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EdsDiscoveryIntent : ({string.Join(", ", toStringOutput)})";
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
            return obj is EdsDiscoveryIntent other &&                ((this.UeIdentity == null && other.UeIdentity == null) || (this.UeIdentity?.Equals(other.UeIdentity) == true)) &&
                ((this.UeIdentityType == null && other.UeIdentityType == null) || (this.UeIdentityType?.Equals(other.UeIdentityType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UeIdentity = {(this.UeIdentity == null ? "null" : this.UeIdentity == string.Empty ? "" : this.UeIdentity)}");
            toStringOutput.Add($"this.UeIdentityType = {(this.UeIdentityType == null ? "null" : this.UeIdentityType.ToString())}");
        }
    }
}