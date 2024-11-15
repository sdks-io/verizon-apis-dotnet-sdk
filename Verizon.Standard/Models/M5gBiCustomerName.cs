// <copyright file="M5gBiCustomerName.cs" company="APIMatic">
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
    /// M5gBiCustomerName.
    /// </summary>
    public class M5gBiCustomerName
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiCustomerName"/> class.
        /// </summary>
        public M5gBiCustomerName()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="M5gBiCustomerName"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="middleName">middleName.</param>
        /// <param name="title">title.</param>
        /// <param name="suffex">suffex.</param>
        public M5gBiCustomerName(
            string firstName = null,
            string lastName = null,
            string middleName = null,
            string title = null,
            string suffex = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.Title = title;
            this.Suffex = suffex;
        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("firstName", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("lastName", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets MiddleName.
        /// </summary>
        [JsonProperty("middleName", NullValueHandling = NullValueHandling.Ignore)]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Suffex.
        /// </summary>
        [JsonProperty("suffex", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffex { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"M5gBiCustomerName : ({string.Join(", ", toStringOutput)})";
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
            return obj is M5gBiCustomerName other &&                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.MiddleName == null && other.MiddleName == null) || (this.MiddleName?.Equals(other.MiddleName) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Suffex == null && other.Suffex == null) || (this.Suffex?.Equals(other.Suffex) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.MiddleName = {(this.MiddleName == null ? "null" : this.MiddleName)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Suffex = {(this.Suffex == null ? "null" : this.Suffex)}");
        }
    }
}