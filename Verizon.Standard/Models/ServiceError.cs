// <copyright file="ServiceError.cs" company="APIMatic">
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
    /// ServiceError.
    /// </summary>
    public class ServiceError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceError"/> class.
        /// </summary>
        public ServiceError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceError"/> class.
        /// </summary>
        /// <param name="errorCategory">errorCategory.</param>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorDesc">errorDesc.</param>
        /// <param name="errorSubcategory">errorSubcategory.</param>
        public ServiceError(
            string errorCategory = null,
            string errorCode = null,
            string errorDesc = null,
            string errorSubcategory = null)
        {
            this.ErrorCategory = errorCategory;
            this.ErrorCode = errorCode;
            this.ErrorDesc = errorDesc;
            this.ErrorSubcategory = errorSubcategory;
        }

        /// <summary>
        /// Category defined under which the error falls.
        /// </summary>
        [JsonProperty("errorCategory", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCategory { get; set; }

        /// <summary>
        /// Error Code is required.
        /// </summary>
        [JsonProperty("errorCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error description is required.
        /// </summary>
        [JsonProperty("errorDesc", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// Sub-category of the error defined.
        /// </summary>
        [JsonProperty("errorSubcategory", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorSubcategory { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServiceError : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServiceError other &&                ((this.ErrorCategory == null && other.ErrorCategory == null) || (this.ErrorCategory?.Equals(other.ErrorCategory) == true)) &&
                ((this.ErrorCode == null && other.ErrorCode == null) || (this.ErrorCode?.Equals(other.ErrorCode) == true)) &&
                ((this.ErrorDesc == null && other.ErrorDesc == null) || (this.ErrorDesc?.Equals(other.ErrorDesc) == true)) &&
                ((this.ErrorSubcategory == null && other.ErrorSubcategory == null) || (this.ErrorSubcategory?.Equals(other.ErrorSubcategory) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ErrorCategory = {(this.ErrorCategory == null ? "null" : this.ErrorCategory == string.Empty ? "" : this.ErrorCategory)}");
            toStringOutput.Add($"this.ErrorCode = {(this.ErrorCode == null ? "null" : this.ErrorCode == string.Empty ? "" : this.ErrorCode)}");
            toStringOutput.Add($"this.ErrorDesc = {(this.ErrorDesc == null ? "null" : this.ErrorDesc == string.Empty ? "" : this.ErrorDesc)}");
            toStringOutput.Add($"this.ErrorSubcategory = {(this.ErrorSubcategory == null ? "null" : this.ErrorSubcategory == string.Empty ? "" : this.ErrorSubcategory)}");
        }
    }
}