// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodePipeline.Outputs
{

    [OutputType]
    public sealed class WebhookFilter
    {
        public readonly string JsonPath;
        public readonly string MatchEquals;

        [OutputConstructor]
        private WebhookFilter(
            string jsonPath,

            string matchEquals)
        {
            JsonPath = jsonPath;
            MatchEquals = matchEquals;
        }
    }
}