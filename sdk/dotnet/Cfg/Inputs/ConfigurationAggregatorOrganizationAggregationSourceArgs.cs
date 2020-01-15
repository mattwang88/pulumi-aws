// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Cfg.Inputs
{

    public sealed class ConfigurationAggregatorOrganizationAggregationSourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// If true, aggregate existing AWS Config regions and future regions.
        /// </summary>
        [Input("allRegions")]
        public Input<bool>? AllRegions { get; set; }

        [Input("regions")]
        private InputList<string>? _regions;

        /// <summary>
        /// List of source regions being aggregated.
        /// </summary>
        public InputList<string> Regions
        {
            get => _regions ?? (_regions = new InputList<string>());
            set => _regions = value;
        }

        /// <summary>
        /// ARN of the IAM role used to retrieve AWS Organization details associated with the aggregator account.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public ConfigurationAggregatorOrganizationAggregationSourceArgs()
        {
        }
    }
}