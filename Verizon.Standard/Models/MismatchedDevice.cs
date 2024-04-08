// <copyright file="MismatchedDevice.cs" company="APIMatic">
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
    /// MismatchedDevice.
    /// </summary>
    public class MismatchedDevice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MismatchedDevice"/> class.
        /// </summary>
        public MismatchedDevice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MismatchedDevice"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="mdn">mdn.</param>
        /// <param name="activationDate">activationDate.</param>
        /// <param name="iccid">iccid.</param>
        /// <param name="preImei">preImei.</param>
        /// <param name="postImei">postImei.</param>
        /// <param name="simOtaDate">simOtaDate.</param>
        public MismatchedDevice(
            string accountName = null,
            string mdn = null,
            string activationDate = null,
            string iccid = null,
            string preImei = null,
            string postImei = null,
            string simOtaDate = null)
        {
            this.AccountName = accountName;
            this.Mdn = mdn;
            this.ActivationDate = activationDate;
            this.Iccid = iccid;
            this.PreImei = preImei;
            this.PostImei = postImei;
            this.SimOtaDate = simOtaDate;
        }

        /// <summary>
        /// The account that the device is associated with.
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// The assigned phone number of the device.
        /// </summary>
        [JsonProperty("mdn", NullValueHandling = NullValueHandling.Ignore)]
        public string Mdn { get; set; }

        /// <summary>
        /// The date and time when the SIM was last activated.
        /// </summary>
        [JsonProperty("activationDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ActivationDate { get; set; }

        /// <summary>
        /// The ID of the SIM.
        /// </summary>
        [JsonProperty("iccid", NullValueHandling = NullValueHandling.Ignore)]
        public string Iccid { get; set; }

        /// <summary>
        /// The IMEI of the device prior to the SIM OTA activation on simOtaDate.
        /// </summary>
        [JsonProperty("preImei", NullValueHandling = NullValueHandling.Ignore)]
        public string PreImei { get; set; }

        /// <summary>
        /// The IMEI of the device after the SIM OTA activation on simOtaDate.
        /// </summary>
        [JsonProperty("postImei", NullValueHandling = NullValueHandling.Ignore)]
        public string PostImei { get; set; }

        /// <summary>
        /// The date and time of the SIM OTA activation.
        /// </summary>
        [JsonProperty("simOtaDate", NullValueHandling = NullValueHandling.Ignore)]
        public string SimOtaDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MismatchedDevice : ({string.Join(", ", toStringOutput)})";
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
            return obj is MismatchedDevice other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.Mdn == null && other.Mdn == null) || (this.Mdn?.Equals(other.Mdn) == true)) &&
                ((this.ActivationDate == null && other.ActivationDate == null) || (this.ActivationDate?.Equals(other.ActivationDate) == true)) &&
                ((this.Iccid == null && other.Iccid == null) || (this.Iccid?.Equals(other.Iccid) == true)) &&
                ((this.PreImei == null && other.PreImei == null) || (this.PreImei?.Equals(other.PreImei) == true)) &&
                ((this.PostImei == null && other.PostImei == null) || (this.PostImei?.Equals(other.PostImei) == true)) &&
                ((this.SimOtaDate == null && other.SimOtaDate == null) || (this.SimOtaDate?.Equals(other.SimOtaDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.Mdn = {(this.Mdn == null ? "null" : this.Mdn)}");
            toStringOutput.Add($"this.ActivationDate = {(this.ActivationDate == null ? "null" : this.ActivationDate)}");
            toStringOutput.Add($"this.Iccid = {(this.Iccid == null ? "null" : this.Iccid)}");
            toStringOutput.Add($"this.PreImei = {(this.PreImei == null ? "null" : this.PreImei)}");
            toStringOutput.Add($"this.PostImei = {(this.PostImei == null ? "null" : this.PostImei)}");
            toStringOutput.Add($"this.SimOtaDate = {(this.SimOtaDate == null ? "null" : this.SimOtaDate)}");
        }
    }
}