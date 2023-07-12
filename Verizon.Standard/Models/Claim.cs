// <copyright file="Claim.cs" company="APIMatic">
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
    /// Claim.
    /// </summary>
    public class Claim
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Claim"/> class.
        /// </summary>
        public Claim()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Claim"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="claimStatus">claimStatus.</param>
        /// <param name="sandBoxState">sandBoxState.</param>
        /// <param name="sandBoxStatus">sandBoxStatus.</param>
        /// <param name="environment">environment.</param>
        /// <param name="claimType">claimType.</param>
        /// <param name="startTimeStamp">startTimeStamp.</param>
        /// <param name="serviceInstanceId">serviceInstanceId.</param>
        /// <param name="cspProfileId">cspProfileId.</param>
        /// <param name="serviceId">serviceId.</param>
        /// <param name="endTimeStamp">endTimeStamp.</param>
        /// <param name="createdDate">createdDate.</param>
        /// <param name="lastModifiedDate">lastModifiedDate.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        public Claim(
            string id = null,
            string name = null,
            Models.ClaimStatusEnum? claimStatus = null,
            Models.SandBoxStateEnum? sandBoxState = null,
            Models.SandBoxStatusEnum? sandBoxStatus = null,
            string environment = null,
            Models.ClaimTypeEnum? claimType = null,
            DateTime? startTimeStamp = null,
            string serviceInstanceId = null,
            string cspProfileId = null,
            string serviceId = null,
            DateTime? endTimeStamp = null,
            DateTime? createdDate = null,
            DateTime? lastModifiedDate = null,
            string createdBy = null,
            string lastModifiedBy = null)
        {
            this.Id = id;
            this.Name = name;
            this.ClaimStatus = claimStatus;
            this.SandBoxState = sandBoxState;
            this.SandBoxStatus = sandBoxStatus;
            this.Environment = environment;
            this.ClaimType = claimType;
            this.StartTimeStamp = startTimeStamp;
            this.ServiceInstanceId = serviceInstanceId;
            this.CspProfileId = cspProfileId;
            this.ServiceId = serviceId;
            this.EndTimeStamp = endTimeStamp;
            this.CreatedDate = createdDate;
            this.LastModifiedDate = lastModifiedDate;
            this.CreatedBy = createdBy;
            this.LastModifiedBy = lastModifiedBy;
        }

        /// <summary>
        /// Auto-generated Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the claim.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Current status of the claim can have only two values eg: VERIFIED/UNVERIFIED.
        /// </summary>
        [JsonProperty("claimStatus", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimStatusEnum? ClaimStatus { get; set; }

        /// <summary>
        /// State of sandbox can have value like - STARTED, NOT_STARTED, STOPPED, PAUSED, COMPLETED, DELETED, STOP_IN_PROGRESS, PAUSE_IN_PROGRESS, TEST_IN_PROGRESS, MARK_FOR_DELETEION.
        /// </summary>
        [JsonProperty("sandBoxState", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.SandBoxStateEnum? SandBoxState { get; set; }

        /// <summary>
        /// Status of sandbox can have value like - NA, INPROGRESS, SUCCESS, FAILED.
        /// </summary>
        [JsonProperty("sandBoxStatus", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.SandBoxStatusEnum? SandBoxStatus { get; set; }

        /// <summary>
        /// Claim environment in which it is deployed eg: AWS Public Cloud.
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        /// <summary>
        /// Claim type can have values like - PUBLIC_MEC, PRIVATE_MEC.
        /// </summary>
        [JsonProperty("claimType", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ClaimTypeEnum? ClaimType { get; set; }

        /// <summary>
        /// Start time when the claim got introduced.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("startTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTimeStamp { get; set; }

        /// <summary>
        /// Auto-generated Id of the service instance.
        /// </summary>
        [JsonProperty("serviceInstanceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// CSP Profile ID in which service will be deployed.
        /// </summary>
        [JsonProperty("cspProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string CspProfileId { get; set; }

        /// <summary>
        /// Auto-generated Id of the service which is to be deployed.
        /// </summary>
        [JsonProperty("serviceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// End time when the claim got introduced.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("endTimeStamp", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTimeStamp { get; set; }

        /// <summary>
        /// Auto-derived time of creation. Part of response only.
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

            return $"Claim : ({string.Join(", ", toStringOutput)})";
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
            return obj is Claim other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.ClaimStatus == null && other.ClaimStatus == null) || (this.ClaimStatus?.Equals(other.ClaimStatus) == true)) &&
                ((this.SandBoxState == null && other.SandBoxState == null) || (this.SandBoxState?.Equals(other.SandBoxState) == true)) &&
                ((this.SandBoxStatus == null && other.SandBoxStatus == null) || (this.SandBoxStatus?.Equals(other.SandBoxStatus) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.ClaimType == null && other.ClaimType == null) || (this.ClaimType?.Equals(other.ClaimType) == true)) &&
                ((this.StartTimeStamp == null && other.StartTimeStamp == null) || (this.StartTimeStamp?.Equals(other.StartTimeStamp) == true)) &&
                ((this.ServiceInstanceId == null && other.ServiceInstanceId == null) || (this.ServiceInstanceId?.Equals(other.ServiceInstanceId) == true)) &&
                ((this.CspProfileId == null && other.CspProfileId == null) || (this.CspProfileId?.Equals(other.CspProfileId) == true)) &&
                ((this.ServiceId == null && other.ServiceId == null) || (this.ServiceId?.Equals(other.ServiceId) == true)) &&
                ((this.EndTimeStamp == null && other.EndTimeStamp == null) || (this.EndTimeStamp?.Equals(other.EndTimeStamp) == true)) &&
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
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.ClaimStatus = {(this.ClaimStatus == null ? "null" : this.ClaimStatus.ToString())}");
            toStringOutput.Add($"this.SandBoxState = {(this.SandBoxState == null ? "null" : this.SandBoxState.ToString())}");
            toStringOutput.Add($"this.SandBoxStatus = {(this.SandBoxStatus == null ? "null" : this.SandBoxStatus.ToString())}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment == string.Empty ? "" : this.Environment)}");
            toStringOutput.Add($"this.ClaimType = {(this.ClaimType == null ? "null" : this.ClaimType.ToString())}");
            toStringOutput.Add($"this.StartTimeStamp = {(this.StartTimeStamp == null ? "null" : this.StartTimeStamp.ToString())}");
            toStringOutput.Add($"this.ServiceInstanceId = {(this.ServiceInstanceId == null ? "null" : this.ServiceInstanceId == string.Empty ? "" : this.ServiceInstanceId)}");
            toStringOutput.Add($"this.CspProfileId = {(this.CspProfileId == null ? "null" : this.CspProfileId == string.Empty ? "" : this.CspProfileId)}");
            toStringOutput.Add($"this.ServiceId = {(this.ServiceId == null ? "null" : this.ServiceId == string.Empty ? "" : this.ServiceId)}");
            toStringOutput.Add($"this.EndTimeStamp = {(this.EndTimeStamp == null ? "null" : this.EndTimeStamp.ToString())}");
            toStringOutput.Add($"this.CreatedDate = {(this.CreatedDate == null ? "null" : this.CreatedDate.ToString())}");
            toStringOutput.Add($"this.LastModifiedDate = {(this.LastModifiedDate == null ? "null" : this.LastModifiedDate.ToString())}");
            toStringOutput.Add($"this.CreatedBy = {(this.CreatedBy == null ? "null" : this.CreatedBy == string.Empty ? "" : this.CreatedBy)}");
            toStringOutput.Add($"this.LastModifiedBy = {(this.LastModifiedBy == null ? "null" : this.LastModifiedBy == string.Empty ? "" : this.LastModifiedBy)}");
        }
    }
}