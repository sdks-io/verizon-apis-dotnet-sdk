// <copyright file="CSPProfile.cs" company="APIMatic">
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
    /// CSPProfile.
    /// </summary>
    public class CSPProfile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfile"/> class.
        /// </summary>
        public CSPProfile()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CSPProfile"/> class.
        /// </summary>
        /// <param name="cspProfileName">cspProfileName.</param>
        /// <param name="id">id.</param>
        /// <param name="usage">usage.</param>
        /// <param name="customerID">customerID.</param>
        /// <param name="projectName">projectName.</param>
        /// <param name="type">type.</param>
        /// <param name="awsCspProfile">awsCspProfile.</param>
        /// <param name="azureCspProfile">azureCspProfile.</param>
        /// <param name="defaultLocation">defaultLocation.</param>
        /// <param name="verificationTimeStamp">verificationTimeStamp.</param>
        /// <param name="state">state.</param>
        /// <param name="isValidated">isValidated.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        public CSPProfile(
            string cspProfileName,
            string id = null,
            long? usage = null,
            string customerID = null,
            string projectName = null,
            Models.CSPProfileTypeEnum? type = null,
            Models.AwsCspProfile awsCspProfile = null,
            Models.AzureCspProfile azureCspProfile = null,
            Models.DefaultLocation defaultLocation = null,
            DateTime? verificationTimeStamp = null,
            string state = null,
            bool? isValidated = false,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string lastModifiedBy = null)
        {
            this.Id = id;
            this.Usage = usage;
            this.CspProfileName = cspProfileName;
            this.CustomerID = customerID;
            this.ProjectName = projectName;
            this.Type = type;
            this.AwsCspProfile = awsCspProfile;
            this.AzureCspProfile = azureCspProfile;
            this.DefaultLocation = defaultLocation;
            this.VerificationTimeStamp = verificationTimeStamp;
            this.State = state;
            this.IsValidated = isValidated;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.LastModifiedBy = lastModifiedBy;
        }

        /// <summary>
        /// System generated unique identifier to identify the CSP Profile uniquely.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Usage tells how many services are using the CSP Profile. Only CSP Profile with 0 usage count be allowed to delete.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public long? Usage { get; set; }

        /// <summary>
        /// Name of the cloud credential to uniquely identify the CSP.
        /// </summary>
        [JsonProperty("cspProfileName")]
        public string CspProfileName { get; set; }

        /// <summary>
        /// Unique identification of the organization creating the CSP Profile.
        /// </summary>
        [JsonProperty("customerID", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerID { get; set; }

        /// <summary>
        /// Project name where service artifacts needs to be stored.
        /// </summary>
        [JsonProperty("projectName", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Type of CSP profile.
        /// </summary>
        [JsonProperty("type", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.CSPProfileTypeEnum? Type { get; set; }

        /// <summary>
        /// Information related to manage resources in AWS infrastructure.
        /// </summary>
        [JsonProperty("awsCspProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AwsCspProfile AwsCspProfile { get; set; }

        /// <summary>
        /// Information related to manage resources in Azure infrastructure.
        /// </summary>
        [JsonProperty("azureCspProfile", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AzureCspProfile AzureCspProfile { get; set; }

        /// <summary>
        /// Default location where service needs to be deployed.
        /// </summary>
        [JsonProperty("defaultLocation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DefaultLocation DefaultLocation { get; set; }

        /// <summary>
        /// Auto-derived Time of creation. Part of response only.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("verificationTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? VerificationTimeStamp { get; set; }

        /// <summary>
        /// State of the CSP profile.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// True if CSP is validated using provided credential, false otherwise.
        /// </summary>
        [JsonProperty("isValidated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsValidated { get; set; }

        /// <summary>
        /// Auto-derived Time of creation. Part of response only.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Last modified time. Part of response only.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("lastModifiedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// User who created the dropDown. Part of response only.
        /// </summary>
        [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// User who last modified the dropDown. Part of response only.
        /// </summary>
        [JsonProperty("lastModifiedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CSPProfile : ({string.Join(", ", toStringOutput)})";
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
            return obj is CSPProfile other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Usage == null && other.Usage == null) || (this.Usage?.Equals(other.Usage) == true)) &&
                ((this.CspProfileName == null && other.CspProfileName == null) || (this.CspProfileName?.Equals(other.CspProfileName) == true)) &&
                ((this.CustomerID == null && other.CustomerID == null) || (this.CustomerID?.Equals(other.CustomerID) == true)) &&
                ((this.ProjectName == null && other.ProjectName == null) || (this.ProjectName?.Equals(other.ProjectName) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.AwsCspProfile == null && other.AwsCspProfile == null) || (this.AwsCspProfile?.Equals(other.AwsCspProfile) == true)) &&
                ((this.AzureCspProfile == null && other.AzureCspProfile == null) || (this.AzureCspProfile?.Equals(other.AzureCspProfile) == true)) &&
                ((this.DefaultLocation == null && other.DefaultLocation == null) || (this.DefaultLocation?.Equals(other.DefaultLocation) == true)) &&
                ((this.VerificationTimeStamp == null && other.VerificationTimeStamp == null) || (this.VerificationTimeStamp?.Equals(other.VerificationTimeStamp) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.IsValidated == null && other.IsValidated == null) || (this.IsValidated?.Equals(other.IsValidated) == true)) &&
                ((this.CreatedDate == null && other.CreatedDate == null) || (this.CreatedDate?.Equals(other.CreatedDate) == true)) &&
                ((this.LastModifiedDate == null && other.LastModifiedDate == null) || (this.LastModifiedDate?.Equals(other.LastModifiedDate) == true)) &&
                ((this.CreatedBy == null && other.CreatedBy == null) || (this.CreatedBy?.Equals(other.CreatedBy) == true)) &&
                ((this.LastModifiedBy == null && other.LastModifiedBy == null) || (this.LastModifiedBy?.Equals(other.LastModifiedBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id == string.Empty ? "" : this.Id)}");
            toStringOutput.Add($"this.Usage = {(this.Usage == null ? "null" : this.Usage.ToString())}");
            toStringOutput.Add($"this.CspProfileName = {(this.CspProfileName == null ? "null" : this.CspProfileName == string.Empty ? "" : this.CspProfileName)}");
            toStringOutput.Add($"this.CustomerID = {(this.CustomerID == null ? "null" : this.CustomerID == string.Empty ? "" : this.CustomerID)}");
            toStringOutput.Add($"this.ProjectName = {(this.ProjectName == null ? "null" : this.ProjectName == string.Empty ? "" : this.ProjectName)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.AwsCspProfile = {(this.AwsCspProfile == null ? "null" : this.AwsCspProfile.ToString())}");
            toStringOutput.Add($"this.AzureCspProfile = {(this.AzureCspProfile == null ? "null" : this.AzureCspProfile.ToString())}");
            toStringOutput.Add($"this.DefaultLocation = {(this.DefaultLocation == null ? "null" : this.DefaultLocation.ToString())}");
            toStringOutput.Add($"this.VerificationTimeStamp = {(this.VerificationTimeStamp == null ? "null" : this.VerificationTimeStamp.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State == string.Empty ? "" : this.State)}");
            toStringOutput.Add($"this.IsValidated = {(this.IsValidated == null ? "null" : this.IsValidated.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.LastModifiedBy = {(this.LastModifiedBy == null ? "null" : this.LastModifiedBy == string.Empty ? "" : this.LastModifiedBy)}");
        }
    }
}