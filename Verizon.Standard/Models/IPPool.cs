// <copyright file="IPPool.cs" company="APIMatic">
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
    /// IPPool.
    /// </summary>
    public class IPPool
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPPool"/> class.
        /// </summary>
        public IPPool()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IPPool"/> class.
        /// </summary>
        /// <param name="poolName">poolName.</param>
        /// <param name="poolType">poolType.</param>
        /// <param name="isDefaultPool">isDefaultPool.</param>
        public IPPool(
            string poolName = null,
            string poolType = null,
            bool? isDefaultPool = null)
        {
            this.PoolName = poolName;
            this.PoolType = poolType;
            this.IsDefaultPool = isDefaultPool;
        }

        /// <summary>
        /// The name of the IP pool.
        /// </summary>
        [JsonProperty("poolName", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// The type of IP pool, such as “Static IP” or “Dynamic IP.”
        /// </summary>
        [JsonProperty("poolType", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolType { get; set; }

        /// <summary>
        /// True if this is the default IP pool for the account.
        /// </summary>
        [JsonProperty("isDefaultPool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultPool { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IPPool : ({string.Join(", ", toStringOutput)})";
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
            return obj is IPPool other &&                ((this.PoolName == null && other.PoolName == null) || (this.PoolName?.Equals(other.PoolName) == true)) &&
                ((this.PoolType == null && other.PoolType == null) || (this.PoolType?.Equals(other.PoolType) == true)) &&
                ((this.IsDefaultPool == null && other.IsDefaultPool == null) || (this.IsDefaultPool?.Equals(other.IsDefaultPool) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PoolName = {(this.PoolName == null ? "null" : this.PoolName == string.Empty ? "" : this.PoolName)}");
            toStringOutput.Add($"this.PoolType = {(this.PoolType == null ? "null" : this.PoolType == string.Empty ? "" : this.PoolType)}");
            toStringOutput.Add($"this.IsDefaultPool = {(this.IsDefaultPool == null ? "null" : this.IsDefaultPool.ToString())}");
        }
    }
}