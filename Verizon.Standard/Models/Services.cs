// <copyright file="Services.cs" company="APIMatic">
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
    /// Services.
    /// </summary>
    public class Services
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Services"/> class.
        /// </summary>
        public Services()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Services"/> class.
        /// </summary>
        /// <param name="totalRecords">totalRecords.</param>
        /// <param name="serviceResList">serviceResList.</param>
        public Services(
            int? totalRecords = null,
            List<Models.Service> serviceResList = null)
        {
            this.TotalRecords = totalRecords;
            this.ServiceResList = serviceResList;
        }

        /// <summary>
        /// Will display the total number of records fetched.
        /// </summary>
        [JsonProperty("totalRecords", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Response to fetch all services.
        /// </summary>
        [JsonProperty("serviceResList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Service> ServiceResList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Services : ({string.Join(", ", toStringOutput)})";
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
            return obj is Services other &&                ((this.TotalRecords == null && other.TotalRecords == null) || (this.TotalRecords?.Equals(other.TotalRecords) == true)) &&
                ((this.ServiceResList == null && other.ServiceResList == null) || (this.ServiceResList?.Equals(other.ServiceResList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
            toStringOutput.Add($"this.ServiceResList = {(this.ServiceResList == null ? "null" : $"[{string.Join(", ", this.ServiceResList)} ]")}");
        }
    }
}