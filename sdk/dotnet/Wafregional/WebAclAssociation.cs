// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafRegional
{
    /// <summary>
    /// Manages an association with WAF Regional Web ACL.
    /// 
    /// &gt; **Note:** An Application Load Balancer can only be associated with one WAF Regional WebACL.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/wafregional_web_acl_association.html.markdown.
    /// </summary>
    public partial class WebAclAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// ARN of the resource to associate with. For example, an Application Load Balancer or API Gateway Stage.
        /// </summary>
        [Output("resourceArn")]
        public Output<string> ResourceArn { get; private set; } = null!;

        /// <summary>
        /// The ID of the WAF Regional WebACL to create an association.
        /// </summary>
        [Output("webAclId")]
        public Output<string> WebAclId { get; private set; } = null!;


        /// <summary>
        /// Create a WebAclAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebAclAssociation(string name, WebAclAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws:wafregional/webAclAssociation:WebAclAssociation", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private WebAclAssociation(string name, Input<string> id, WebAclAssociationState? state = null, CustomResourceOptions? options = null)
            : base("aws:wafregional/webAclAssociation:WebAclAssociation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing WebAclAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebAclAssociation Get(string name, Input<string> id, WebAclAssociationState? state = null, CustomResourceOptions? options = null)
        {
            return new WebAclAssociation(name, id, state, options);
        }
    }

    public sealed class WebAclAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ARN of the resource to associate with. For example, an Application Load Balancer or API Gateway Stage.
        /// </summary>
        [Input("resourceArn", required: true)]
        public Input<string> ResourceArn { get; set; } = null!;

        /// <summary>
        /// The ID of the WAF Regional WebACL to create an association.
        /// </summary>
        [Input("webAclId", required: true)]
        public Input<string> WebAclId { get; set; } = null!;

        public WebAclAssociationArgs()
        {
        }
    }

    public sealed class WebAclAssociationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ARN of the resource to associate with. For example, an Application Load Balancer or API Gateway Stage.
        /// </summary>
        [Input("resourceArn")]
        public Input<string>? ResourceArn { get; set; }

        /// <summary>
        /// The ID of the WAF Regional WebACL to create an association.
        /// </summary>
        [Input("webAclId")]
        public Input<string>? WebAclId { get; set; }

        public WebAclAssociationState()
        {
        }
    }
}
