// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecTcpRouteActionWeightedTargetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The virtual node to associate with the weighted target.
        /// </summary>
        [Input("virtualNode", required: true)]
        public Input<string> VirtualNode { get; set; } = null!;

        /// <summary>
        /// The relative weight of the weighted target. An integer between 0 and 100.
        /// </summary>
        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public RouteSpecTcpRouteActionWeightedTargetArgs()
        {
        }
    }
}