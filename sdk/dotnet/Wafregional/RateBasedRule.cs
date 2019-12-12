// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafRegional
{
    /// <summary>
    /// Provides a WAF Rate Based Rule Resource
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/wafregional_rate_based_rule.html.markdown.
    /// </summary>
    public partial class RateBasedRule : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the WAF Regional Rate Based Rule.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The name or description for the Amazon CloudWatch metric of this rule.
        /// </summary>
        [Output("metricName")]
        public Output<string> MetricName { get; private set; } = null!;

        /// <summary>
        /// The name or description of the rule.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The objects to include in a rule (documented below).
        /// </summary>
        [Output("predicates")]
        public Output<ImmutableArray<Outputs.RateBasedRulePredicates>> Predicates { get; private set; } = null!;

        /// <summary>
        /// Valid value is IP.
        /// </summary>
        [Output("rateKey")]
        public Output<string> RateKey { get; private set; } = null!;

        /// <summary>
        /// The maximum number of requests, which have an identical value in the field specified by the RateKey, allowed in a five-minute period. Minimum value is 100.
        /// </summary>
        [Output("rateLimit")]
        public Output<int> RateLimit { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a RateBasedRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RateBasedRule(string name, RateBasedRuleArgs args, CustomResourceOptions? options = null)
            : base("aws:wafregional/rateBasedRule:RateBasedRule", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private RateBasedRule(string name, Input<string> id, RateBasedRuleState? state = null, CustomResourceOptions? options = null)
            : base("aws:wafregional/rateBasedRule:RateBasedRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RateBasedRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RateBasedRule Get(string name, Input<string> id, RateBasedRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new RateBasedRule(name, id, state, options);
        }
    }

    public sealed class RateBasedRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name or description for the Amazon CloudWatch metric of this rule.
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// The name or description of the rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("predicates")]
        private InputList<Inputs.RateBasedRulePredicatesArgs>? _predicates;

        /// <summary>
        /// The objects to include in a rule (documented below).
        /// </summary>
        public InputList<Inputs.RateBasedRulePredicatesArgs> Predicates
        {
            get => _predicates ?? (_predicates = new InputList<Inputs.RateBasedRulePredicatesArgs>());
            set => _predicates = value;
        }

        /// <summary>
        /// Valid value is IP.
        /// </summary>
        [Input("rateKey", required: true)]
        public Input<string> RateKey { get; set; } = null!;

        /// <summary>
        /// The maximum number of requests, which have an identical value in the field specified by the RateKey, allowed in a five-minute period. Minimum value is 100.
        /// </summary>
        [Input("rateLimit", required: true)]
        public Input<int> RateLimit { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public RateBasedRuleArgs()
        {
        }
    }

    public sealed class RateBasedRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the WAF Regional Rate Based Rule.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The name or description for the Amazon CloudWatch metric of this rule.
        /// </summary>
        [Input("metricName")]
        public Input<string>? MetricName { get; set; }

        /// <summary>
        /// The name or description of the rule.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("predicates")]
        private InputList<Inputs.RateBasedRulePredicatesGetArgs>? _predicates;

        /// <summary>
        /// The objects to include in a rule (documented below).
        /// </summary>
        public InputList<Inputs.RateBasedRulePredicatesGetArgs> Predicates
        {
            get => _predicates ?? (_predicates = new InputList<Inputs.RateBasedRulePredicatesGetArgs>());
            set => _predicates = value;
        }

        /// <summary>
        /// Valid value is IP.
        /// </summary>
        [Input("rateKey")]
        public Input<string>? RateKey { get; set; }

        /// <summary>
        /// The maximum number of requests, which have an identical value in the field specified by the RateKey, allowed in a five-minute period. Minimum value is 100.
        /// </summary>
        [Input("rateLimit")]
        public Input<int>? RateLimit { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public RateBasedRuleState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class RateBasedRulePredicatesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.
        /// </summary>
        [Input("dataId", required: true)]
        public Input<string> DataId { get; set; } = null!;

        /// <summary>
        /// Set this to `false` if you want to allow, block, or count requests
        /// based on the settings in the specified `ByteMatchSet`, `IPSet`, `SqlInjectionMatchSet`, `XssMatchSet`, or `SizeConstraintSet`.
        /// For example, if an IPSet includes the IP address `192.0.2.44`, AWS WAF will allow or block requests based on that IP address.
        /// If set to `true`, AWS WAF will allow, block, or count requests based on all IP addresses _except_ `192.0.2.44`.
        /// </summary>
        [Input("negated", required: true)]
        public Input<bool> Negated { get; set; } = null!;

        /// <summary>
        /// The type of predicate in a rule. Valid values: `ByteMatch`, `GeoMatch`, `IPMatch`, `RegexMatch`, `SizeConstraint`, `SqlInjectionMatch`, or `XssMatch`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public RateBasedRulePredicatesArgs()
        {
        }
    }

    public sealed class RateBasedRulePredicatesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.
        /// </summary>
        [Input("dataId", required: true)]
        public Input<string> DataId { get; set; } = null!;

        /// <summary>
        /// Set this to `false` if you want to allow, block, or count requests
        /// based on the settings in the specified `ByteMatchSet`, `IPSet`, `SqlInjectionMatchSet`, `XssMatchSet`, or `SizeConstraintSet`.
        /// For example, if an IPSet includes the IP address `192.0.2.44`, AWS WAF will allow or block requests based on that IP address.
        /// If set to `true`, AWS WAF will allow, block, or count requests based on all IP addresses _except_ `192.0.2.44`.
        /// </summary>
        [Input("negated", required: true)]
        public Input<bool> Negated { get; set; } = null!;

        /// <summary>
        /// The type of predicate in a rule. Valid values: `ByteMatch`, `GeoMatch`, `IPMatch`, `RegexMatch`, `SizeConstraint`, `SqlInjectionMatch`, or `XssMatch`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public RateBasedRulePredicatesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class RateBasedRulePredicates
    {
        /// <summary>
        /// A unique identifier for a predicate in the rule, such as Byte Match Set ID or IPSet ID.
        /// </summary>
        public readonly string DataId;
        /// <summary>
        /// Set this to `false` if you want to allow, block, or count requests
        /// based on the settings in the specified `ByteMatchSet`, `IPSet`, `SqlInjectionMatchSet`, `XssMatchSet`, or `SizeConstraintSet`.
        /// For example, if an IPSet includes the IP address `192.0.2.44`, AWS WAF will allow or block requests based on that IP address.
        /// If set to `true`, AWS WAF will allow, block, or count requests based on all IP addresses _except_ `192.0.2.44`.
        /// </summary>
        public readonly bool Negated;
        /// <summary>
        /// The type of predicate in a rule. Valid values: `ByteMatch`, `GeoMatch`, `IPMatch`, `RegexMatch`, `SizeConstraint`, `SqlInjectionMatch`, or `XssMatch`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private RateBasedRulePredicates(
            string dataId,
            bool negated,
            string type)
        {
            DataId = dataId;
            Negated = negated;
            Type = type;
        }
    }
    }
}
