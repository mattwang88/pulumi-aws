// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package apigateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Connects a custom domain name registered via `apigateway.DomainName`
// with a deployed API so that its methods can be called via the
// custom domain name.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/api_gateway_base_path_mapping.html.markdown.
type BasePathMapping struct {
	pulumi.CustomResourceState

	// Path segment that must be prepended to the path when accessing the API via this mapping. If omitted, the API is exposed at the root of the given domain.
	BasePath pulumi.StringPtrOutput `pulumi:"basePath"`
	// The already-registered domain name to connect the API to.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// The id of the API to connect.
	RestApi pulumi.StringOutput `pulumi:"restApi"`
	// The name of a specific deployment stage to expose at the given path. If omitted, callers may select any stage by including its name as a path element after the base path.
	StageName pulumi.StringPtrOutput `pulumi:"stageName"`
}

// NewBasePathMapping registers a new resource with the given unique name, arguments, and options.
func NewBasePathMapping(ctx *pulumi.Context,
	name string, args *BasePathMappingArgs, opts ...pulumi.ResourceOption) (*BasePathMapping, error) {
	if args == nil || args.DomainName == nil {
		return nil, errors.New("missing required argument 'DomainName'")
	}
	if args == nil || args.RestApi == nil {
		return nil, errors.New("missing required argument 'RestApi'")
	}
	if args == nil {
		args = &BasePathMappingArgs{}
	}
	var resource BasePathMapping
	err := ctx.RegisterResource("aws:apigateway/basePathMapping:BasePathMapping", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBasePathMapping gets an existing BasePathMapping resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBasePathMapping(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BasePathMappingState, opts ...pulumi.ResourceOption) (*BasePathMapping, error) {
	var resource BasePathMapping
	err := ctx.ReadResource("aws:apigateway/basePathMapping:BasePathMapping", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BasePathMapping resources.
type basePathMappingState struct {
	// Path segment that must be prepended to the path when accessing the API via this mapping. If omitted, the API is exposed at the root of the given domain.
	BasePath *string `pulumi:"basePath"`
	// The already-registered domain name to connect the API to.
	DomainName *string `pulumi:"domainName"`
	// The id of the API to connect.
	RestApi *string `pulumi:"restApi"`
	// The name of a specific deployment stage to expose at the given path. If omitted, callers may select any stage by including its name as a path element after the base path.
	StageName *string `pulumi:"stageName"`
}

type BasePathMappingState struct {
	// Path segment that must be prepended to the path when accessing the API via this mapping. If omitted, the API is exposed at the root of the given domain.
	BasePath pulumi.StringPtrInput
	// The already-registered domain name to connect the API to.
	DomainName pulumi.StringPtrInput
	// The id of the API to connect.
	RestApi pulumi.StringPtrInput
	// The name of a specific deployment stage to expose at the given path. If omitted, callers may select any stage by including its name as a path element after the base path.
	StageName pulumi.StringPtrInput
}

func (BasePathMappingState) ElementType() reflect.Type {
	return reflect.TypeOf((*basePathMappingState)(nil)).Elem()
}

type basePathMappingArgs struct {
	// Path segment that must be prepended to the path when accessing the API via this mapping. If omitted, the API is exposed at the root of the given domain.
	BasePath *string `pulumi:"basePath"`
	// The already-registered domain name to connect the API to.
	DomainName string `pulumi:"domainName"`
	// The id of the API to connect.
	RestApi interface{} `pulumi:"restApi"`
	// The name of a specific deployment stage to expose at the given path. If omitted, callers may select any stage by including its name as a path element after the base path.
	StageName *string `pulumi:"stageName"`
}

// The set of arguments for constructing a BasePathMapping resource.
type BasePathMappingArgs struct {
	// Path segment that must be prepended to the path when accessing the API via this mapping. If omitted, the API is exposed at the root of the given domain.
	BasePath pulumi.StringPtrInput
	// The already-registered domain name to connect the API to.
	DomainName pulumi.StringInput
	// The id of the API to connect.
	RestApi pulumi.Input
	// The name of a specific deployment stage to expose at the given path. If omitted, callers may select any stage by including its name as a path element after the base path.
	StageName pulumi.StringPtrInput
}

func (BasePathMappingArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*basePathMappingArgs)(nil)).Elem()
}
