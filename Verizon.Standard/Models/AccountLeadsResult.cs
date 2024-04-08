// <copyright file="AccountLeadsResult.cs" company="APIMatic">
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
    /// AccountLeadsResult.
    /// </summary>
    public class AccountLeadsResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLeadsResult"/> class.
        /// </summary>
        public AccountLeadsResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLeadsResult"/> class.
        /// </summary>
        /// <param name="hasMoreData">hasMoreData.</param>
        /// <param name="leads">leads.</param>
        public AccountLeadsResult(
            bool? hasMoreData = null,
            List<Models.AccountLead> leads = null)
        {
            this.HasMoreData = hasMoreData;
            this.Leads = leads;
        }

        /// <summary>
        /// False if no more leads.True if there is more data to be retrieved.
        /// </summary>
        [JsonProperty("hasMoreData", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasMoreData { get; set; }

        /// <summary>
        /// The leads associated with an account.
        /// </summary>
        [JsonProperty("leads", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AccountLead> Leads { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLeadsResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLeadsResult other &&                ((this.HasMoreData == null && other.HasMoreData == null) || (this.HasMoreData?.Equals(other.HasMoreData) == true)) &&
                ((this.Leads == null && other.Leads == null) || (this.Leads?.Equals(other.Leads) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HasMoreData = {(this.HasMoreData == null ? "null" : this.HasMoreData.ToString())}");
            toStringOutput.Add($"this.Leads = {(this.Leads == null ? "null" : $"[{string.Join(", ", this.Leads)} ]")}");
        }
    }
}