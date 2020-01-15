// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy.Outputs
{

    [OutputType]
    public sealed class DeploymentGroupEcsService
    {
        /// <summary>
        /// The name of the ECS cluster.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// The name of the ECS service.
        /// </summary>
        public readonly string ServiceName;

        [OutputConstructor]
        private DeploymentGroupEcsService(
            string clusterName,

            string serviceName)
        {
            ClusterName = clusterName;
            ServiceName = serviceName;
        }
    }
}