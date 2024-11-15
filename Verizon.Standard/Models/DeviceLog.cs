// <copyright file="DeviceLog.cs" company="APIMatic">
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
    /// DeviceLog.
    /// </summary>
    public class DeviceLog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLog"/> class.
        /// </summary>
        public DeviceLog()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceLog"/> class.
        /// </summary>
        /// <param name="deviceId">deviceId.</param>
        /// <param name="logTime">logTime.</param>
        /// <param name="logType">logType.</param>
        /// <param name="eventLog">eventLog.</param>
        /// <param name="binaryLogFileBase64">binaryLogFileBase64.</param>
        /// <param name="binaryLogFilename">binaryLogFilename.</param>
        public DeviceLog(
            string deviceId,
            DateTime logTime,
            string logType,
            string eventLog,
            string binaryLogFileBase64,
            string binaryLogFilename)
        {
            this.DeviceId = deviceId;
            this.LogTime = logTime;
            this.LogType = logType;
            this.EventLog = eventLog;
            this.BinaryLogFileBase64 = binaryLogFileBase64;
            this.BinaryLogFilename = binaryLogFilename;
        }

        /// <summary>
        /// Device IMEI.
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Time of log.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("logTime")]
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Log type (one of SoftwareUpdate, Event, UserNotification, AgentService, Wireless, WirelessWeb, MobileBroadbandModem, WindowsMDM).
        /// </summary>
        [JsonProperty("logType")]
        public string LogType { get; set; }

        /// <summary>
        /// Event log.
        /// </summary>
        [JsonProperty("eventLog")]
        public string EventLog { get; set; }

        /// <summary>
        /// Base64-encoded contents of binary log file.
        /// </summary>
        [JsonProperty("binaryLogFileBase64")]
        public string BinaryLogFileBase64 { get; set; }

        /// <summary>
        /// File name of binary log file.
        /// </summary>
        [JsonProperty("binaryLogFilename")]
        public string BinaryLogFilename { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeviceLog : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeviceLog other &&                ((this.DeviceId == null && other.DeviceId == null) || (this.DeviceId?.Equals(other.DeviceId) == true)) &&
                this.LogTime.Equals(other.LogTime) &&
                ((this.LogType == null && other.LogType == null) || (this.LogType?.Equals(other.LogType) == true)) &&
                ((this.EventLog == null && other.EventLog == null) || (this.EventLog?.Equals(other.EventLog) == true)) &&
                ((this.BinaryLogFileBase64 == null && other.BinaryLogFileBase64 == null) || (this.BinaryLogFileBase64?.Equals(other.BinaryLogFileBase64) == true)) &&
                ((this.BinaryLogFilename == null && other.BinaryLogFilename == null) || (this.BinaryLogFilename?.Equals(other.BinaryLogFilename) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DeviceId = {(this.DeviceId == null ? "null" : this.DeviceId)}");
            toStringOutput.Add($"this.LogTime = {this.LogTime}");
            toStringOutput.Add($"this.LogType = {(this.LogType == null ? "null" : this.LogType)}");
            toStringOutput.Add($"this.EventLog = {(this.EventLog == null ? "null" : this.EventLog)}");
            toStringOutput.Add($"this.BinaryLogFileBase64 = {(this.BinaryLogFileBase64 == null ? "null" : this.BinaryLogFileBase64)}");
            toStringOutput.Add($"this.BinaryLogFilename = {(this.BinaryLogFilename == null ? "null" : this.BinaryLogFilename)}");
        }
    }
}