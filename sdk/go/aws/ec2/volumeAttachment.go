// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ec2

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an AWS EBS Volume Attachment as a top level resource, to attach and
// detach volumes from AWS Instances.
//
// > **NOTE on EBS block devices:** If you use `ebsBlockDevice` on an `ec2.Instance`, this provider will assume management over the full set of non-root EBS block devices for the instance, and treats additional block devices as drift. For this reason, `ebsBlockDevice` cannot be mixed with external `ebs.Volume` + `awsEbsVolumeAttachment` resources for a given instance.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/volume_attachment.html.markdown.
type VolumeAttachment struct {
	pulumi.CustomResourceState

	// The device name to expose to the instance (for
	// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
	DeviceName pulumi.StringOutput `pulumi:"deviceName"`
	// Set to `true` if you want to force the
	// volume to detach. Useful if previous attempts failed, but use this option only
	// as a last resort, as this can result in **data loss**. See
	// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
	ForceDetach pulumi.BoolPtrOutput `pulumi:"forceDetach"`
	// ID of the Instance to attach to
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Set this to true if you do not wish
	// to detach the volume from the instance to which it is attached at destroy
	// time, and instead just remove the attachment from this provider state. This is
	// useful when destroying an instance which has volumes created by some other
	// means attached.
	SkipDestroy pulumi.BoolPtrOutput `pulumi:"skipDestroy"`
	// ID of the Volume to be attached
	VolumeId pulumi.StringOutput `pulumi:"volumeId"`
}

// NewVolumeAttachment registers a new resource with the given unique name, arguments, and options.
func NewVolumeAttachment(ctx *pulumi.Context,
	name string, args *VolumeAttachmentArgs, opts ...pulumi.ResourceOption) (*VolumeAttachment, error) {
	if args == nil || args.DeviceName == nil {
		return nil, errors.New("missing required argument 'DeviceName'")
	}
	if args == nil || args.InstanceId == nil {
		return nil, errors.New("missing required argument 'InstanceId'")
	}
	if args == nil || args.VolumeId == nil {
		return nil, errors.New("missing required argument 'VolumeId'")
	}
	if args == nil {
		args = &VolumeAttachmentArgs{}
	}
	var resource VolumeAttachment
	err := ctx.RegisterResource("aws:ec2/volumeAttachment:VolumeAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVolumeAttachment gets an existing VolumeAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVolumeAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VolumeAttachmentState, opts ...pulumi.ResourceOption) (*VolumeAttachment, error) {
	var resource VolumeAttachment
	err := ctx.ReadResource("aws:ec2/volumeAttachment:VolumeAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VolumeAttachment resources.
type volumeAttachmentState struct {
	// The device name to expose to the instance (for
	// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
	DeviceName *string `pulumi:"deviceName"`
	// Set to `true` if you want to force the
	// volume to detach. Useful if previous attempts failed, but use this option only
	// as a last resort, as this can result in **data loss**. See
	// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
	ForceDetach *bool `pulumi:"forceDetach"`
	// ID of the Instance to attach to
	InstanceId *string `pulumi:"instanceId"`
	// Set this to true if you do not wish
	// to detach the volume from the instance to which it is attached at destroy
	// time, and instead just remove the attachment from this provider state. This is
	// useful when destroying an instance which has volumes created by some other
	// means attached.
	SkipDestroy *bool `pulumi:"skipDestroy"`
	// ID of the Volume to be attached
	VolumeId *string `pulumi:"volumeId"`
}

type VolumeAttachmentState struct {
	// The device name to expose to the instance (for
	// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
	DeviceName pulumi.StringPtrInput
	// Set to `true` if you want to force the
	// volume to detach. Useful if previous attempts failed, but use this option only
	// as a last resort, as this can result in **data loss**. See
	// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
	ForceDetach pulumi.BoolPtrInput
	// ID of the Instance to attach to
	InstanceId pulumi.StringPtrInput
	// Set this to true if you do not wish
	// to detach the volume from the instance to which it is attached at destroy
	// time, and instead just remove the attachment from this provider state. This is
	// useful when destroying an instance which has volumes created by some other
	// means attached.
	SkipDestroy pulumi.BoolPtrInput
	// ID of the Volume to be attached
	VolumeId pulumi.StringPtrInput
}

func (VolumeAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeAttachmentState)(nil)).Elem()
}

type volumeAttachmentArgs struct {
	// The device name to expose to the instance (for
	// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
	DeviceName string `pulumi:"deviceName"`
	// Set to `true` if you want to force the
	// volume to detach. Useful if previous attempts failed, but use this option only
	// as a last resort, as this can result in **data loss**. See
	// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
	ForceDetach *bool `pulumi:"forceDetach"`
	// ID of the Instance to attach to
	InstanceId string `pulumi:"instanceId"`
	// Set this to true if you do not wish
	// to detach the volume from the instance to which it is attached at destroy
	// time, and instead just remove the attachment from this provider state. This is
	// useful when destroying an instance which has volumes created by some other
	// means attached.
	SkipDestroy *bool `pulumi:"skipDestroy"`
	// ID of the Volume to be attached
	VolumeId string `pulumi:"volumeId"`
}

// The set of arguments for constructing a VolumeAttachment resource.
type VolumeAttachmentArgs struct {
	// The device name to expose to the instance (for
	// example, `/dev/sdh` or `xvdh`).  See [Device Naming on Linux Instances][1] and [Device Naming on Windows Instances][2] for more information.
	DeviceName pulumi.StringInput
	// Set to `true` if you want to force the
	// volume to detach. Useful if previous attempts failed, but use this option only
	// as a last resort, as this can result in **data loss**. See
	// [Detaching an Amazon EBS Volume from an Instance][3] for more information.
	ForceDetach pulumi.BoolPtrInput
	// ID of the Instance to attach to
	InstanceId pulumi.StringInput
	// Set this to true if you do not wish
	// to detach the volume from the instance to which it is attached at destroy
	// time, and instead just remove the attachment from this provider state. This is
	// useful when destroying an instance which has volumes created by some other
	// means attached.
	SkipDestroy pulumi.BoolPtrInput
	// ID of the Volume to be attached
	VolumeId pulumi.StringInput
}

func (VolumeAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*volumeAttachmentArgs)(nil)).Elem()
}
