// <copyright file="StatusProjectItem.cs" company="APIMatic">
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
    /// StatusProjectItem.
    /// </summary>
    public class StatusProjectItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusProjectItem"/> class.
        /// </summary>
        public StatusProjectItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusProjectItem"/> class.
        /// </summary>
        /// <param name="projectID">projectID.</param>
        public StatusProjectItem(
            string projectID = null)
        {
            this.ProjectID = projectID;
        }

        /// <summary>
        /// Gets or sets ProjectID.
        /// </summary>
        [JsonProperty("projectID", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectID { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StatusProjectItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is StatusProjectItem other &&                ((this.ProjectID == null && other.ProjectID == null) || (this.ProjectID?.Equals(other.ProjectID) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProjectID = {(this.ProjectID == null ? "null" : this.ProjectID == string.Empty ? "" : this.ProjectID)}");
        }
    }
}