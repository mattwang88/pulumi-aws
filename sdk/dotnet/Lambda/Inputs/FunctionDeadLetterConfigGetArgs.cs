// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Lambda.Inputs
{

    public sealed class FunctionDeadLetterConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of an SNS topic or SQS queue to notify when an invocation fails. If this
        /// option is used, the function's IAM role must be granted suitable access to write to the target object,
        /// which means allowing either the `sns:Publish` or `sqs:SendMessage` action on this ARN, depending on
        /// which service is targeted.
        /// </summary>
        [Input("targetArn", required: true)]
        public Input<string> TargetArn { get; set; } = null!;

        public FunctionDeadLetterConfigGetArgs()
        {
        }
    }
}