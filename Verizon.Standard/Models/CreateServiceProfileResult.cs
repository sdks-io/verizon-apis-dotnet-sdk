// <copyright file="CreateServiceProfileResult.cs" company="APIMatic">
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
    /// CreateServiceProfileResult.
    /// </summary>
    public class CreateServiceProfileResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceProfileResult"/> class.
        /// </summary>
        public CreateServiceProfileResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceProfileResult"/> class.
        /// </summary>
        /// <param name="serviceProfileId">serviceProfileId.</param>
        public CreateServiceProfileResult(
            string serviceProfileId = null)
        {
            this.ServiceProfileId = serviceProfileId;
        }

        /// <summary>
        /// Unique identifier for a service profile.
        /// </summary>
        [JsonProperty("serviceProfileId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceProfileId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateServiceProfileResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreateServiceProfileResult other &&                ((this.ServiceProfileId == null && other.ServiceProfileId == null) || (this.ServiceProfileId?.Equals(other.ServiceProfileId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceProfileId = {(this.ServiceProfileId == null ? "null" : this.ServiceProfileId)}");
        }
    }
}