// <copyright file="State.cs" company="APIMatic">
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
    /// State.
    /// </summary>
    public class State
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        public State()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="State"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="workflowSequenceNumber">workflowSequenceNumber.</param>
        /// <param name="servicePlans">servicePlans.</param>
        public State(
            string name = null,
            double? workflowSequenceNumber = null,
            List<string> servicePlans = null)
        {
            this.Name = name;
            this.WorkflowSequenceNumber = workflowSequenceNumber;
            this.ServicePlans = servicePlans;
        }

        /// <summary>
        /// The name of the state.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The workflow sequence number of this state.
        /// </summary>
        [JsonProperty("workflowSequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public double? WorkflowSequenceNumber { get; set; }

        /// <summary>
        /// The service plans that can be used to charge for services for devices in this state.
        /// </summary>
        [JsonProperty("servicePlans", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServicePlans { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"State : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is State other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.WorkflowSequenceNumber == null && other.WorkflowSequenceNumber == null ||
                 this.WorkflowSequenceNumber?.Equals(other.WorkflowSequenceNumber) == true) &&
                (this.ServicePlans == null && other.ServicePlans == null ||
                 this.ServicePlans?.Equals(other.ServicePlans) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"WorkflowSequenceNumber = {(this.WorkflowSequenceNumber == null ? "null" : this.WorkflowSequenceNumber.ToString())}");
            toStringOutput.Add($"ServicePlans = {(this.ServicePlans == null ? "null" : $"[{string.Join(", ", this.ServicePlans)} ]")}");
        }
    }
}