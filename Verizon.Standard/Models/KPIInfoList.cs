// <copyright file="KPIInfoList.cs" company="APIMatic">
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
    /// KPIInfoList.
    /// </summary>
    public class KPIInfoList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KPIInfoList"/> class.
        /// </summary>
        public KPIInfoList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIInfoList"/> class.
        /// </summary>
        /// <param name="kpiInfoList">KpiInfoList.</param>
        public KPIInfoList(
            List<Models.KPIInfo> kpiInfoList = null)
        {
            this.KpiInfoList = kpiInfoList;
        }

        /// <summary>
        /// Gets or sets KpiInfoList.
        /// </summary>
        [JsonProperty("KpiInfoList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.KPIInfo> KpiInfoList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"KPIInfoList : ({string.Join(", ", toStringOutput)})";
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
            return obj is KPIInfoList other &&                ((this.KpiInfoList == null && other.KpiInfoList == null) || (this.KpiInfoList?.Equals(other.KpiInfoList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.KpiInfoList = {(this.KpiInfoList == null ? "null" : $"[{string.Join(", ", this.KpiInfoList)} ]")}");
        }
    }
}