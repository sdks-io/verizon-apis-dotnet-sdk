// <copyright file="ConnectivityManagementSuccessResult.cs" company="APIMatic">
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
    /// ConnectivityManagementSuccessResult.
    /// </summary>
    public class ConnectivityManagementSuccessResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityManagementSuccessResult"/> class.
        /// </summary>
        public ConnectivityManagementSuccessResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectivityManagementSuccessResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        public ConnectivityManagementSuccessResult(
            bool? success = null)
        {
            this.Success = success;
        }

        /// <summary>
        /// A value of “true” indicates that the device group was created successfully.
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConnectivityManagementSuccessResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConnectivityManagementSuccessResult other &&                ((this.Success == null && other.Success == null) || (this.Success?.Equals(other.Success) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {(this.Success == null ? "null" : this.Success.ToString())}");
        }
    }
}