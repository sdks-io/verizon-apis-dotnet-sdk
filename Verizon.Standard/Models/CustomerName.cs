// <copyright file="CustomerName.cs" company="APIMatic">
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
    /// CustomerName.
    /// </summary>
    public class CustomerName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerName"/> class.
        /// </summary>
        public CustomerName()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerName"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="title">title.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="suffix">suffix.</param>
        public CustomerName(
            string firstName,
            string lastName,
            string title = null,
            string middleName = null,
            string suffix = null)
        {
            this.Title = title;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Suffix = suffix;
        }

        /// <summary>
        /// An optional title for the customer, such as “Mr.” or “Dr.”
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// The customer's first name.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The customer's middle name.
        /// </summary>
        [JsonProperty("middleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The customer's last name.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// An optional suffix for the customer name, such as “Jr.” or “III.”
        /// </summary>
        [JsonProperty("suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerName : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerName other &&                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.MiddleName == null && other.MiddleName == null) || (this.MiddleName?.Equals(other.MiddleName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Suffix == null && other.Suffix == null) || (this.Suffix?.Equals(other.Suffix) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title == string.Empty ? "" : this.Title)}");
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName == string.Empty ? "" : this.FirstName)}");
            toStringOutput.Add($"this.MiddleName = {(this.MiddleName == null ? "null" : this.MiddleName == string.Empty ? "" : this.MiddleName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName == string.Empty ? "" : this.LastName)}");
            toStringOutput.Add($"this.Suffix = {(this.Suffix == null ? "null" : this.Suffix == string.Empty ? "" : this.Suffix)}");
        }
    }
}