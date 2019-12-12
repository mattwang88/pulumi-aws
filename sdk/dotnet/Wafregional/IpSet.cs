// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafRegional
{
    /// <summary>
    /// Provides a WAF Regional IPSet Resource for use with Application Load Balancer.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/wafregional_ipset.html.markdown.
    /// </summary>
    public partial class IpSet : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of the WAF IPSet.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// One or more pairs specifying the IP address type (IPV4 or IPV6) and the IP address range (in CIDR notation) from which web requests originate.
        /// </summary>
        [Output("ipSetDescriptors")]
        public Output<ImmutableArray<Outputs.IpSetIpSetDescriptors>> IpSetDescriptors { get; private set; } = null!;

        /// <summary>
        /// The name or description of the IPSet.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a IpSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public IpSet(string name, IpSetArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:wafregional/ipSet:IpSet", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private IpSet(string name, Input<string> id, IpSetState? state = null, CustomResourceOptions? options = null)
            : base("aws:wafregional/ipSet:IpSet", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing IpSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static IpSet Get(string name, Input<string> id, IpSetState? state = null, CustomResourceOptions? options = null)
        {
            return new IpSet(name, id, state, options);
        }
    }

    public sealed class IpSetArgs : Pulumi.ResourceArgs
    {
        [Input("ipSetDescriptors")]
        private InputList<Inputs.IpSetIpSetDescriptorsArgs>? _ipSetDescriptors;

        /// <summary>
        /// One or more pairs specifying the IP address type (IPV4 or IPV6) and the IP address range (in CIDR notation) from which web requests originate.
        /// </summary>
        public InputList<Inputs.IpSetIpSetDescriptorsArgs> IpSetDescriptors
        {
            get => _ipSetDescriptors ?? (_ipSetDescriptors = new InputList<Inputs.IpSetIpSetDescriptorsArgs>());
            set => _ipSetDescriptors = value;
        }

        /// <summary>
        /// The name or description of the IPSet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public IpSetArgs()
        {
        }
    }

    public sealed class IpSetState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of the WAF IPSet.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("ipSetDescriptors")]
        private InputList<Inputs.IpSetIpSetDescriptorsGetArgs>? _ipSetDescriptors;

        /// <summary>
        /// One or more pairs specifying the IP address type (IPV4 or IPV6) and the IP address range (in CIDR notation) from which web requests originate.
        /// </summary>
        public InputList<Inputs.IpSetIpSetDescriptorsGetArgs> IpSetDescriptors
        {
            get => _ipSetDescriptors ?? (_ipSetDescriptors = new InputList<Inputs.IpSetIpSetDescriptorsGetArgs>());
            set => _ipSetDescriptors = value;
        }

        /// <summary>
        /// The name or description of the IPSet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public IpSetState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class IpSetIpSetDescriptorsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The string like IPV4 or IPV6.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The CIDR notation.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public IpSetIpSetDescriptorsArgs()
        {
        }
    }

    public sealed class IpSetIpSetDescriptorsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The string like IPV4 or IPV6.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        /// <summary>
        /// The CIDR notation.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public IpSetIpSetDescriptorsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class IpSetIpSetDescriptors
    {
        /// <summary>
        /// The string like IPV4 or IPV6.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The CIDR notation.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private IpSetIpSetDescriptors(
            string type,
            string value)
        {
            Type = type;
            Value = value;
        }
    }
    }
}
