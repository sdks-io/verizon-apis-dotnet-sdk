// <copyright file="Category.cs" company="APIMatic">
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
    /// Category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="id">id.</param>
        /// <param name="categoryDescription">categoryDescription.</param>
        /// <param name="isVerizonCertified">isVerizonCertified.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public Category(
            string categoryName,
            string id = null,
            string categoryDescription = null,
            bool? isVerizonCertified = false,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string updatedBy = null)
        {
            this.Id = id;
            this.CategoryName = categoryName;
            this.CategoryDescription = categoryDescription;
            this.IsVerizonCertified = isVerizonCertified;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// Auto-generated unique Id eg: 58296746-57ee-44f8-8107-399b61d53967.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Any string value which is described as a category name.
        /// </summary>
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        /// <summary>
        /// Brief description about the category being created.
        /// </summary>
        [JsonProperty("categoryDescription", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryDescription { get; set; }

        /// <summary>
        /// Boolean value which implies if the category is verizon certified or not by default it is false.
        /// </summary>
        [JsonProperty("isVerizonCertified", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVerizonCertified { get; set; }

        /// <summary>
        /// System captured creation date and time when tag is created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// System captured date and time when the tag was last modified.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// User information who created the tag.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Last user information who made changes to tag.
        /// </summary>
        [JsonProperty("updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Category : ({string.Join(", ", toStringOutput)})";
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
            return obj is Category other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.CategoryName == null && other.CategoryName == null) || (this.CategoryName?.Equals(other.CategoryName) == true)) &&
                ((this.CategoryDescription == null && other.CategoryDescription == null) || (this.CategoryDescription?.Equals(other.CategoryDescription) == true)) &&
                ((this.IsVerizonCertified == null && other.IsVerizonCertified == null) || (this.IsVerizonCertified?.Equals(other.IsVerizonCertified) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.UpdatedBy == null && other.UpdatedBy == null) || (this.UpdatedBy?.Equals(other.UpdatedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.CategoryName = {(this.CategoryName == null ? "null" : this.CategoryName == string.Empty ? "" : this.CategoryName)}");
            toStringOutput.Add($"this.CategoryDescription = {(this.CategoryDescription == null ? "null" : this.CategoryDescription == string.Empty ? "" : this.CategoryDescription)}");
            toStringOutput.Add($"this.IsVerizonCertified = {(this.IsVerizonCertified == null ? "null" : this.IsVerizonCertified.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
        }
    }
}