// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cognito
{
    /// <summary>
    /// Provides a Cognito User Identity Provider resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/cognito_identity_provider.html.markdown.
    /// </summary>
    public partial class IdentityProvider : Pulumi.CustomResource
    {
        /// <summary>
        /// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
        /// </summary>
        [Output("attributeMapping")]
        public Output<ImmutableDictionary<string, object>?> AttributeMapping { get; private set; } = null!;

        /// <summary>
        /// The list of identity providers.
        /// </summary>
        [Output("idpIdentifiers")]
        public Output<ImmutableArray<string>> IdpIdentifiers { get; private set; } = null!;

        /// <summary>
        /// The map of identity details, such as access token
        /// </summary>
        [Output("providerDetails")]
        public Output<ImmutableDictionary<string, object>> ProviderDetails { get; private set; } = null!;

        /// <summary>
        /// The provider name
        /// </summary>
        [Output("providerName")]
        public Output<string> ProviderName { get; private set; } = null!;

        /// <summary>
        /// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
        /// </summary>
        [Output("providerType")]
        public Output<string> ProviderType { get; private set; } = null!;

        /// <summary>
        /// The user pool id
        /// </summary>
        [Output("userPoolId")]
        public Output<string> UserPoolId { get; private set; } = null!;


        /// <summary>
        /// Create a IdentityProvider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IdentityProvider(string name, IdentityProviderArgs args, CustomResourceOptions? options = null)
            : base("aws:cognito/identityProvider:IdentityProvider", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private IdentityProvider(string name, Input<string> id, IdentityProviderState? state = null, CustomResourceOptions? options = null)
            : base("aws:cognito/identityProvider:IdentityProvider", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IdentityProvider resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IdentityProvider Get(string name, Input<string> id, IdentityProviderState? state = null, CustomResourceOptions? options = null)
        {
            return new IdentityProvider(name, id, state, options);
        }
    }

    public sealed class IdentityProviderArgs : Pulumi.ResourceArgs
    {
        [Input("attributeMapping")]
        private InputMap<object>? _attributeMapping;

        /// <summary>
        /// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
        /// </summary>
        public InputMap<object> AttributeMapping
        {
            get => _attributeMapping ?? (_attributeMapping = new InputMap<object>());
            set => _attributeMapping = value;
        }

        [Input("idpIdentifiers")]
        private InputList<string>? _idpIdentifiers;

        /// <summary>
        /// The list of identity providers.
        /// </summary>
        public InputList<string> IdpIdentifiers
        {
            get => _idpIdentifiers ?? (_idpIdentifiers = new InputList<string>());
            set => _idpIdentifiers = value;
        }

        [Input("providerDetails", required: true)]
        private InputMap<object>? _providerDetails;

        /// <summary>
        /// The map of identity details, such as access token
        /// </summary>
        public InputMap<object> ProviderDetails
        {
            get => _providerDetails ?? (_providerDetails = new InputMap<object>());
            set => _providerDetails = value;
        }

        /// <summary>
        /// The provider name
        /// </summary>
        [Input("providerName", required: true)]
        public Input<string> ProviderName { get; set; } = null!;

        /// <summary>
        /// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
        /// </summary>
        [Input("providerType", required: true)]
        public Input<string> ProviderType { get; set; } = null!;

        /// <summary>
        /// The user pool id
        /// </summary>
        [Input("userPoolId", required: true)]
        public Input<string> UserPoolId { get; set; } = null!;

        public IdentityProviderArgs()
        {
        }
    }

    public sealed class IdentityProviderState : Pulumi.ResourceArgs
    {
        [Input("attributeMapping")]
        private InputMap<object>? _attributeMapping;

        /// <summary>
        /// The map of attribute mapping of user pool attributes. [AttributeMapping in AWS API documentation](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-AttributeMapping)
        /// </summary>
        public InputMap<object> AttributeMapping
        {
            get => _attributeMapping ?? (_attributeMapping = new InputMap<object>());
            set => _attributeMapping = value;
        }

        [Input("idpIdentifiers")]
        private InputList<string>? _idpIdentifiers;

        /// <summary>
        /// The list of identity providers.
        /// </summary>
        public InputList<string> IdpIdentifiers
        {
            get => _idpIdentifiers ?? (_idpIdentifiers = new InputList<string>());
            set => _idpIdentifiers = value;
        }

        [Input("providerDetails")]
        private InputMap<object>? _providerDetails;

        /// <summary>
        /// The map of identity details, such as access token
        /// </summary>
        public InputMap<object> ProviderDetails
        {
            get => _providerDetails ?? (_providerDetails = new InputMap<object>());
            set => _providerDetails = value;
        }

        /// <summary>
        /// The provider name
        /// </summary>
        [Input("providerName")]
        public Input<string>? ProviderName { get; set; }

        /// <summary>
        /// The provider type.  [See AWS API for valid values](https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_CreateIdentityProvider.html#CognitoUserPools-CreateIdentityProvider-request-ProviderType)
        /// </summary>
        [Input("providerType")]
        public Input<string>? ProviderType { get; set; }

        /// <summary>
        /// The user pool id
        /// </summary>
        [Input("userPoolId")]
        public Input<string>? UserPoolId { get; set; }

        public IdentityProviderState()
        {
        }
    }
}
