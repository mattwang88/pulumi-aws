// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Xray
{
    /// <summary>
    /// Creates and manages an AWS XRay Sampling Rule.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/xray_sampling_rule.html.markdown.
    /// </summary>
    public partial class SamplingRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the sampling rule.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Matches attributes derived from the request.
        /// </summary>
        [Output("attributes")]
        public Output<ImmutableDictionary<string, string>?> Attributes { get; private set; } = null!;

        /// <summary>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </summary>
        [Output("fixedRate")]
        public Output<double> FixedRate { get; private set; } = null!;

        /// <summary>
        /// Matches the hostname from a request URL.
        /// </summary>
        [Output("host")]
        public Output<string> Host { get; private set; } = null!;

        /// <summary>
        /// Matches the HTTP method of a request.
        /// </summary>
        [Output("httpMethod")]
        public Output<string> HttpMethod { get; private set; } = null!;

        /// <summary>
        /// The priority of the sampling rule.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;

        /// <summary>
        /// A fixed number of matching requests to instrument per second, prior to applying the fixed rate. The reservoir is not used directly by services, but applies to all services using the rule collectively.
        /// </summary>
        [Output("reservoirSize")]
        public Output<int> ReservoirSize { get; private set; } = null!;

        /// <summary>
        /// Matches the ARN of the AWS resource on which the service runs.
        /// </summary>
        [Output("resourceArn")]
        public Output<string> ResourceArn { get; private set; } = null!;

        /// <summary>
        /// The name of the sampling rule.
        /// </summary>
        [Output("ruleName")]
        public Output<string?> RuleName { get; private set; } = null!;

        /// <summary>
        /// Matches the `name` that the service uses to identify itself in segments.
        /// </summary>
        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;

        /// <summary>
        /// Matches the `origin` that the service uses to identify its type in segments.
        /// </summary>
        [Output("serviceType")]
        public Output<string> ServiceType { get; private set; } = null!;

        /// <summary>
        /// Matches the path from a request URL.
        /// </summary>
        [Output("urlPath")]
        public Output<string> UrlPath { get; private set; } = null!;

        /// <summary>
        /// The version of the sampling rule format (`1` )
        /// </summary>
        [Output("version")]
        public Output<int> Version { get; private set; } = null!;


        /// <summary>
        /// Create a SamplingRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SamplingRule(string name, SamplingRuleArgs args, CustomResourceOptions? options = null)
            : base("aws:xray/samplingRule:SamplingRule", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private SamplingRule(string name, Input<string> id, SamplingRuleState? state = null, CustomResourceOptions? options = null)
            : base("aws:xray/samplingRule:SamplingRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SamplingRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SamplingRule Get(string name, Input<string> id, SamplingRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new SamplingRule(name, id, state, options);
        }
    }

    public sealed class SamplingRuleArgs : Pulumi.ResourceArgs
    {
        [Input("attributes")]
        private InputMap<string>? _attributes;

        /// <summary>
        /// Matches attributes derived from the request.
        /// </summary>
        public InputMap<string> Attributes
        {
            get => _attributes ?? (_attributes = new InputMap<string>());
            set => _attributes = value;
        }

        /// <summary>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </summary>
        [Input("fixedRate", required: true)]
        public Input<double> FixedRate { get; set; } = null!;

        /// <summary>
        /// Matches the hostname from a request URL.
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// Matches the HTTP method of a request.
        /// </summary>
        [Input("httpMethod", required: true)]
        public Input<string> HttpMethod { get; set; } = null!;

        /// <summary>
        /// The priority of the sampling rule.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// A fixed number of matching requests to instrument per second, prior to applying the fixed rate. The reservoir is not used directly by services, but applies to all services using the rule collectively.
        /// </summary>
        [Input("reservoirSize", required: true)]
        public Input<int> ReservoirSize { get; set; } = null!;

        /// <summary>
        /// Matches the ARN of the AWS resource on which the service runs.
        /// </summary>
        [Input("resourceArn", required: true)]
        public Input<string> ResourceArn { get; set; } = null!;

        /// <summary>
        /// The name of the sampling rule.
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        /// <summary>
        /// Matches the `name` that the service uses to identify itself in segments.
        /// </summary>
        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        /// <summary>
        /// Matches the `origin` that the service uses to identify its type in segments.
        /// </summary>
        [Input("serviceType", required: true)]
        public Input<string> ServiceType { get; set; } = null!;

        /// <summary>
        /// Matches the path from a request URL.
        /// </summary>
        [Input("urlPath", required: true)]
        public Input<string> UrlPath { get; set; } = null!;

        /// <summary>
        /// The version of the sampling rule format (`1` )
        /// </summary>
        [Input("version", required: true)]
        public Input<int> Version { get; set; } = null!;

        public SamplingRuleArgs()
        {
        }
    }

    public sealed class SamplingRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the sampling rule.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("attributes")]
        private InputMap<string>? _attributes;

        /// <summary>
        /// Matches attributes derived from the request.
        /// </summary>
        public InputMap<string> Attributes
        {
            get => _attributes ?? (_attributes = new InputMap<string>());
            set => _attributes = value;
        }

        /// <summary>
        /// The percentage of matching requests to instrument, after the reservoir is exhausted.
        /// </summary>
        [Input("fixedRate")]
        public Input<double>? FixedRate { get; set; }

        /// <summary>
        /// Matches the hostname from a request URL.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Matches the HTTP method of a request.
        /// </summary>
        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        /// <summary>
        /// The priority of the sampling rule.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// A fixed number of matching requests to instrument per second, prior to applying the fixed rate. The reservoir is not used directly by services, but applies to all services using the rule collectively.
        /// </summary>
        [Input("reservoirSize")]
        public Input<int>? ReservoirSize { get; set; }

        /// <summary>
        /// Matches the ARN of the AWS resource on which the service runs.
        /// </summary>
        [Input("resourceArn")]
        public Input<string>? ResourceArn { get; set; }

        /// <summary>
        /// The name of the sampling rule.
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        /// <summary>
        /// Matches the `name` that the service uses to identify itself in segments.
        /// </summary>
        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        /// <summary>
        /// Matches the `origin` that the service uses to identify its type in segments.
        /// </summary>
        [Input("serviceType")]
        public Input<string>? ServiceType { get; set; }

        /// <summary>
        /// Matches the path from a request URL.
        /// </summary>
        [Input("urlPath")]
        public Input<string>? UrlPath { get; set; }

        /// <summary>
        /// The version of the sampling rule format (`1` )
        /// </summary>
        [Input("version")]
        public Input<int>? Version { get; set; }

        public SamplingRuleState()
        {
        }
    }
}
