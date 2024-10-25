// <copyright file="M5gBiAddress.cs" company="APIMatic">
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
    /// M5gBiAddress.
    /// </summary>
    public class M5gBiAddress
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiAddress"/> class.
        /// </summary>
        public M5gBiAddress()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiAddress"/> class.
        /// </summary>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="zip">zip.</param>
        /// <param name="zip4">zip+4.</param>
        /// <param name="phone">phone.</param>
        /// <param name="phoneType">phoneType.</param>
        /// <param name="emailAddress">emailAddress.</param>
        public M5gBiAddress(
            string addressLine1 = null,
            string city = null,
            string state = null,
            string zip = null,
            string zip4 = null,
            string phone = null,
            string phoneType = null,
            string emailAddress = null)
        {
            this.AddressLine1 = addressLine1;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Zip4 = zip4;
            this.Phone = phone;
            this.PhoneType = phoneType;
            this.EmailAddress = emailAddress;
        }

        /// <summary>
        /// Gets or sets AddressLine1.
        /// </summary>
        [JsonProperty("addressLine1", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets Zip.
        /// </summary>
        [JsonProperty("zip", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip { get; set; }

        /// <summary>
        /// Gets or sets Zip4.
        /// </summary>
        [JsonProperty("zip+4", NullValueHandling = NullValueHandling.Ignore)]
        public string Zip4 { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets PhoneType.
        /// </summary>
        [JsonProperty("phoneType", NullValueHandling = NullValueHandling.Ignore)]
        public string PhoneType { get; set; }

        /// <summary>
        /// Gets or sets EmailAddress.
        /// </summary>
        [JsonProperty("emailAddress", NullValueHandling = NullValueHandling.Ignore)]
        public string EmailAddress { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M5gBiAddress : ({string.Join(", ", toStringOutput)})";
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
            return obj is M5gBiAddress other &&                ((this.AddressLine1 == null && other.AddressLine1 == null) || (this.AddressLine1?.Equals(other.AddressLine1) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Zip == null && other.Zip == null) || (this.Zip?.Equals(other.Zip) == true)) &&
                ((this.Zip4 == null && other.Zip4 == null) || (this.Zip4?.Equals(other.Zip4) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.PhoneType == null && other.PhoneType == null) || (this.PhoneType?.Equals(other.PhoneType) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AddressLine1 = {(this.AddressLine1 == null ? "null" : this.AddressLine1)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Zip = {(this.Zip == null ? "null" : this.Zip)}");
            toStringOutput.Add($"this.Zip4 = {(this.Zip4 == null ? "null" : this.Zip4)}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.PhoneType = {(this.PhoneType == null ? "null" : this.PhoneType)}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
        }
    }
}