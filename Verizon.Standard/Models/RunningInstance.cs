// <copyright file="RunningInstance.cs" company="APIMatic">
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
    /// RunningInstance.
    /// </summary>
    public class RunningInstance
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunningInstance"/> class.
        /// </summary>
        public RunningInstance()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunningInstance"/> class.
        /// </summary>
        /// <param name="instanceName">instanceName.</param>
        /// <param name="instanceID">instanceID.</param>
        /// <param name="cSP">CSP.</param>
        /// <param name="status">status.</param>
        public RunningInstance(
            string instanceName = null,
            string instanceID = null,
            string cSP = null,
            Models.ServiceStatusEnum? status = null)
        {
            this.InstanceName = instanceName;
            this.InstanceID = instanceID;
            this.CSP = cSP;
            this.Status = status;
        }

        /// <summary>
        /// Service instance name.
        /// </summary>
        [JsonProperty("instanceName", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Service instance ID.
        /// </summary>
        [JsonProperty("instanceID", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceID { get; set; }

        /// <summary>
        /// Cloud Service Provider.
        /// </summary>
        [JsonProperty("CSP", NullValueHandling = NullValueHandling.Ignore)]
        public string CSP { get; set; }

        /// <summary>
        /// Can have any value as - DRAFT_INPROGRESS, DRAFT_COMPLETE, DESIGN_INPROGRESS, DESIGN_FAILED, DESIGN_COMPLETED, VALIDATION_INPROGRESS,  VALIDATION_FAILED, VALIDATION_COMPLETED, TESTING_INPROGRESS, TESTING_FAILED, TESTING_COMPLETED, READY_TO_USE_INPROGRESS, READY_TO_USE_FAILED, READY_TO_USE_COMPLETED, READY_TO_PRIVATE_USE_INPROGRESS, READY_TO_PRIVATE_USE_FAILED, READY_TO_PRIVATE_USE_COMPLETED,  PUBLISH_INPROGRESS,  PUBLISH_FAILED,  PUBLISH_COMPLETED,  CERTIFY_INPROGRESS,  CERTIFY_FAILED, CERTIFY_COMPLETED, DEPRECATE_INPROGRESS,  DEPRECATE_FAILED, DEPRECATE_COMPLETED, MARKDELETE_INPROGRESS, MARKDELETE_FAILED, MARKDELETE_COMPLETED.
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.ServiceStatusEnum? Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RunningInstance : ({string.Join(", ", toStringOutput)})";
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
            return obj is RunningInstance other &&                ((this.InstanceName == null && other.InstanceName == null) || (this.InstanceName?.Equals(other.InstanceName) == true)) &&
                ((this.InstanceID == null && other.InstanceID == null) || (this.InstanceID?.Equals(other.InstanceID) == true)) &&
                ((this.CSP == null && other.CSP == null) || (this.CSP?.Equals(other.CSP) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstanceName = {(this.InstanceName == null ? "null" : this.InstanceName == string.Empty ? "" : this.InstanceName)}");
            toStringOutput.Add($"this.InstanceID = {(this.InstanceID == null ? "null" : this.InstanceID == string.Empty ? "" : this.InstanceID)}");
            toStringOutput.Add($"this.CSP = {(this.CSP == null ? "null" : this.CSP == string.Empty ? "" : this.CSP)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
        }
    }
}