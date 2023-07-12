// <copyright file="ServiceFile.cs" company="APIMatic">
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
    /// ServiceFile.
    /// </summary>
    public class ServiceFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFile"/> class.
        /// </summary>
        public ServiceFile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceFile"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="serviceVersion">serviceVersion.</param>
        /// <param name="file">file.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="categoryVersion">categoryVersion.</param>
        /// <param name="categoryType">categoryType.</param>
        /// <param name="validationStatus">validationStatus.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updatedBy">updatedBy.</param>
        public ServiceFile(
            string id = null,
            string serviceName = null,
            string serviceVersion = null,
            string file = null,
            string categoryName = null,
            string categoryVersion = null,
            string categoryType = null,
            string validationStatus = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string updatedBy = null)
        {
            this.Id = id;
            this.ServiceName = serviceName;
            this.ServiceVersion = serviceVersion;
            this.File = file;
            this.CategoryName = categoryName;
            this.CategoryVersion = categoryVersion;
            this.CategoryType = categoryType;
            this.ValidationStatus = validationStatus;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.UpdatedBy = updatedBy;
        }

        /// <summary>
        /// System generated unique UUID.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Service name to which the file is going to be associated.
        /// </summary>
        [JsonProperty("serviceName", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Version of the service being used.
        /// </summary>
        [JsonProperty("serviceVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// File which is to be uploaded should be provided in formData.
        /// </summary>
        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public string File { get; set; }

        /// <summary>
        /// Name of the workload being used in the service.
        /// </summary>
        [JsonProperty("categoryName", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Version of the workload being used in the service.
        /// </summary>
        [JsonProperty("categoryVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryVersion { get; set; }

        /// <summary>
        /// Type of the workload being used in the service eg: use WORKLOAD_TGZ to upload the workload file in tgz format.
        /// </summary>
        [JsonProperty("categoryType", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryType { get; set; }

        /// <summary>
        /// Gives the success and failure response for the validation.
        /// </summary>
        [JsonProperty("validationStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidationStatus { get; set; }

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

            return $"ServiceFile : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceFile other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.ServiceName == null && other.ServiceName == null) || (this.ServiceName?.Equals(other.ServiceName) == true)) &&
                ((this.ServiceVersion == null && other.ServiceVersion == null) || (this.ServiceVersion?.Equals(other.ServiceVersion) == true)) &&
                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                ((this.CategoryName == null && other.CategoryName == null) || (this.CategoryName?.Equals(other.CategoryName) == true)) &&
                ((this.CategoryVersion == null && other.CategoryVersion == null) || (this.CategoryVersion?.Equals(other.CategoryVersion) == true)) &&
                ((this.CategoryType == null && other.CategoryType == null) || (this.CategoryType?.Equals(other.CategoryType) == true)) &&
                ((this.ValidationStatus == null && other.ValidationStatus == null) || (this.ValidationStatus?.Equals(other.ValidationStatus) == true)) &&
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
            toStringOutput.Add($"this.ServiceName = {(this.ServiceName == null ? "null" : this.ServiceName == string.Empty ? "" : this.ServiceName)}");
            toStringOutput.Add($"this.ServiceVersion = {(this.ServiceVersion == null ? "null" : this.ServiceVersion == string.Empty ? "" : this.ServiceVersion)}");
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File == string.Empty ? "" : this.File)}");
            toStringOutput.Add($"this.CategoryName = {(this.CategoryName == null ? "null" : this.CategoryName == string.Empty ? "" : this.CategoryName)}");
            toStringOutput.Add($"this.CategoryVersion = {(this.CategoryVersion == null ? "null" : this.CategoryVersion == string.Empty ? "" : this.CategoryVersion)}");
            toStringOutput.Add($"this.CategoryType = {(this.CategoryType == null ? "null" : this.CategoryType == string.Empty ? "" : this.CategoryType)}");
            toStringOutput.Add($"this.ValidationStatus = {(this.ValidationStatus == null ? "null" : this.ValidationStatus == string.Empty ? "" : this.ValidationStatus)}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.UpdatedBy = {(this.UpdatedBy == null ? "null" : this.UpdatedBy == string.Empty ? "" : this.UpdatedBy)}");
        }
    }
}