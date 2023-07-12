// <copyright file="IP.cs" company="APIMatic">
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
    /// IP.
    /// </summary>
    public class IP
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IP"/> class.
        /// </summary>
        public IP()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IP"/> class.
        /// </summary>
        /// <param name="privateIP">privateIP.</param>
        public IP(
            string privateIP = null)
        {
            this.PrivateIP = privateIP;
        }

        /// <summary>
        /// Gets or sets PrivateIP.
        /// </summary>
        [JsonProperty("privateIP", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIP { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IP : ({string.Join(", ", toStringOutput)})";
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
            return obj is IP other &&                ((this.PrivateIP == null && other.PrivateIP == null) || (this.PrivateIP?.Equals(other.PrivateIP) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PrivateIP = {(this.PrivateIP == null ? "null" : this.PrivateIP == string.Empty ? "" : this.PrivateIP)}");
        }
    }
}