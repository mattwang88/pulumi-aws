// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package directoryservice

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a conditional forwarder for managed Microsoft AD in AWS Directory Service.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/directory_service_conditional_forwarder.html.markdown.
type ConditionalForwader struct {
	pulumi.CustomResourceState

	// The id of directory.
	DirectoryId pulumi.StringOutput `pulumi:"directoryId"`
	// A list of forwarder IP addresses.
	DnsIps pulumi.StringArrayOutput `pulumi:"dnsIps"`
	// The fully qualified domain name of the remote domain for which forwarders will be used.
	RemoteDomainName pulumi.StringOutput `pulumi:"remoteDomainName"`
}

// NewConditionalForwader registers a new resource with the given unique name, arguments, and options.
func NewConditionalForwader(ctx *pulumi.Context,
	name string, args *ConditionalForwaderArgs, opts ...pulumi.ResourceOption) (*ConditionalForwader, error) {
	if args == nil || args.DirectoryId == nil {
		return nil, errors.New("missing required argument 'DirectoryId'")
	}
	if args == nil || args.DnsIps == nil {
		return nil, errors.New("missing required argument 'DnsIps'")
	}
	if args == nil || args.RemoteDomainName == nil {
		return nil, errors.New("missing required argument 'RemoteDomainName'")
	}
	if args == nil {
		args = &ConditionalForwaderArgs{}
	}
	var resource ConditionalForwader
	err := ctx.RegisterResource("aws:directoryservice/conditionalForwader:ConditionalForwader", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConditionalForwader gets an existing ConditionalForwader resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConditionalForwader(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConditionalForwaderState, opts ...pulumi.ResourceOption) (*ConditionalForwader, error) {
	var resource ConditionalForwader
	err := ctx.ReadResource("aws:directoryservice/conditionalForwader:ConditionalForwader", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConditionalForwader resources.
type conditionalForwaderState struct {
	// The id of directory.
	DirectoryId *string `pulumi:"directoryId"`
	// A list of forwarder IP addresses.
	DnsIps []string `pulumi:"dnsIps"`
	// The fully qualified domain name of the remote domain for which forwarders will be used.
	RemoteDomainName *string `pulumi:"remoteDomainName"`
}

type ConditionalForwaderState struct {
	// The id of directory.
	DirectoryId pulumi.StringPtrInput
	// A list of forwarder IP addresses.
	DnsIps pulumi.StringArrayInput
	// The fully qualified domain name of the remote domain for which forwarders will be used.
	RemoteDomainName pulumi.StringPtrInput
}

func (ConditionalForwaderState) ElementType() reflect.Type {
	return reflect.TypeOf((*conditionalForwaderState)(nil)).Elem()
}

type conditionalForwaderArgs struct {
	// The id of directory.
	DirectoryId string `pulumi:"directoryId"`
	// A list of forwarder IP addresses.
	DnsIps []string `pulumi:"dnsIps"`
	// The fully qualified domain name of the remote domain for which forwarders will be used.
	RemoteDomainName string `pulumi:"remoteDomainName"`
}

// The set of arguments for constructing a ConditionalForwader resource.
type ConditionalForwaderArgs struct {
	// The id of directory.
	DirectoryId pulumi.StringInput
	// A list of forwarder IP addresses.
	DnsIps pulumi.StringArrayInput
	// The fully qualified domain name of the remote domain for which forwarders will be used.
	RemoteDomainName pulumi.StringInput
}

func (ConditionalForwaderArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*conditionalForwaderArgs)(nil)).Elem()
}
