// <copyright file="ConnectionEvent.cs" company="APIMatic">
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
    /// ConnectionEvent.
    /// </summary>
    public class ConnectionEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionEvent"/> class.
        /// </summary>
        public ConnectionEvent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionEvent"/> class.
        /// </summary>
        /// <param name="connectionEventAttributes">connectionEventAttributes.</param>
        /// <param name="extendedAttributes">extendedAttributes.</param>
        /// <param name="occurredAt">occurredAt.</param>
        public ConnectionEvent(
            List<Models.CustomFields> connectionEventAttributes = null,
            List<Models.CustomFields> extendedAttributes = null,
            string occurredAt = null)
        {
            this.ConnectionEventAttributes = connectionEventAttributes;
            this.ExtendedAttributes = extendedAttributes;
            this.OccurredAt = occurredAt;
        }

        /// <summary>
        /// The attributes that describe the connection event.
        /// </summary>
        [JsonProperty("connectionEventAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ConnectionEventAttributes { get; set; }

        /// <summary>
        /// Currently not used.
        /// </summary>
        [JsonProperty("extendedAttributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CustomFields> ExtendedAttributes { get; set; }

        /// <summary>
        /// The date and time when the connection event occured.
        /// </summary>
        [JsonProperty("occurredAt", NullValueHandling = NullValueHandling.Ignore)]
        public string OccurredAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ConnectionEvent : ({string.Join(", ", toStringOutput)})";
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
            return obj is ConnectionEvent other &&                ((this.ConnectionEventAttributes == null && other.ConnectionEventAttributes == null) || (this.ConnectionEventAttributes?.Equals(other.ConnectionEventAttributes) == true)) &&
                ((this.ExtendedAttributes == null && other.ExtendedAttributes == null) || (this.ExtendedAttributes?.Equals(other.ExtendedAttributes) == true)) &&
                ((this.OccurredAt == null && other.OccurredAt == null) || (this.OccurredAt?.Equals(other.OccurredAt) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConnectionEventAttributes = {(this.ConnectionEventAttributes == null ? "null" : $"[{string.Join(", ", this.ConnectionEventAttributes)} ]")}");
            toStringOutput.Add($"this.ExtendedAttributes = {(this.ExtendedAttributes == null ? "null" : $"[{string.Join(", ", this.ExtendedAttributes)} ]")}");
            toStringOutput.Add($"this.OccurredAt = {(this.OccurredAt == null ? "null" : this.OccurredAt)}");
        }
    }
}