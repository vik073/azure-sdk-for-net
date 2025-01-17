// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the destination of connection monitor. </summary>
    public partial class ConnectionMonitorDestination
    {
        /// <summary> Initializes a new instance of ConnectionMonitorDestination. </summary>
        public ConnectionMonitorDestination()
        {
        }

        /// <summary> Initializes a new instance of ConnectionMonitorDestination. </summary>
        /// <param name="resourceId"> The ID of the resource used as the destination by connection monitor. </param>
        /// <param name="address"> Address of the connection monitor destination (IP or domain name). </param>
        /// <param name="port"> The destination port used by connection monitor. </param>
        internal ConnectionMonitorDestination(ResourceIdentifier resourceId, string address, int? port)
        {
            ResourceId = resourceId;
            Address = address;
            Port = port;
        }

        /// <summary> The ID of the resource used as the destination by connection monitor. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> Address of the connection monitor destination (IP or domain name). </summary>
        public string Address { get; set; }
        /// <summary> The destination port used by connection monitor. </summary>
        public int? Port { get; set; }
    }
}
