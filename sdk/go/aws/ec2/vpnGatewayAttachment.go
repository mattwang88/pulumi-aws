// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Virtual Private Gateway attachment resource, allowing for an existing
// hardware VPN gateway to be attached and/or detached from a VPC.
//
// > **Note:** The `ec2.VpnGateway`
// resource can also automatically attach the Virtual Private Gateway it creates
// to an existing VPC by setting the `vpcId` attribute accordingly.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/vpn_gateway_attachment.html.markdown.
type VpnGatewayAttachment struct {
	pulumi.CustomResourceState

	// The ID of the VPC.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringOutput `pulumi:"vpnGatewayId"`
}

// NewVpnGatewayAttachment registers a new resource with the given unique name, arguments, and options.
func NewVpnGatewayAttachment(ctx *pulumi.Context,
	name string, args *VpnGatewayAttachmentArgs, opts ...pulumi.ResourceOption) (*VpnGatewayAttachment, error) {
	if args == nil || args.VpcId == nil {
		return nil, errors.New("missing required argument 'VpcId'")
	}
	if args == nil || args.VpnGatewayId == nil {
		return nil, errors.New("missing required argument 'VpnGatewayId'")
	}
	if args == nil {
		args = &VpnGatewayAttachmentArgs{}
	}
	var resource VpnGatewayAttachment
	err := ctx.RegisterResource("aws:ec2/vpnGatewayAttachment:VpnGatewayAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVpnGatewayAttachment gets an existing VpnGatewayAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVpnGatewayAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VpnGatewayAttachmentState, opts ...pulumi.ResourceOption) (*VpnGatewayAttachment, error) {
	var resource VpnGatewayAttachment
	err := ctx.ReadResource("aws:ec2/vpnGatewayAttachment:VpnGatewayAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VpnGatewayAttachment resources.
type vpnGatewayAttachmentState struct {
	// The ID of the VPC.
	VpcId *string `pulumi:"vpcId"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId *string `pulumi:"vpnGatewayId"`
}

type VpnGatewayAttachmentState struct {
	// The ID of the VPC.
	VpcId pulumi.StringPtrInput
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringPtrInput
}

func (VpnGatewayAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*vpnGatewayAttachmentState)(nil)).Elem()
}

type vpnGatewayAttachmentArgs struct {
	// The ID of the VPC.
	VpcId string `pulumi:"vpcId"`
	// The ID of the Virtual Private Gateway.
	VpnGatewayId string `pulumi:"vpnGatewayId"`
}

// The set of arguments for constructing a VpnGatewayAttachment resource.
type VpnGatewayAttachmentArgs struct {
	// The ID of the VPC.
	VpcId pulumi.StringInput
	// The ID of the Virtual Private Gateway.
	VpnGatewayId pulumi.StringInput
}

func (VpnGatewayAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*vpnGatewayAttachmentArgs)(nil)).Elem()
}
