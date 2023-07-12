// <copyright file="NodeGroupItemTag.cs" company="APIMatic">
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
    /// NodeGroupItemTag.
    /// </summary>
    public class NodeGroupItemTag
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroupItemTag"/> class.
        /// </summary>
        public NodeGroupItemTag()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeGroupItemTag"/> class.
        /// </summary>
        /// <param name="associateCarrierIp">associate-carrier-ip.</param>
        public NodeGroupItemTag(
            string associateCarrierIp = null)
        {
            this.AssociateCarrierIp = associateCarrierIp;
        }

        /// <summary>
        /// Gets or sets AssociateCarrierIp.
        /// </summary>
        [JsonProperty("associate-carrier-ip", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateCarrierIp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeGroupItemTag : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeGroupItemTag other &&                ((this.AssociateCarrierIp == null && other.AssociateCarrierIp == null) || (this.AssociateCarrierIp?.Equals(other.AssociateCarrierIp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AssociateCarrierIp = {(this.AssociateCarrierIp == null ? "null" : this.AssociateCarrierIp == string.Empty ? "" : this.AssociateCarrierIp)}");
        }
    }
}