// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.AppMesh.Inputs
{

    public sealed class RouteSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The HTTP routing information for the route.
        /// </summary>
        [Input("httpRoute")]
        public Input<Inputs.RouteSpecHttpRouteArgs>? HttpRoute { get; set; }

        /// <summary>
        /// The TCP routing information for the route.
        /// </summary>
        [Input("tcpRoute")]
        public Input<Inputs.RouteSpecTcpRouteArgs>? TcpRoute { get; set; }

        public RouteSpecArgs()
        {
        }
    }
}