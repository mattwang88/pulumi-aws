// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package storagegateway

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an AWS Storage Gateway file, tape, or volume gateway in the provider region.
//
// > NOTE: The Storage Gateway API requires the gateway to be connected to properly return information after activation. If you are receiving `The specified gateway is not connected` errors during resource creation (gateway activation), ensure your gateway instance meets the [Storage Gateway requirements](https://docs.aws.amazon.com/storagegateway/latest/userguide/Requirements.html).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/storagegateway_gateway.html.markdown.
type Gateway struct {
	pulumi.CustomResourceState

	// Gateway activation key during resource creation. Conflicts with `gatewayIpAddress`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	ActivationKey pulumi.StringOutput `pulumi:"activationKey"`
	// Amazon Resource Name (ARN) of the gateway.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group to use to monitor and log events in the gateway.
	CloudwatchLogGroupArn pulumi.StringPtrOutput `pulumi:"cloudwatchLogGroupArn"`
	// Identifier of the gateway.
	GatewayId pulumi.StringOutput `pulumi:"gatewayId"`
	// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activationKey`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	GatewayIpAddress pulumi.StringOutput `pulumi:"gatewayIpAddress"`
	// Name of the gateway.
	GatewayName pulumi.StringOutput `pulumi:"gatewayName"`
	// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
	GatewayTimezone pulumi.StringOutput `pulumi:"gatewayTimezone"`
	// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
	GatewayType       pulumi.StringPtrOutput `pulumi:"gatewayType"`
	MediumChangerType pulumi.StringPtrOutput `pulumi:"mediumChangerType"`
	// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
	SmbActiveDirectorySettings GatewaySmbActiveDirectorySettingsPtrOutput `pulumi:"smbActiveDirectorySettings"`
	// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
	SmbGuestPassword pulumi.StringPtrOutput `pulumi:"smbGuestPassword"`
	// Key-value mapping of resource tags
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
	TapeDriveType pulumi.StringPtrOutput `pulumi:"tapeDriveType"`
}

// NewGateway registers a new resource with the given unique name, arguments, and options.
func NewGateway(ctx *pulumi.Context,
	name string, args *GatewayArgs, opts ...pulumi.ResourceOption) (*Gateway, error) {
	if args == nil || args.GatewayName == nil {
		return nil, errors.New("missing required argument 'GatewayName'")
	}
	if args == nil || args.GatewayTimezone == nil {
		return nil, errors.New("missing required argument 'GatewayTimezone'")
	}
	if args == nil {
		args = &GatewayArgs{}
	}
	var resource Gateway
	err := ctx.RegisterResource("aws:storagegateway/gateway:Gateway", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGateway gets an existing Gateway resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGateway(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GatewayState, opts ...pulumi.ResourceOption) (*Gateway, error) {
	var resource Gateway
	err := ctx.ReadResource("aws:storagegateway/gateway:Gateway", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Gateway resources.
type gatewayState struct {
	// Gateway activation key during resource creation. Conflicts with `gatewayIpAddress`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	ActivationKey *string `pulumi:"activationKey"`
	// Amazon Resource Name (ARN) of the gateway.
	Arn *string `pulumi:"arn"`
	// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group to use to monitor and log events in the gateway.
	CloudwatchLogGroupArn *string `pulumi:"cloudwatchLogGroupArn"`
	// Identifier of the gateway.
	GatewayId *string `pulumi:"gatewayId"`
	// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activationKey`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	GatewayIpAddress *string `pulumi:"gatewayIpAddress"`
	// Name of the gateway.
	GatewayName *string `pulumi:"gatewayName"`
	// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
	GatewayTimezone *string `pulumi:"gatewayTimezone"`
	// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
	GatewayType       *string `pulumi:"gatewayType"`
	MediumChangerType *string `pulumi:"mediumChangerType"`
	// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
	SmbActiveDirectorySettings *GatewaySmbActiveDirectorySettings `pulumi:"smbActiveDirectorySettings"`
	// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
	SmbGuestPassword *string `pulumi:"smbGuestPassword"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
	// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
	TapeDriveType *string `pulumi:"tapeDriveType"`
}

type GatewayState struct {
	// Gateway activation key during resource creation. Conflicts with `gatewayIpAddress`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	ActivationKey pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the gateway.
	Arn pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group to use to monitor and log events in the gateway.
	CloudwatchLogGroupArn pulumi.StringPtrInput
	// Identifier of the gateway.
	GatewayId pulumi.StringPtrInput
	// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activationKey`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	GatewayIpAddress pulumi.StringPtrInput
	// Name of the gateway.
	GatewayName pulumi.StringPtrInput
	// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
	GatewayTimezone pulumi.StringPtrInput
	// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
	GatewayType       pulumi.StringPtrInput
	MediumChangerType pulumi.StringPtrInput
	// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
	SmbActiveDirectorySettings GatewaySmbActiveDirectorySettingsPtrInput
	// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
	SmbGuestPassword pulumi.StringPtrInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
	// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
	TapeDriveType pulumi.StringPtrInput
}

func (GatewayState) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewayState)(nil)).Elem()
}

type gatewayArgs struct {
	// Gateway activation key during resource creation. Conflicts with `gatewayIpAddress`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	ActivationKey *string `pulumi:"activationKey"`
	// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group to use to monitor and log events in the gateway.
	CloudwatchLogGroupArn *string `pulumi:"cloudwatchLogGroupArn"`
	// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activationKey`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	GatewayIpAddress *string `pulumi:"gatewayIpAddress"`
	// Name of the gateway.
	GatewayName string `pulumi:"gatewayName"`
	// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
	GatewayTimezone string `pulumi:"gatewayTimezone"`
	// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
	GatewayType       *string `pulumi:"gatewayType"`
	MediumChangerType *string `pulumi:"mediumChangerType"`
	// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
	SmbActiveDirectorySettings *GatewaySmbActiveDirectorySettings `pulumi:"smbActiveDirectorySettings"`
	// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
	SmbGuestPassword *string `pulumi:"smbGuestPassword"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
	// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
	TapeDriveType *string `pulumi:"tapeDriveType"`
}

// The set of arguments for constructing a Gateway resource.
type GatewayArgs struct {
	// Gateway activation key during resource creation. Conflicts with `gatewayIpAddress`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	ActivationKey pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) of the Amazon CloudWatch log group to use to monitor and log events in the gateway.
	CloudwatchLogGroupArn pulumi.StringPtrInput
	// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activationKey`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
	GatewayIpAddress pulumi.StringPtrInput
	// Name of the gateway.
	GatewayName pulumi.StringInput
	// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
	GatewayTimezone pulumi.StringInput
	// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
	GatewayType       pulumi.StringPtrInput
	MediumChangerType pulumi.StringPtrInput
	// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
	SmbActiveDirectorySettings GatewaySmbActiveDirectorySettingsPtrInput
	// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
	SmbGuestPassword pulumi.StringPtrInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
	// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
	TapeDriveType pulumi.StringPtrInput
}

func (GatewayArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*gatewayArgs)(nil)).Elem()
}
