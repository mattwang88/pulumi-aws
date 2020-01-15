// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DirectoryService.Outputs
{

    [OutputType]
    public sealed class DirectoryVpcSettings
    {
        /// <summary>
        /// The identifiers of the subnets for the directory servers (2 subnets in 2 different AZs).
        /// </summary>
        public readonly ImmutableArray<string> SubnetIds;
        /// <summary>
        /// The identifier of the VPC that the directory is in.
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private DirectoryVpcSettings(
            ImmutableArray<string> subnetIds,

            string vpcId)
        {
            SubnetIds = subnetIds;
            VpcId = vpcId;
        }
    }
}