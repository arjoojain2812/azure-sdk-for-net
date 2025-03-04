// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Virtual Network resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class VirtualNetwork : Resource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        public VirtualNetwork()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetwork class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="extendedLocation">The extended location of the virtual
        /// network.</param>
        /// <param name="addressSpace">The AddressSpace that contains an array
        /// of IP address ranges that can be used by subnets.</param>
        /// <param name="dhcpOptions">The dhcpOptions that contains an array of
        /// DNS servers available to VMs deployed in the virtual
        /// network.</param>
        /// <param name="flowTimeoutInMinutes">The FlowTimeout value (in
        /// minutes) for the Virtual Network</param>
        /// <param name="subnets">A list of subnets in a Virtual
        /// Network.</param>
        /// <param name="virtualNetworkPeerings">A list of peerings in a
        /// Virtual Network.</param>
        /// <param name="resourceGuid">The resourceGuid property of the Virtual
        /// Network resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// virtual network resource. Possible values include: 'Succeeded',
        /// 'Updating', 'Deleting', 'Failed'</param>
        /// <param name="enableDdosProtection">Indicates if DDoS protection is
        /// enabled for all the protected resources in the virtual network. It
        /// requires a DDoS protection plan associated with the
        /// resource.</param>
        /// <param name="enableVmProtection">Indicates if VM protection is
        /// enabled for all the subnets in the virtual network.</param>
        /// <param name="ddosProtectionPlan">The DDoS protection plan
        /// associated with the virtual network.</param>
        /// <param name="bgpCommunities">Bgp Communities sent over ExpressRoute
        /// with each route corresponding to a prefix in this VNET.</param>
        /// <param name="ipAllocations">Array of IpAllocation which reference
        /// this VNET.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public VirtualNetwork(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ExtendedLocation extendedLocation = default(ExtendedLocation), AddressSpace addressSpace = default(AddressSpace), DhcpOptions dhcpOptions = default(DhcpOptions), int? flowTimeoutInMinutes = default(int?), IList<Subnet> subnets = default(IList<Subnet>), IList<VirtualNetworkPeering> virtualNetworkPeerings = default(IList<VirtualNetworkPeering>), string resourceGuid = default(string), string provisioningState = default(string), bool? enableDdosProtection = default(bool?), bool? enableVmProtection = default(bool?), SubResource ddosProtectionPlan = default(SubResource), VirtualNetworkBgpCommunities bgpCommunities = default(VirtualNetworkBgpCommunities), IList<SubResource> ipAllocations = default(IList<SubResource>), string etag = default(string))
            : base(id, name, type, location, tags)
        {
            ExtendedLocation = extendedLocation;
            AddressSpace = addressSpace;
            DhcpOptions = dhcpOptions;
            FlowTimeoutInMinutes = flowTimeoutInMinutes;
            Subnets = subnets;
            VirtualNetworkPeerings = virtualNetworkPeerings;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            EnableDdosProtection = enableDdosProtection;
            EnableVmProtection = enableVmProtection;
            DdosProtectionPlan = ddosProtectionPlan;
            BgpCommunities = bgpCommunities;
            IpAllocations = ipAllocations;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the extended location of the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Gets or sets the AddressSpace that contains an array of IP address
        /// ranges that can be used by subnets.
        /// </summary>
        [JsonProperty(PropertyName = "properties.addressSpace")]
        public AddressSpace AddressSpace { get; set; }

        /// <summary>
        /// Gets or sets the dhcpOptions that contains an array of DNS servers
        /// available to VMs deployed in the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dhcpOptions")]
        public DhcpOptions DhcpOptions { get; set; }

        /// <summary>
        /// Gets or sets the FlowTimeout value (in minutes) for the Virtual
        /// Network
        /// </summary>
        [JsonProperty(PropertyName = "properties.flowTimeoutInMinutes")]
        public int? FlowTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets a list of subnets in a Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnets")]
        public IList<Subnet> Subnets { get; set; }

        /// <summary>
        /// Gets or sets a list of peerings in a Virtual Network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualNetworkPeerings")]
        public IList<VirtualNetworkPeering> VirtualNetworkPeerings { get; set; }

        /// <summary>
        /// Gets the resourceGuid property of the Virtual Network resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the virtual network resource.
        /// Possible values include: 'Succeeded', 'Updating', 'Deleting',
        /// 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets indicates if DDoS protection is enabled for all the
        /// protected resources in the virtual network. It requires a DDoS
        /// protection plan associated with the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableDdosProtection")]
        public bool? EnableDdosProtection { get; set; }

        /// <summary>
        /// Gets or sets indicates if VM protection is enabled for all the
        /// subnets in the virtual network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableVmProtection")]
        public bool? EnableVmProtection { get; set; }

        /// <summary>
        /// Gets or sets the DDoS protection plan associated with the virtual
        /// network.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ddosProtectionPlan")]
        public SubResource DdosProtectionPlan { get; set; }

        /// <summary>
        /// Gets or sets bgp Communities sent over ExpressRoute with each route
        /// corresponding to a prefix in this VNET.
        /// </summary>
        [JsonProperty(PropertyName = "properties.bgpCommunities")]
        public VirtualNetworkBgpCommunities BgpCommunities { get; set; }

        /// <summary>
        /// Gets or sets array of IpAllocation which reference this VNET.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAllocations")]
        public IList<SubResource> IpAllocations { get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VirtualNetworkPeerings != null)
            {
                foreach (var element in VirtualNetworkPeerings)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (BgpCommunities != null)
            {
                BgpCommunities.Validate();
            }
        }
    }
}
