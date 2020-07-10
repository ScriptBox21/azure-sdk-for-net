// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile. </summary>
    public partial class VirtualMachineScaleSetNetworkProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetNetworkProfile. </summary>
        public VirtualMachineScaleSetNetworkProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetNetworkProfile. </summary>
        /// <param name="healthProbe"> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;. </param>
        /// <param name="networkInterfaceConfigurations"> The list of network configurations. </param>
        internal VirtualMachineScaleSetNetworkProfile(ApiEntityReference healthProbe, IList<VirtualMachineScaleSetNetworkConfiguration> networkInterfaceConfigurations)
        {
            HealthProbe = healthProbe;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
        }

        /// <summary> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: &apos;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}&apos;. </summary>
        public ApiEntityReference HealthProbe { get; set; }
        /// <summary> The list of network configurations. </summary>
        public IList<VirtualMachineScaleSetNetworkConfiguration> NetworkInterfaceConfigurations { get; set; }
    }
}