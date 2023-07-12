// <copyright file="ServicePlanTriggerAttribute.cs" company="APIMatic">
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
    /// ServicePlanTriggerAttribute.
    /// </summary>
    public class ServicePlanTriggerAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanTriggerAttribute"/> class.
        /// </summary>
        public ServicePlanTriggerAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePlanTriggerAttribute"/> class.
        /// </summary>
        /// <param name="key">key.</param>
        public ServicePlanTriggerAttribute(
            string key = null)
        {
            this.Key = key;
        }

        /// <summary>
        /// The ServicePlan name will be listed here.
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServicePlanTriggerAttribute : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServicePlanTriggerAttribute other &&                ((this.Key == null && other.Key == null) || (this.Key?.Equals(other.Key) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Key = {(this.Key == null ? "null" : this.Key == string.Empty ? "" : this.Key)}");
        }
    }
}