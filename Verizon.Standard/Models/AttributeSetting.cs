// <copyright file="AttributeSetting.cs" company="APIMatic">
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
    /// AttributeSetting.
    /// </summary>
    public class AttributeSetting
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSetting"/> class.
        /// </summary>
        public AttributeSetting()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeSetting"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="mValue">value.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="isObservable">isObservable.</param>
        /// <param name="isObserving">isObserving.</param>
        /// <param name="frequency">frequency.</param>
        public AttributeSetting(
            Models.AttributeIdentifierEnum? name = null,
            string mValue = null,
            DateTime? createdOn = null,
            bool? isObservable = null,
            bool? isObserving = null,
            Models.NumericalData frequency = null)
        {
            this.Name = name;
            this.MValue = mValue;
            this.CreatedOn = createdOn;
            this.IsObservable = isObservable;
            this.IsObserving = isObserving;
            this.Frequency = frequency;
        }

        /// <summary>
        /// Attribute identifier.
        /// </summary>
        [JsonProperty("name", ItemConverterType = typeof(StringEnumConverter), NullValueHandling = NullValueHandling.Ignore)]
        public Models.AttributeIdentifierEnum? Name { get; set; }

        /// <summary>
        /// Attribute value.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string MValue { get; set; }

        /// <summary>
        /// Date and time request was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("createdOn", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedOn { get; set; }

        /// <summary>
        /// Is the attribute observable?
        /// </summary>
        [JsonProperty("isObservable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsObservable { get; set; }

        /// <summary>
        /// Is the attribute being observed?
        /// </summary>
        [JsonProperty("isObserving", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsObserving { get; set; }

        /// <summary>
        /// Describes value and unit of time.
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NumericalData Frequency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AttributeSetting : ({string.Join(", ", toStringOutput)})";
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
            return obj is AttributeSetting other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.CreatedOn == null && other.CreatedOn == null) || (this.CreatedOn?.Equals(other.CreatedOn) == true)) &&
                ((this.IsObservable == null && other.IsObservable == null) || (this.IsObservable?.Equals(other.IsObservable) == true)) &&
                ((this.IsObserving == null && other.IsObserving == null) || (this.IsObserving?.Equals(other.IsObserving) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue == string.Empty ? "" : this.MValue)}");
            toStringOutput.Add($"this.CreatedOn = {(this.CreatedOn == null ? "null" : this.CreatedOn.ToString())}");
            toStringOutput.Add($"this.IsObservable = {(this.IsObservable == null ? "null" : this.IsObservable.ToString())}");
            toStringOutput.Add($"this.IsObserving = {(this.IsObserving == null ? "null" : this.IsObserving.ToString())}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");
        }
    }
}