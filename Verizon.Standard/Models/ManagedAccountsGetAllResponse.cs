// <copyright file="ManagedAccountsGetAllResponse.cs" company="APIMatic">
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
    /// ManagedAccountsGetAllResponse.
    /// </summary>
    public class ManagedAccountsGetAllResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsGetAllResponse"/> class.
        /// </summary>
        public ManagedAccountsGetAllResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountsGetAllResponse"/> class.
        /// </summary>
        /// <param name="accountName">accountName.</param>
        /// <param name="managedAccAddedList">ManagedAccAddedList.</param>
        /// <param name="managedAccProvisionedList">managedAccProvisionedList.</param>
        public ManagedAccountsGetAllResponse(
            string accountName = null,
            List<Models.ManagedAccAddedList> managedAccAddedList = null,
            List<Models.ManagedAccProvisionedList> managedAccProvisionedList = null)
        {
            this.AccountName = accountName;
            this.ManagedAccAddedList = managedAccAddedList;
            this.ManagedAccProvisionedList = managedAccProvisionedList;
        }

        /// <summary>
        /// Account Name
        /// </summary>
        [JsonProperty("accountName", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets ManagedAccAddedList.
        /// </summary>
        [JsonProperty("ManagedAccAddedList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ManagedAccAddedList> ManagedAccAddedList { get; set; }

        /// <summary>
        /// Gets or sets ManagedAccProvisionedList.
        /// </summary>
        [JsonProperty("managedAccProvisionedList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ManagedAccProvisionedList> ManagedAccProvisionedList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ManagedAccountsGetAllResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ManagedAccountsGetAllResponse other &&
                (this.AccountName == null && other.AccountName == null ||
                 this.AccountName?.Equals(other.AccountName) == true) &&
                (this.ManagedAccAddedList == null && other.ManagedAccAddedList == null ||
                 this.ManagedAccAddedList?.Equals(other.ManagedAccAddedList) == true) &&
                (this.ManagedAccProvisionedList == null && other.ManagedAccProvisionedList == null ||
                 this.ManagedAccProvisionedList?.Equals(other.ManagedAccProvisionedList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AccountName = {this.AccountName ?? "null"}");
            toStringOutput.Add($"ManagedAccAddedList = {(this.ManagedAccAddedList == null ? "null" : $"[{string.Join(", ", this.ManagedAccAddedList)} ]")}");
            toStringOutput.Add($"ManagedAccProvisionedList = {(this.ManagedAccProvisionedList == null ? "null" : $"[{string.Join(", ", this.ManagedAccProvisionedList)} ]")}");
        }
    }
}