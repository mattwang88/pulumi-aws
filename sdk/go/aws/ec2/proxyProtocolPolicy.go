// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a proxy protocol policy, which allows an ELB to carry a client connection information to a backend.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/proxy_protocol_policy.html.markdown.
type ProxyProtocolPolicy struct {
	pulumi.CustomResourceState

	// List of instance ports to which the policy
	// should be applied. This can be specified if the protocol is SSL or TCP.
	InstancePorts pulumi.StringArrayOutput `pulumi:"instancePorts"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringOutput `pulumi:"loadBalancer"`
}

// NewProxyProtocolPolicy registers a new resource with the given unique name, arguments, and options.
func NewProxyProtocolPolicy(ctx *pulumi.Context,
	name string, args *ProxyProtocolPolicyArgs, opts ...pulumi.ResourceOption) (*ProxyProtocolPolicy, error) {
	if args == nil || args.InstancePorts == nil {
		return nil, errors.New("missing required argument 'InstancePorts'")
	}
	if args == nil || args.LoadBalancer == nil {
		return nil, errors.New("missing required argument 'LoadBalancer'")
	}
	if args == nil {
		args = &ProxyProtocolPolicyArgs{}
	}
	var resource ProxyProtocolPolicy
	err := ctx.RegisterResource("aws:ec2/proxyProtocolPolicy:ProxyProtocolPolicy", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProxyProtocolPolicy gets an existing ProxyProtocolPolicy resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProxyProtocolPolicy(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProxyProtocolPolicyState, opts ...pulumi.ResourceOption) (*ProxyProtocolPolicy, error) {
	var resource ProxyProtocolPolicy
	err := ctx.ReadResource("aws:ec2/proxyProtocolPolicy:ProxyProtocolPolicy", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProxyProtocolPolicy resources.
type proxyProtocolPolicyState struct {
	// List of instance ports to which the policy
	// should be applied. This can be specified if the protocol is SSL or TCP.
	InstancePorts []string `pulumi:"instancePorts"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer *string `pulumi:"loadBalancer"`
}

type ProxyProtocolPolicyState struct {
	// List of instance ports to which the policy
	// should be applied. This can be specified if the protocol is SSL or TCP.
	InstancePorts pulumi.StringArrayInput
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringPtrInput
}

func (ProxyProtocolPolicyState) ElementType() reflect.Type {
	return reflect.TypeOf((*proxyProtocolPolicyState)(nil)).Elem()
}

type proxyProtocolPolicyArgs struct {
	// List of instance ports to which the policy
	// should be applied. This can be specified if the protocol is SSL or TCP.
	InstancePorts []string `pulumi:"instancePorts"`
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer string `pulumi:"loadBalancer"`
}

// The set of arguments for constructing a ProxyProtocolPolicy resource.
type ProxyProtocolPolicyArgs struct {
	// List of instance ports to which the policy
	// should be applied. This can be specified if the protocol is SSL or TCP.
	InstancePorts pulumi.StringArrayInput
	// The load balancer to which the policy
	// should be attached.
	LoadBalancer pulumi.StringInput
}

func (ProxyProtocolPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*proxyProtocolPolicyArgs)(nil)).Elem()
}
