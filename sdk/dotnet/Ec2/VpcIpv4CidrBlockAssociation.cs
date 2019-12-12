// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    /// <summary>
    /// Provides a resource to associate additional IPv4 CIDR blocks with a VPC.
    /// 
    /// When a VPC is created, a primary IPv4 CIDR block for the VPC must be specified.
    /// The `aws.ec2.VpcIpv4CidrBlockAssociation` resource allows further IPv4 CIDR blocks to be added to the VPC.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/vpc_ipv4_cidr_block_association.html.markdown.
    /// </summary>
    public partial class VpcIpv4CidrBlockAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// The additional IPv4 CIDR block to associate with the VPC.
        /// </summary>
        [Output("cidrBlock")]
        public Output<string> CidrBlock { get; private set; } = null!;

        /// <summary>
        /// The ID of the VPC to make the association with.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a VpcIpv4CidrBlockAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VpcIpv4CidrBlockAssociation(string name, VpcIpv4CidrBlockAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2/vpcIpv4CidrBlockAssociation:VpcIpv4CidrBlockAssociation", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private VpcIpv4CidrBlockAssociation(string name, Input<string> id, VpcIpv4CidrBlockAssociationState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2/vpcIpv4CidrBlockAssociation:VpcIpv4CidrBlockAssociation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VpcIpv4CidrBlockAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VpcIpv4CidrBlockAssociation Get(string name, Input<string> id, VpcIpv4CidrBlockAssociationState? state = null, CustomResourceOptions? options = null)
        {
            return new VpcIpv4CidrBlockAssociation(name, id, state, options);
        }
    }

    public sealed class VpcIpv4CidrBlockAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The additional IPv4 CIDR block to associate with the VPC.
        /// </summary>
        [Input("cidrBlock", required: true)]
        public Input<string> CidrBlock { get; set; } = null!;

        /// <summary>
        /// The ID of the VPC to make the association with.
        /// </summary>
        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public VpcIpv4CidrBlockAssociationArgs()
        {
        }
    }

    public sealed class VpcIpv4CidrBlockAssociationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The additional IPv4 CIDR block to associate with the VPC.
        /// </summary>
        [Input("cidrBlock")]
        public Input<string>? CidrBlock { get; set; }

        /// <summary>
        /// The ID of the VPC to make the association with.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public VpcIpv4CidrBlockAssociationState()
        {
        }
    }
}
