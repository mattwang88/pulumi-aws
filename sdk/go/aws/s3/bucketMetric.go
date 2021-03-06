// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package s3

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a S3 bucket [metrics configuration](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html) resource.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/s3_bucket_metric.html.markdown.
type BucketMetric struct {
	pulumi.CustomResourceState

	// The name of the bucket to put metric configuration.
	Bucket pulumi.StringOutput `pulumi:"bucket"`
	// [Object filtering](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html#metrics-configurations-filter) that accepts a prefix, tags, or a logical AND of prefix and tags (documented below).
	Filter BucketMetricFilterPtrOutput `pulumi:"filter"`
	// Unique identifier of the metrics configuration for the bucket.
	Name pulumi.StringOutput `pulumi:"name"`
}

// NewBucketMetric registers a new resource with the given unique name, arguments, and options.
func NewBucketMetric(ctx *pulumi.Context,
	name string, args *BucketMetricArgs, opts ...pulumi.ResourceOption) (*BucketMetric, error) {
	if args == nil || args.Bucket == nil {
		return nil, errors.New("missing required argument 'Bucket'")
	}
	if args == nil {
		args = &BucketMetricArgs{}
	}
	var resource BucketMetric
	err := ctx.RegisterResource("aws:s3/bucketMetric:BucketMetric", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBucketMetric gets an existing BucketMetric resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBucketMetric(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BucketMetricState, opts ...pulumi.ResourceOption) (*BucketMetric, error) {
	var resource BucketMetric
	err := ctx.ReadResource("aws:s3/bucketMetric:BucketMetric", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BucketMetric resources.
type bucketMetricState struct {
	// The name of the bucket to put metric configuration.
	Bucket *string `pulumi:"bucket"`
	// [Object filtering](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html#metrics-configurations-filter) that accepts a prefix, tags, or a logical AND of prefix and tags (documented below).
	Filter *BucketMetricFilter `pulumi:"filter"`
	// Unique identifier of the metrics configuration for the bucket.
	Name *string `pulumi:"name"`
}

type BucketMetricState struct {
	// The name of the bucket to put metric configuration.
	Bucket pulumi.StringPtrInput
	// [Object filtering](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html#metrics-configurations-filter) that accepts a prefix, tags, or a logical AND of prefix and tags (documented below).
	Filter BucketMetricFilterPtrInput
	// Unique identifier of the metrics configuration for the bucket.
	Name pulumi.StringPtrInput
}

func (BucketMetricState) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketMetricState)(nil)).Elem()
}

type bucketMetricArgs struct {
	// The name of the bucket to put metric configuration.
	Bucket string `pulumi:"bucket"`
	// [Object filtering](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html#metrics-configurations-filter) that accepts a prefix, tags, or a logical AND of prefix and tags (documented below).
	Filter *BucketMetricFilter `pulumi:"filter"`
	// Unique identifier of the metrics configuration for the bucket.
	Name *string `pulumi:"name"`
}

// The set of arguments for constructing a BucketMetric resource.
type BucketMetricArgs struct {
	// The name of the bucket to put metric configuration.
	Bucket pulumi.StringInput
	// [Object filtering](http://docs.aws.amazon.com/AmazonS3/latest/dev/metrics-configurations.html#metrics-configurations-filter) that accepts a prefix, tags, or a logical AND of prefix and tags (documented below).
	Filter BucketMetricFilterPtrInput
	// Unique identifier of the metrics configuration for the bucket.
	Name pulumi.StringPtrInput
}

func (BucketMetricArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bucketMetricArgs)(nil)).Elem()
}
