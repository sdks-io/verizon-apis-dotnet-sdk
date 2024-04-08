// <copyright file="ManagedAccAddedList.cs" company="APIMatic">
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
    /// ManagedAccAddedList.
    /// </summary>
    public class ManagedAccAddedList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccAddedList"/> class.
        /// </summary>
        public ManagedAccAddedList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccAddedList"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="txid">txid.</param>
        public ManagedAccAddedList(
            string id = null,
            string txid = null)
        {
            this.Id = id;
            this.Txid = txid;
        }

        /// <summary>
        /// Account name
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        [JsonProperty("txid", NullValueHandling = NullValueHandling.Ignore)]
        public string Txid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ManagedAccAddedList : ({string.Join(", ", toStringOutput)})";
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
            return obj is ManagedAccAddedList other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Txid == null && other.Txid == null) || (this.Txid?.Equals(other.Txid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Txid = {(this.Txid == null ? "null" : this.Txid)}");
        }
    }
}