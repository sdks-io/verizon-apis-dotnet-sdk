// <copyright file="DeviceList2.cs" company="APIMatic">
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
    /// DeviceList2.
    /// </summary>
    public class DeviceList2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceList2"/> class.
        /// </summary>
        public DeviceList2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceList2"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        public DeviceList2(
            List<Models.DeviceId2> ids = null)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.DeviceId2> Ids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceList2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceList2 other &&                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
        }
    }
}