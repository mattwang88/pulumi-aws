// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks.Inputs
{

    public sealed class ClusterCertificateAuthorityArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The base64 encoded certificate data required to communicate with your cluster. Add this to the `certificate-authority-data` section of the `kubeconfig` file for your cluster.
        /// </summary>
        [Input("data")]
        public Input<string>? Data { get; set; }

        public ClusterCertificateAuthorityArgs()
        {
        }
    }
}