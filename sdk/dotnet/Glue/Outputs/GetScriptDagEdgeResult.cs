// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue.Outputs
{

    [OutputType]
    public sealed class GetScriptDagEdgeResult
    {
        /// <summary>
        /// The ID of the node at which the edge starts.
        /// </summary>
        public readonly string Source;
        /// <summary>
        /// The ID of the node at which the edge ends.
        /// </summary>
        public readonly string Target;
        /// <summary>
        /// The target of the edge.
        /// </summary>
        public readonly string? TargetParameter;

        [OutputConstructor]
        private GetScriptDagEdgeResult(
            string source,

            string target,

            string? targetParameter)
        {
            Source = source;
            Target = target;
            TargetParameter = targetParameter;
        }
    }
}