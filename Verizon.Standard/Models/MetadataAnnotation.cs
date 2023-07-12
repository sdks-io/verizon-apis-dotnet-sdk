// <copyright file="MetadataAnnotation.cs" company="APIMatic">
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
    /// MetadataAnnotation.
    /// </summary>
    public class MetadataAnnotation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataAnnotation"/> class.
        /// </summary>
        public MetadataAnnotation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataAnnotation"/> class.
        /// </summary>
        /// <param name="nodeAlphaKubernetesIoTtl">node.alpha.kubernetes.io/ttl.</param>
        /// <param name="rafayDevObjectHash">rafay.dev/object-hash.</param>
        /// <param name="volumesKubernetesIoControllerManagedAttachDetach">volumes.kubernetes.io/controller-managed-attach-detach.</param>
        public MetadataAnnotation(
            string nodeAlphaKubernetesIoTtl = null,
            string rafayDevObjectHash = null,
            string volumesKubernetesIoControllerManagedAttachDetach = null)
        {
            this.NodeAlphaKubernetesIoTtl = nodeAlphaKubernetesIoTtl;
            this.RafayDevObjectHash = rafayDevObjectHash;
            this.VolumesKubernetesIoControllerManagedAttachDetach = volumesKubernetesIoControllerManagedAttachDetach;
        }

        /// <summary>
        /// Gets or sets NodeAlphaKubernetesIoTtl.
        /// </summary>
        [JsonProperty("node.alpha.kubernetes.io/ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeAlphaKubernetesIoTtl { get; set; }

        /// <summary>
        /// Gets or sets RafayDevObjectHash.
        /// </summary>
        [JsonProperty("rafay.dev/object-hash", NullValueHandling = NullValueHandling.Ignore)]
        public string RafayDevObjectHash { get; set; }

        /// <summary>
        /// Gets or sets VolumesKubernetesIoControllerManagedAttachDetach.
        /// </summary>
        [JsonProperty("volumes.kubernetes.io/controller-managed-attach-detach", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumesKubernetesIoControllerManagedAttachDetach { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MetadataAnnotation : ({string.Join(", ", toStringOutput)})";
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
            return obj is MetadataAnnotation other &&                ((this.NodeAlphaKubernetesIoTtl == null && other.NodeAlphaKubernetesIoTtl == null) || (this.NodeAlphaKubernetesIoTtl?.Equals(other.NodeAlphaKubernetesIoTtl) == true)) &&
                ((this.RafayDevObjectHash == null && other.RafayDevObjectHash == null) || (this.RafayDevObjectHash?.Equals(other.RafayDevObjectHash) == true)) &&
                ((this.VolumesKubernetesIoControllerManagedAttachDetach == null && other.VolumesKubernetesIoControllerManagedAttachDetach == null) || (this.VolumesKubernetesIoControllerManagedAttachDetach?.Equals(other.VolumesKubernetesIoControllerManagedAttachDetach) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NodeAlphaKubernetesIoTtl = {(this.NodeAlphaKubernetesIoTtl == null ? "null" : this.NodeAlphaKubernetesIoTtl == string.Empty ? "" : this.NodeAlphaKubernetesIoTtl)}");
            toStringOutput.Add($"this.RafayDevObjectHash = {(this.RafayDevObjectHash == null ? "null" : this.RafayDevObjectHash == string.Empty ? "" : this.RafayDevObjectHash)}");
            toStringOutput.Add($"this.VolumesKubernetesIoControllerManagedAttachDetach = {(this.VolumesKubernetesIoControllerManagedAttachDetach == null ? "null" : this.VolumesKubernetesIoControllerManagedAttachDetach == string.Empty ? "" : this.VolumesKubernetesIoControllerManagedAttachDetach)}");
        }
    }
}