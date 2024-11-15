// <copyright file="KPIInfo.cs" company="APIMatic">
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
    /// KPIInfo.
    /// </summary>
    public class KPIInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KPIInfo"/> class.
        /// </summary>
        public KPIInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIInfo"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        /// <param name="nodeName">nodeName.</param>
        /// <param name="nodeType">nodeType.</param>
        /// <param name="description">description.</param>
        /// <param name="unit">unit.</param>
        /// <param name="category">category.</param>
        /// <param name="timeOfLastUpdate">timeOfLastUpdate.</param>
        public KPIInfo(
            string name = null,
            string mValue = null,
            string nodeName = null,
            string nodeType = null,
            string description = null,
            string unit = null,
            string category = null,
            string timeOfLastUpdate = null)
        {
            this.Name = name;
            this.MValue = mValue;
            this.NodeName = nodeName;
            this.NodeType = nodeType;
            this.Description = description;
            this.Unit = unit;
            this.Category = category;
            this.TimeOfLastUpdate = timeOfLastUpdate;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets MValue.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Gets or sets NodeName.
        /// </summary>
        [JsonProperty("nodeName", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets NodeType.
        /// </summary>
        [JsonProperty("nodeType", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Unit.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets TimeOfLastUpdate.
        /// </summary>
        [JsonProperty("timeOfLastUpdate", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeOfLastUpdate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"KPIInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is KPIInfo other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.NodeName == null && other.NodeName == null) || (this.NodeName?.Equals(other.NodeName) == true)) &&
                ((this.NodeType == null && other.NodeType == null) || (this.NodeType?.Equals(other.NodeType) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Unit == null && other.Unit == null) || (this.Unit?.Equals(other.Unit) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.TimeOfLastUpdate == null && other.TimeOfLastUpdate == null) || (this.TimeOfLastUpdate?.Equals(other.TimeOfLastUpdate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.NodeName = {(this.NodeName == null ? "null" : this.NodeName)}");
            toStringOutput.Add($"this.NodeType = {(this.NodeType == null ? "null" : this.NodeType)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Unit = {(this.Unit == null ? "null" : this.Unit)}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category)}");
            toStringOutput.Add($"this.TimeOfLastUpdate = {(this.TimeOfLastUpdate == null ? "null" : this.TimeOfLastUpdate)}");
        }
    }
}