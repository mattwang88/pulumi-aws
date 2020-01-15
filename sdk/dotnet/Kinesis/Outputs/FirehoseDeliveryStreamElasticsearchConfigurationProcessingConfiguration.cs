// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Outputs
{

    [OutputType]
    public sealed class FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration
    {
        /// <summary>
        /// Defaults to `true`. Set it to `false` if you want to disable format conversion while preserving the configuration details.
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// Array of data processors. More details are given below
        /// </summary>
        public readonly ImmutableArray<Outputs.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessor> Processors;

        [OutputConstructor]
        private FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfiguration(
            bool? enabled,

            ImmutableArray<Outputs.FirehoseDeliveryStreamElasticsearchConfigurationProcessingConfigurationProcessor> processors)
        {
            Enabled = enabled;
            Processors = processors;
        }
    }
}