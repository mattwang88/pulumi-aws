// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Inputs
{

    public sealed class LaunchTemplateNetworkInterfaceGetArgs : Pulumi.ResourceArgs
    {
        [Input("associatePublicIpAddress")]
        public Input<string>? AssociatePublicIpAddress { get; set; }

        [Input("deleteOnTermination")]
        public Input<bool>? DeleteOnTermination { get; set; }

        /// <summary>
        /// Description of the launch template.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("deviceIndex")]
        public Input<int>? DeviceIndex { get; set; }

        [Input("ipv4AddressCount")]
        public Input<int>? Ipv4AddressCount { get; set; }

        [Input("ipv4Addresses")]
        private InputList<string>? _ipv4Addresses;
        public InputList<string> Ipv4Addresses
        {
            get => _ipv4Addresses ?? (_ipv4Addresses = new InputList<string>());
            set => _ipv4Addresses = value;
        }

        [Input("ipv6AddressCount")]
        public Input<int>? Ipv6AddressCount { get; set; }

        [Input("ipv6Addresses")]
        private InputList<string>? _ipv6Addresses;
        public InputList<string> Ipv6Addresses
        {
            get => _ipv6Addresses ?? (_ipv6Addresses = new InputList<string>());
            set => _ipv6Addresses = value;
        }

        [Input("networkInterfaceId")]
        public Input<string>? NetworkInterfaceId { get; set; }

        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public LaunchTemplateNetworkInterfaceGetArgs()
        {
        }
    }
}