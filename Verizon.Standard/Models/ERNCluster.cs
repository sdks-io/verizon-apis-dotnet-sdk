// <copyright file="ERNCluster.cs" company="APIMatic">
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
    /// ERNCluster.
    /// </summary>
    public class ERNCluster
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ERNCluster"/> class.
        /// </summary>
        public ERNCluster()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ERNCluster"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="nameSpace">nameSpace.</param>
        public ERNCluster(
            Guid? id = null,
            string name = null,
            List<Models.NamespaceIdItem> nameSpace = null)
        {
            this.Id = id;
            this.Name = name;
            this.NameSpace = nameSpace;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Id { get; set; }

        /// <summary>
        /// User display name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets NameSpace.
        /// </summary>
        [JsonProperty("nameSpace", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NamespaceIdItem> NameSpace { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ERNCluster : ({string.Join(", ", toStringOutput)})";
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
            return obj is ERNCluster other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.NameSpace == null && other.NameSpace == null) || (this.NameSpace?.Equals(other.NameSpace) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name == string.Empty ? "" : this.Name)}");
            toStringOutput.Add($"this.NameSpace = {(this.NameSpace == null ? "null" : $"[{string.Join(", ", this.NameSpace)} ]")}");
        }
    }
}