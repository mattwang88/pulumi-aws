// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package batch

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Batch Job Definition resource.
//
// ## retryStrategy
//
// `retryStrategy` supports the following:
//
// * `attempts` - (Optional) The number of times to move a job to the `RUNNABLE` status. You may specify between `1` and `10` attempts.
//
// ## timeout
//
// `timeout` supports the following:
//
// * `attemptDurationSeconds` - (Optional) The time duration in seconds after which AWS Batch terminates your jobs if they have not finished. The minimum value for the timeout is `60` seconds.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/batch_job_definition.html.markdown.
type JobDefinition struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name of the job definition.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// A valid [container properties](http://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html)
	// provided as a single valid JSON document. This parameter is required if the `type` parameter is `container`.
	ContainerProperties pulumi.StringPtrOutput `pulumi:"containerProperties"`
	// Specifies the name of the job definition.
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the parameter substitution placeholders to set in the job definition.
	Parameters pulumi.StringMapOutput `pulumi:"parameters"`
	// Specifies the retry strategy to use for failed jobs that are submitted with this job definition.
	// Maximum number of `retryStrategy` is `1`.  Defined below.
	RetryStrategy JobDefinitionRetryStrategyPtrOutput `pulumi:"retryStrategy"`
	// The revision of the job definition.
	Revision pulumi.IntOutput `pulumi:"revision"`
	// Specifies the timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of `timeout` is `1`. Defined below.
	Timeout JobDefinitionTimeoutPtrOutput `pulumi:"timeout"`
	// The type of job definition.  Must be `container`
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewJobDefinition registers a new resource with the given unique name, arguments, and options.
func NewJobDefinition(ctx *pulumi.Context,
	name string, args *JobDefinitionArgs, opts ...pulumi.ResourceOption) (*JobDefinition, error) {
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &JobDefinitionArgs{}
	}
	var resource JobDefinition
	err := ctx.RegisterResource("aws:batch/jobDefinition:JobDefinition", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetJobDefinition gets an existing JobDefinition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetJobDefinition(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *JobDefinitionState, opts ...pulumi.ResourceOption) (*JobDefinition, error) {
	var resource JobDefinition
	err := ctx.ReadResource("aws:batch/jobDefinition:JobDefinition", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering JobDefinition resources.
type jobDefinitionState struct {
	// The Amazon Resource Name of the job definition.
	Arn *string `pulumi:"arn"`
	// A valid [container properties](http://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html)
	// provided as a single valid JSON document. This parameter is required if the `type` parameter is `container`.
	ContainerProperties *string `pulumi:"containerProperties"`
	// Specifies the name of the job definition.
	Name *string `pulumi:"name"`
	// Specifies the parameter substitution placeholders to set in the job definition.
	Parameters map[string]string `pulumi:"parameters"`
	// Specifies the retry strategy to use for failed jobs that are submitted with this job definition.
	// Maximum number of `retryStrategy` is `1`.  Defined below.
	RetryStrategy *JobDefinitionRetryStrategy `pulumi:"retryStrategy"`
	// The revision of the job definition.
	Revision *int `pulumi:"revision"`
	// Specifies the timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of `timeout` is `1`. Defined below.
	Timeout *JobDefinitionTimeout `pulumi:"timeout"`
	// The type of job definition.  Must be `container`
	Type *string `pulumi:"type"`
}

type JobDefinitionState struct {
	// The Amazon Resource Name of the job definition.
	Arn pulumi.StringPtrInput
	// A valid [container properties](http://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html)
	// provided as a single valid JSON document. This parameter is required if the `type` parameter is `container`.
	ContainerProperties pulumi.StringPtrInput
	// Specifies the name of the job definition.
	Name pulumi.StringPtrInput
	// Specifies the parameter substitution placeholders to set in the job definition.
	Parameters pulumi.StringMapInput
	// Specifies the retry strategy to use for failed jobs that are submitted with this job definition.
	// Maximum number of `retryStrategy` is `1`.  Defined below.
	RetryStrategy JobDefinitionRetryStrategyPtrInput
	// The revision of the job definition.
	Revision pulumi.IntPtrInput
	// Specifies the timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of `timeout` is `1`. Defined below.
	Timeout JobDefinitionTimeoutPtrInput
	// The type of job definition.  Must be `container`
	Type pulumi.StringPtrInput
}

func (JobDefinitionState) ElementType() reflect.Type {
	return reflect.TypeOf((*jobDefinitionState)(nil)).Elem()
}

type jobDefinitionArgs struct {
	// A valid [container properties](http://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html)
	// provided as a single valid JSON document. This parameter is required if the `type` parameter is `container`.
	ContainerProperties *string `pulumi:"containerProperties"`
	// Specifies the name of the job definition.
	Name *string `pulumi:"name"`
	// Specifies the parameter substitution placeholders to set in the job definition.
	Parameters map[string]string `pulumi:"parameters"`
	// Specifies the retry strategy to use for failed jobs that are submitted with this job definition.
	// Maximum number of `retryStrategy` is `1`.  Defined below.
	RetryStrategy *JobDefinitionRetryStrategy `pulumi:"retryStrategy"`
	// Specifies the timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of `timeout` is `1`. Defined below.
	Timeout *JobDefinitionTimeout `pulumi:"timeout"`
	// The type of job definition.  Must be `container`
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a JobDefinition resource.
type JobDefinitionArgs struct {
	// A valid [container properties](http://docs.aws.amazon.com/batch/latest/APIReference/API_RegisterJobDefinition.html)
	// provided as a single valid JSON document. This parameter is required if the `type` parameter is `container`.
	ContainerProperties pulumi.StringPtrInput
	// Specifies the name of the job definition.
	Name pulumi.StringPtrInput
	// Specifies the parameter substitution placeholders to set in the job definition.
	Parameters pulumi.StringMapInput
	// Specifies the retry strategy to use for failed jobs that are submitted with this job definition.
	// Maximum number of `retryStrategy` is `1`.  Defined below.
	RetryStrategy JobDefinitionRetryStrategyPtrInput
	// Specifies the timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of `timeout` is `1`. Defined below.
	Timeout JobDefinitionTimeoutPtrInput
	// The type of job definition.  Must be `container`
	Type pulumi.StringInput
}

func (JobDefinitionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*jobDefinitionArgs)(nil)).Elem()
}
