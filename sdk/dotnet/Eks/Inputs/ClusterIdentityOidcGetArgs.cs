// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks.Inputs
{

    public sealed class ClusterIdentityOidcGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Issuer URL for the OpenID Connect identity provider.
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        public ClusterIdentityOidcGetArgs()
        {
        }
    }
}