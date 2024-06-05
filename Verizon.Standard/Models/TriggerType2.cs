// <copyright file="TriggerType2.cs" company="APIMatic">
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
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Verizon.Standard;
    using Verizon.Standard.Utilities;

    /// <summary>
    /// TriggerType2.
    /// </summary>
    public class TriggerType2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerType2"/> class.
        /// </summary>
        public TriggerType2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerType2"/> class.
        /// </summary>
        /// <param name="anomalyattributes">anomalyattributes.</param>
        /// <param name="notification">notification.</param>
        public TriggerType2(
            Models.UsageAnomalyAttributes anomalyattributes = null,
            Models.TriggerNotification notification = null)
        {
            this.Anomalyattributes = anomalyattributes;
            this.Notification = notification;
        }

        /// <summary>
        /// The details of the UsageAnomaly trigger.
        /// </summary>
        [JsonProperty("anomalyattributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UsageAnomalyAttributes Anomalyattributes { get; set; }

        /// <summary>
        /// The notification details of the trigger.
        /// </summary>
        [JsonProperty("notification", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TriggerNotification Notification { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TriggerType2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is TriggerType2 other &&                ((this.Anomalyattributes == null && other.Anomalyattributes == null) || (this.Anomalyattributes?.Equals(other.Anomalyattributes) == true)) &&
                ((this.Notification == null && other.Notification == null) || (this.Notification?.Equals(other.Notification) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Anomalyattributes = {(this.Anomalyattributes == null ? "null" : this.Anomalyattributes.ToString())}");
            toStringOutput.Add($"this.Notification = {(this.Notification == null ? "null" : this.Notification.ToString())}");
        }
    }
}