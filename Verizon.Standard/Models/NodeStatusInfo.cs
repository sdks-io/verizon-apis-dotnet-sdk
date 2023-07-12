// <copyright file="NodeStatusInfo.cs" company="APIMatic">
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
    /// NodeStatusInfo.
    /// </summary>
    public class NodeStatusInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusInfo"/> class.
        /// </summary>
        public NodeStatusInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeStatusInfo"/> class.
        /// </summary>
        /// <param name="machineID">machineID.</param>
        /// <param name="systemUUID">systemUUID.</param>
        /// <param name="bootID">bootID.</param>
        /// <param name="kernelVersion">kernelVersion.</param>
        /// <param name="osImage">osImage.</param>
        /// <param name="containerRuntimeVersion">containerRuntimeVersion.</param>
        /// <param name="kubeletVersion">kubeletVersion.</param>
        /// <param name="kubeProxyVersion">kubeProxyVersion.</param>
        /// <param name="operatingSystem">operatingSystem.</param>
        /// <param name="architecture">architecture.</param>
        public NodeStatusInfo(
            string machineID = null,
            string systemUUID = null,
            string bootID = null,
            string kernelVersion = null,
            string osImage = null,
            string containerRuntimeVersion = null,
            string kubeletVersion = null,
            string kubeProxyVersion = null,
            string operatingSystem = null,
            string architecture = null)
        {
            this.MachineID = machineID;
            this.SystemUUID = systemUUID;
            this.BootID = bootID;
            this.KernelVersion = kernelVersion;
            this.OsImage = osImage;
            this.ContainerRuntimeVersion = containerRuntimeVersion;
            this.KubeletVersion = kubeletVersion;
            this.KubeProxyVersion = kubeProxyVersion;
            this.OperatingSystem = operatingSystem;
            this.Architecture = architecture;
        }

        /// <summary>
        /// Gets or sets MachineID.
        /// </summary>
        [JsonProperty("machineID", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineID { get; set; }

        /// <summary>
        /// Gets or sets SystemUUID.
        /// </summary>
        [JsonProperty("systemUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemUUID { get; set; }

        /// <summary>
        /// Gets or sets BootID.
        /// </summary>
        [JsonProperty("bootID", NullValueHandling = NullValueHandling.Ignore)]
        public string BootID { get; set; }

        /// <summary>
        /// Gets or sets KernelVersion.
        /// </summary>
        [JsonProperty("kernelVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string KernelVersion { get; set; }

        /// <summary>
        /// Gets or sets OsImage.
        /// </summary>
        [JsonProperty("osImage", NullValueHandling = NullValueHandling.Ignore)]
        public string OsImage { get; set; }

        /// <summary>
        /// Gets or sets ContainerRuntimeVersion.
        /// </summary>
        [JsonProperty("containerRuntimeVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerRuntimeVersion { get; set; }

        /// <summary>
        /// Gets or sets KubeletVersion.
        /// </summary>
        [JsonProperty("kubeletVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string KubeletVersion { get; set; }

        /// <summary>
        /// Gets or sets KubeProxyVersion.
        /// </summary>
        [JsonProperty("kubeProxyVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string KubeProxyVersion { get; set; }

        /// <summary>
        /// Gets or sets OperatingSystem.
        /// </summary>
        [JsonProperty("operatingSystem", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Gets or sets Architecture.
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NodeStatusInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is NodeStatusInfo other &&                ((this.MachineID == null && other.MachineID == null) || (this.MachineID?.Equals(other.MachineID) == true)) &&
                ((this.SystemUUID == null && other.SystemUUID == null) || (this.SystemUUID?.Equals(other.SystemUUID) == true)) &&
                ((this.BootID == null && other.BootID == null) || (this.BootID?.Equals(other.BootID) == true)) &&
                ((this.KernelVersion == null && other.KernelVersion == null) || (this.KernelVersion?.Equals(other.KernelVersion) == true)) &&
                ((this.OsImage == null && other.OsImage == null) || (this.OsImage?.Equals(other.OsImage) == true)) &&
                ((this.ContainerRuntimeVersion == null && other.ContainerRuntimeVersion == null) || (this.ContainerRuntimeVersion?.Equals(other.ContainerRuntimeVersion) == true)) &&
                ((this.KubeletVersion == null && other.KubeletVersion == null) || (this.KubeletVersion?.Equals(other.KubeletVersion) == true)) &&
                ((this.KubeProxyVersion == null && other.KubeProxyVersion == null) || (this.KubeProxyVersion?.Equals(other.KubeProxyVersion) == true)) &&
                ((this.OperatingSystem == null && other.OperatingSystem == null) || (this.OperatingSystem?.Equals(other.OperatingSystem) == true)) &&
                ((this.Architecture == null && other.Architecture == null) || (this.Architecture?.Equals(other.Architecture) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MachineID = {(this.MachineID == null ? "null" : this.MachineID == string.Empty ? "" : this.MachineID)}");
            toStringOutput.Add($"this.SystemUUID = {(this.SystemUUID == null ? "null" : this.SystemUUID == string.Empty ? "" : this.SystemUUID)}");
            toStringOutput.Add($"this.BootID = {(this.BootID == null ? "null" : this.BootID == string.Empty ? "" : this.BootID)}");
            toStringOutput.Add($"this.KernelVersion = {(this.KernelVersion == null ? "null" : this.KernelVersion == string.Empty ? "" : this.KernelVersion)}");
            toStringOutput.Add($"this.OsImage = {(this.OsImage == null ? "null" : this.OsImage == string.Empty ? "" : this.OsImage)}");
            toStringOutput.Add($"this.ContainerRuntimeVersion = {(this.ContainerRuntimeVersion == null ? "null" : this.ContainerRuntimeVersion == string.Empty ? "" : this.ContainerRuntimeVersion)}");
            toStringOutput.Add($"this.KubeletVersion = {(this.KubeletVersion == null ? "null" : this.KubeletVersion == string.Empty ? "" : this.KubeletVersion)}");
            toStringOutput.Add($"this.KubeProxyVersion = {(this.KubeProxyVersion == null ? "null" : this.KubeProxyVersion == string.Empty ? "" : this.KubeProxyVersion)}");
            toStringOutput.Add($"this.OperatingSystem = {(this.OperatingSystem == null ? "null" : this.OperatingSystem == string.Empty ? "" : this.OperatingSystem)}");
            toStringOutput.Add($"this.Architecture = {(this.Architecture == null ? "null" : this.Architecture == string.Empty ? "" : this.Architecture)}");
        }
    }
}