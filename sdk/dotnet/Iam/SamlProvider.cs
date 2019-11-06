// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iam
{
    /// <summary>
    /// Provides an IAM SAML provider.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/iam_saml_provider.html.markdown.
    /// </summary>
    public partial class SamlProvider : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN assigned by AWS for this provider.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The name of the provider to create.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// An XML document generated by an identity provider that supports SAML 2.0.
        /// </summary>
        [Output("samlMetadataDocument")]
        public Output<string> SamlMetadataDocument { get; private set; } = null!;

        /// <summary>
        /// The expiration date and time for the SAML provider in RFC1123 format, e.g. `Mon, 02 Jan 2006 15:04:05 MST`.
        /// </summary>
        [Output("validUntil")]
        public Output<string> ValidUntil { get; private set; } = null!;


        /// <summary>
        /// Create a SamlProvider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SamlProvider(string name, SamlProviderArgs args, CustomResourceOptions? options = null)
            : base("aws:iam/samlProvider:SamlProvider", name, args, MakeResourceOptions(options, ""))
        {
        }

        private SamlProvider(string name, Input<string> id, SamlProviderState? state = null, CustomResourceOptions? options = null)
            : base("aws:iam/samlProvider:SamlProvider", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SamlProvider resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SamlProvider Get(string name, Input<string> id, SamlProviderState? state = null, CustomResourceOptions? options = null)
        {
            return new SamlProvider(name, id, state, options);
        }
    }

    public sealed class SamlProviderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the provider to create.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// An XML document generated by an identity provider that supports SAML 2.0.
        /// </summary>
        [Input("samlMetadataDocument", required: true)]
        public Input<string> SamlMetadataDocument { get; set; } = null!;

        public SamlProviderArgs()
        {
        }
    }

    public sealed class SamlProviderState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN assigned by AWS for this provider.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The name of the provider to create.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// An XML document generated by an identity provider that supports SAML 2.0.
        /// </summary>
        [Input("samlMetadataDocument")]
        public Input<string>? SamlMetadataDocument { get; set; }

        /// <summary>
        /// The expiration date and time for the SAML provider in RFC1123 format, e.g. `Mon, 02 Jan 2006 15:04:05 MST`.
        /// </summary>
        [Input("validUntil")]
        public Input<string>? ValidUntil { get; set; }

        public SamlProviderState()
        {
        }
    }
}