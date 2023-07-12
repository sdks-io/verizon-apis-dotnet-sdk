// <copyright file="VendorInformation.cs" company="APIMatic">
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
    /// VendorInformation.
    /// </summary>
    public class VendorInformation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorInformation"/> class.
        /// </summary>
        public VendorInformation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorInformation"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="primaryEmail">primaryEmail.</param>
        /// <param name="secondaryEmail">secondaryEmail.</param>
        /// <param name="contactNumber">contactNumber.</param>
        public VendorInformation(
            string id,
            string name,
            string primaryEmail = null,
            string secondaryEmail = null,
            string contactNumber = null)
        {
            this.Id = id;
            this.Name = name;
            this.PrimaryEmail = primaryEmail;
            this.SecondaryEmail = secondaryEmail;
            this.ContactNumber = contactNumber;
        }

        /// <summary>
        /// ID of the vendor.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the vendor.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Primary email of the vendor.
        /// </summary>
        [JsonProperty("primaryEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryEmail { get; set; }

        /// <summary>
        /// Secondary email of the vendor.
        /// </summary>
        [JsonProperty("secondaryEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryEmail { get; set; }

        /// <summary>
        /// Contact number of the vendor.
        /// </summary>
        [JsonProperty("contactNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string ContactNumber { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VendorInformation : ({string.Join(", ", toStringOutput)})";
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
            return obj is VendorInformation other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.PrimaryEmail == null && other.PrimaryEmail == null) || (this.PrimaryEmail?.Equals(other.PrimaryEmail) == true)) &&
                ((this.SecondaryEmail == null && other.SecondaryEmail == null) || (this.SecondaryEmail?.Equals(other.SecondaryEmail) == true)) &&
                ((this.ContactNumber == null && other.ContactNumber == null) || (this.ContactNumber?.Equals(other.ContactNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.PrimaryEmail = {(this.PrimaryEmail == null ? "null" : this.PrimaryEmail == string.Empty ? "" : this.PrimaryEmail)}");
            toStringOutput.Add($"this.SecondaryEmail = {(this.SecondaryEmail == null ? "null" : this.SecondaryEmail == string.Empty ? "" : this.SecondaryEmail)}");
            toStringOutput.Add($"this.ContactNumber = {(this.ContactNumber == null ? "null" : this.ContactNumber == string.Empty ? "" : this.ContactNumber)}");
        }
    }
}