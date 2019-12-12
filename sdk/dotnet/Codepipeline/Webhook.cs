// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodePipeline
{
    /// <summary>
    /// Provides a CodePipeline Webhook.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/codepipeline_webhook.html.markdown.
    /// </summary>
    public partial class Webhook : Pulumi.CustomResource
    {
        /// <summary>
        /// The type of authentication  to use. One of `IP`, `GITHUB_HMAC`, or `UNAUTHENTICATED`.
        /// </summary>
        [Output("authentication")]
        public Output<string> Authentication { get; private set; } = null!;

        /// <summary>
        /// An `auth` block. Required for `IP` and `GITHUB_HMAC`. Auth blocks are documented below.
        /// </summary>
        [Output("authenticationConfiguration")]
        public Output<Outputs.WebhookAuthenticationConfiguration?> AuthenticationConfiguration { get; private set; } = null!;

        /// <summary>
        /// One or more `filter` blocks. Filter blocks are documented below.
        /// </summary>
        [Output("filters")]
        public Output<ImmutableArray<Outputs.WebhookFilters>> Filters { get; private set; } = null!;

        /// <summary>
        /// The name of the webhook.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The name of the action in a pipeline you want to connect to the webhook. The action must be from the source (first) stage of the pipeline.
        /// </summary>
        [Output("targetAction")]
        public Output<string> TargetAction { get; private set; } = null!;

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Output("targetPipeline")]
        public Output<string> TargetPipeline { get; private set; } = null!;

        /// <summary>
        /// The CodePipeline webhook's URL. POST events to this endpoint to trigger the target.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a Webhook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Webhook(string name, WebhookArgs args, CustomResourceOptions? options = null)
            : base("aws:codepipeline/webhook:Webhook", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Webhook(string name, Input<string> id, WebhookState? state = null, CustomResourceOptions? options = null)
            : base("aws:codepipeline/webhook:Webhook", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Webhook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Webhook Get(string name, Input<string> id, WebhookState? state = null, CustomResourceOptions? options = null)
        {
            return new Webhook(name, id, state, options);
        }
    }

    public sealed class WebhookArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of authentication  to use. One of `IP`, `GITHUB_HMAC`, or `UNAUTHENTICATED`.
        /// </summary>
        [Input("authentication", required: true)]
        public Input<string> Authentication { get; set; } = null!;

        /// <summary>
        /// An `auth` block. Required for `IP` and `GITHUB_HMAC`. Auth blocks are documented below.
        /// </summary>
        [Input("authenticationConfiguration")]
        public Input<Inputs.WebhookAuthenticationConfigurationArgs>? AuthenticationConfiguration { get; set; }

        [Input("filters", required: true)]
        private InputList<Inputs.WebhookFiltersArgs>? _filters;

        /// <summary>
        /// One or more `filter` blocks. Filter blocks are documented below.
        /// </summary>
        public InputList<Inputs.WebhookFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.WebhookFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The name of the webhook.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the action in a pipeline you want to connect to the webhook. The action must be from the source (first) stage of the pipeline.
        /// </summary>
        [Input("targetAction", required: true)]
        public Input<string> TargetAction { get; set; } = null!;

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("targetPipeline", required: true)]
        public Input<string> TargetPipeline { get; set; } = null!;

        public WebhookArgs()
        {
        }
    }

    public sealed class WebhookState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The type of authentication  to use. One of `IP`, `GITHUB_HMAC`, or `UNAUTHENTICATED`.
        /// </summary>
        [Input("authentication")]
        public Input<string>? Authentication { get; set; }

        /// <summary>
        /// An `auth` block. Required for `IP` and `GITHUB_HMAC`. Auth blocks are documented below.
        /// </summary>
        [Input("authenticationConfiguration")]
        public Input<Inputs.WebhookAuthenticationConfigurationGetArgs>? AuthenticationConfiguration { get; set; }

        [Input("filters")]
        private InputList<Inputs.WebhookFiltersGetArgs>? _filters;

        /// <summary>
        /// One or more `filter` blocks. Filter blocks are documented below.
        /// </summary>
        public InputList<Inputs.WebhookFiltersGetArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.WebhookFiltersGetArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The name of the webhook.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the action in a pipeline you want to connect to the webhook. The action must be from the source (first) stage of the pipeline.
        /// </summary>
        [Input("targetAction")]
        public Input<string>? TargetAction { get; set; }

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("targetPipeline")]
        public Input<string>? TargetPipeline { get; set; }

        /// <summary>
        /// The CodePipeline webhook's URL. POST events to this endpoint to trigger the target.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public WebhookState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class WebhookAuthenticationConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("allowedIpRange")]
        public Input<string>? AllowedIpRange { get; set; }

        [Input("secretToken")]
        public Input<string>? SecretToken { get; set; }

        public WebhookAuthenticationConfigurationArgs()
        {
        }
    }

    public sealed class WebhookAuthenticationConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("allowedIpRange")]
        public Input<string>? AllowedIpRange { get; set; }

        [Input("secretToken")]
        public Input<string>? SecretToken { get; set; }

        public WebhookAuthenticationConfigurationGetArgs()
        {
        }
    }

    public sealed class WebhookFiltersArgs : Pulumi.ResourceArgs
    {
        [Input("jsonPath", required: true)]
        public Input<string> JsonPath { get; set; } = null!;

        [Input("matchEquals", required: true)]
        public Input<string> MatchEquals { get; set; } = null!;

        public WebhookFiltersArgs()
        {
        }
    }

    public sealed class WebhookFiltersGetArgs : Pulumi.ResourceArgs
    {
        [Input("jsonPath", required: true)]
        public Input<string> JsonPath { get; set; } = null!;

        [Input("matchEquals", required: true)]
        public Input<string> MatchEquals { get; set; } = null!;

        public WebhookFiltersGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class WebhookAuthenticationConfiguration
    {
        public readonly string? AllowedIpRange;
        public readonly string? SecretToken;

        [OutputConstructor]
        private WebhookAuthenticationConfiguration(
            string? allowedIpRange,
            string? secretToken)
        {
            AllowedIpRange = allowedIpRange;
            SecretToken = secretToken;
        }
    }

    [OutputType]
    public sealed class WebhookFilters
    {
        public readonly string JsonPath;
        public readonly string MatchEquals;

        [OutputConstructor]
        private WebhookFilters(
            string jsonPath,
            string matchEquals)
        {
            JsonPath = jsonPath;
            MatchEquals = matchEquals;
        }
    }
    }
}
