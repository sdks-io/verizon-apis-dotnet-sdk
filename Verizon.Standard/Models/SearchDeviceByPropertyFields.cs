// <copyright file="SearchDeviceByPropertyFields.cs" company="APIMatic">
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
    /// SearchDeviceByPropertyFields.
    /// </summary>
    public class SearchDeviceByPropertyFields
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyFields"/> class.
        /// </summary>
        public SearchDeviceByPropertyFields()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDeviceByPropertyFields"/> class.
        /// </summary>
        /// <param name="acceleration">acceleration.</param>
        /// <param name="battery">battery.</param>
        /// <param name="humidity">humidity.</param>
        /// <param name="light">light.</param>
        /// <param name="pressure">pressure.</param>
        /// <param name="signalStrength">signalStrength.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="devicePropertylocation">DevicePropertylocation.</param>
        public SearchDeviceByPropertyFields(
            Models.Acceleration acceleration = null,
            string battery = null,
            string humidity = null,
            string light = null,
            string pressure = null,
            string signalStrength = null,
            string temperature = null,
            Models.DevicePropertylocation devicePropertylocation = null)
        {
            this.Acceleration = acceleration;
            this.Battery = battery;
            this.Humidity = humidity;
            this.Light = light;
            this.Pressure = pressure;
            this.SignalStrength = signalStrength;
            this.Temperature = temperature;
            this.DevicePropertylocation = devicePropertylocation;
        }

        /// <summary>
        /// Gets or sets Acceleration.
        /// </summary>
        [JsonProperty("acceleration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Acceleration Acceleration { get; set; }

        /// <summary>
        /// Gets or sets Battery.
        /// </summary>
        [JsonProperty("battery", NullValueHandling = NullValueHandling.Ignore)]
        public string Battery { get; set; }

        /// <summary>
        /// Gets or sets Humidity.
        /// </summary>
        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public string Humidity { get; set; }

        /// <summary>
        /// Gets or sets Light.
        /// </summary>
        [JsonProperty("light", NullValueHandling = NullValueHandling.Ignore)]
        public string Light { get; set; }

        /// <summary>
        /// Gets or sets Pressure.
        /// </summary>
        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public string Pressure { get; set; }

        /// <summary>
        /// Gets or sets SignalStrength.
        /// </summary>
        [JsonProperty("signalStrength", NullValueHandling = NullValueHandling.Ignore)]
        public string SignalStrength { get; set; }

        /// <summary>
        /// Gets or sets Temperature.
        /// </summary>
        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
        public string Temperature { get; set; }

        /// <summary>
        /// Gets or sets DevicePropertylocation.
        /// </summary>
        [JsonProperty("DevicePropertylocation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DevicePropertylocation DevicePropertylocation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SearchDeviceByPropertyFields : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SearchDeviceByPropertyFields other &&
                (this.Acceleration == null && other.Acceleration == null ||
                 this.Acceleration?.Equals(other.Acceleration) == true) &&
                (this.Battery == null && other.Battery == null ||
                 this.Battery?.Equals(other.Battery) == true) &&
                (this.Humidity == null && other.Humidity == null ||
                 this.Humidity?.Equals(other.Humidity) == true) &&
                (this.Light == null && other.Light == null ||
                 this.Light?.Equals(other.Light) == true) &&
                (this.Pressure == null && other.Pressure == null ||
                 this.Pressure?.Equals(other.Pressure) == true) &&
                (this.SignalStrength == null && other.SignalStrength == null ||
                 this.SignalStrength?.Equals(other.SignalStrength) == true) &&
                (this.Temperature == null && other.Temperature == null ||
                 this.Temperature?.Equals(other.Temperature) == true) &&
                (this.DevicePropertylocation == null && other.DevicePropertylocation == null ||
                 this.DevicePropertylocation?.Equals(other.DevicePropertylocation) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Acceleration = {(this.Acceleration == null ? "null" : this.Acceleration.ToString())}");
            toStringOutput.Add($"Battery = {this.Battery ?? "null"}");
            toStringOutput.Add($"Humidity = {this.Humidity ?? "null"}");
            toStringOutput.Add($"Light = {this.Light ?? "null"}");
            toStringOutput.Add($"Pressure = {this.Pressure ?? "null"}");
            toStringOutput.Add($"SignalStrength = {this.SignalStrength ?? "null"}");
            toStringOutput.Add($"Temperature = {this.Temperature ?? "null"}");
            toStringOutput.Add($"DevicePropertylocation = {(this.DevicePropertylocation == null ? "null" : this.DevicePropertylocation.ToString())}");
        }
    }
}