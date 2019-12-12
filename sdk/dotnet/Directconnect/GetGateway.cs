// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DirectConnect
{
    public static partial class Invokes
    {
        /// <summary>
        /// Retrieve information about a Direct Connect Gateway.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/dx_gateway.html.markdown.
        /// </summary>
        public static Task<GetGatewayResult> GetGateway(GetGatewayArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGatewayResult>("aws:directconnect/getGateway:getGateway", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetGatewayArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the gateway to retrieve.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetGatewayArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetGatewayResult
    {
        /// <summary>
        /// The ASN on the Amazon side of the connection.
        /// </summary>
        public readonly string AmazonSideAsn;
        public readonly string Name;
        /// <summary>
        /// AWS Account ID of the gateway.
        /// </summary>
        public readonly string OwnerAccountId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetGatewayResult(
            string amazonSideAsn,
            string name,
            string ownerAccountId,
            string id)
        {
            AmazonSideAsn = amazonSideAsn;
            Name = name;
            OwnerAccountId = ownerAccountId;
            Id = id;
        }
    }
}
