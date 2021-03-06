// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package storagegateway

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Retrieve information about a Storage Gateway local disk. The disk identifier is useful for adding the disk as a cache or upload buffer to a gateway.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/storagegateway_local_disk.html.markdown.
func GetLocalDisk(ctx *pulumi.Context, args *GetLocalDiskArgs, opts ...pulumi.InvokeOption) (*GetLocalDiskResult, error) {
	var rv GetLocalDiskResult
	err := ctx.Invoke("aws:storagegateway/getLocalDisk:getLocalDisk", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getLocalDisk.
type GetLocalDiskArgs struct {
	// The device node of the local disk to retrieve. For example, `/dev/sdb`.
	DiskNode *string `pulumi:"diskNode"`
	// The device path of the local disk to retrieve. For example, `/dev/xvdb` or `/dev/nvme1n1`.
	DiskPath *string `pulumi:"diskPath"`
	// The Amazon Resource Name (ARN) of the gateway.
	GatewayArn string `pulumi:"gatewayArn"`
}

// A collection of values returned by getLocalDisk.
type GetLocalDiskResult struct {
	// The disk identifier. e.g. `pci-0000:03:00.0-scsi-0:0:0:0`
	DiskId     string  `pulumi:"diskId"`
	DiskNode   *string `pulumi:"diskNode"`
	DiskPath   *string `pulumi:"diskPath"`
	GatewayArn string  `pulumi:"gatewayArn"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}
