// <copyright file="NotificationGroupNameTriggerAttribute.cs" company="APIMatic">
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
    /// NotificationGroupNameTriggerAttribute.
    /// </summary>
    public class NotificationGroupNameTriggerAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGroupNameTriggerAttribute"/> class.
        /// </summary>
        public NotificationGroupNameTriggerAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationGroupNameTriggerAttribute"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public NotificationGroupNameTriggerAttribute(
            string key = null)
        {
            this.Key = key;
        }

        /// <summary>
        /// If present, the NotificationGroupName will be listed here.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NotificationGroupNameTriggerAttribute : ({string.Join(", ", toStringOutput)})";
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
            return obj is NotificationGroupNameTriggerAttribute other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key)}");
        }
    }
}