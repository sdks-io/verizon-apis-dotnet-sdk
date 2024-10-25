// <copyright file="Region.cs" company="APIMatic">
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
    /// Region.
    /// </summary>
    public class Region
    {
        private string regionId;
        private string name;
        private string countryCode;
        private string metro;
        private string area;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "regionId", false },
            { "name", false },
            { "countryCode", false },
            { "metro", false },
            { "area", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Region"/> class.
        /// </summary>
        public Region()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Region"/> class.
        /// </summary>
        /// <param name="regionId">regionId.</param>
        /// <param name="name">name.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="metro">metro.</param>
        /// <param name="area">area.</param>
        public Region(
            string regionId = null,
            string name = null,
            string countryCode = null,
            string metro = null,
            string area = null)
        {
            if (regionId != null)
            {
                this.RegionId = regionId;
            }

            if (name != null)
            {
                this.Name = name;
            }

            if (countryCode != null)
            {
                this.CountryCode = countryCode;
            }

            if (metro != null)
            {
                this.Metro = metro;
            }

            if (area != null)
            {
                this.Area = area;
            }

        }

        /// <summary>
        /// The unique identifier of the region.
        /// </summary>
        [JsonProperty("regionId")]
        public string RegionId
        {
            get
            {
                return this.regionId;
            }

            set
            {
                this.shouldSerialize["regionId"] = true;
                this.regionId = value;
            }
        }

        /// <summary>
        /// A relevant and identifiable region name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// A two-character alpha code for a country, based on ISO 3166-1 alpha-2. This is future functionality, so the value returned is 'null'.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }

            set
            {
                this.shouldSerialize["countryCode"] = true;
                this.countryCode = value;
            }
        }

        /// <summary>
        /// The metropolitan area or 'City' value.  This is future functionality, so the value returned is 'null'.
        /// </summary>
        [JsonProperty("metro")]
        public string Metro
        {
            get
            {
                return this.metro;
            }

            set
            {
                this.shouldSerialize["metro"] = true;
                this.metro = value;
            }
        }

        /// <summary>
        /// This is a sub-set of 'City' and is similar to 'Zone'. This is future functionality, so the value returned is 'null'.
        /// </summary>
        [JsonProperty("area")]
        public string Area
        {
            get
            {
                return this.area;
            }

            set
            {
                this.shouldSerialize["area"] = true;
                this.area = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Region : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegionId()
        {
            this.shouldSerialize["regionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryCode()
        {
            this.shouldSerialize["countryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMetro()
        {
            this.shouldSerialize["metro"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArea()
        {
            this.shouldSerialize["area"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegionId()
        {
            return this.shouldSerialize["regionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryCode()
        {
            return this.shouldSerialize["countryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMetro()
        {
            return this.shouldSerialize["metro"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArea()
        {
            return this.shouldSerialize["area"];
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
            return obj is Region other &&                ((this.RegionId == null && other.RegionId == null) || (this.RegionId?.Equals(other.RegionId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Metro == null && other.Metro == null) || (this.Metro?.Equals(other.Metro) == true)) &&
                ((this.Area == null && other.Area == null) || (this.Area?.Equals(other.Area) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RegionId = {(this.RegionId == null ? "null" : this.RegionId)}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.Metro = {(this.Metro == null ? "null" : this.Metro)}");
            toStringOutput.Add($"this.Area = {(this.Area == null ? "null" : this.Area)}");
        }
    }
}