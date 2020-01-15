// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodePipeline.Inputs
{

    public sealed class PipelineStageArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.PipelineStageActionArgs>? _actions;
        public InputList<Inputs.PipelineStageActionArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.PipelineStageActionArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public PipelineStageArgs()
        {
        }
    }
}