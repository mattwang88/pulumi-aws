// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to get the ID of a registered AMI for use in other
 * resources.
 */
export function getAmi(args?: GetAmiArgs): Promise<GetAmiResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:index/getAmi:getAmi", {
        "executableUsers": args.executableUsers,
        "filters": args.filters,
        "mostRecent": args.mostRecent,
        "nameRegex": args.nameRegex,
        "owners": args.owners,
        "tags": args.tags,
    });
}

/**
 * A collection of arguments for invoking getAmi.
 */
export interface GetAmiArgs {
    /**
     * Limit search to users with *explicit* launch permission on
     * the image. Valid items are the numeric account ID or `self`.
     */
    readonly executableUsers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * One or more name/value pairs to filter off of. There are
     * several valid keys, for a full reference, check out
     * [describe-images in the AWS CLI reference][1].
     */
    readonly filters?: pulumi.Input<{ name: pulumi.Input<string>, values: pulumi.Input<pulumi.Input<string>[]> }[]>;
    /**
     * If more than one result is returned, use the most
     * recent AMI.
     */
    readonly mostRecent?: pulumi.Input<boolean>;
    /**
     * A regex string to apply to the AMI list returned
     * by AWS. This allows more advanced filtering not supported from the AWS API. This
     * filtering is done locally on what AWS returns, and could have a performance
     * impact if the result is large. It is recommended to combine this with other
     * options to narrow down the list AWS returns.
     */
    readonly nameRegex?: pulumi.Input<string>;
    /**
     * Limit search to specific AMI owners. Valid items are the numeric
     * account ID, `amazon`, or `self`.
     */
    readonly owners?: pulumi.Input<pulumi.Input<string>[]>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * A collection of values returned by getAmi.
 */
export interface GetAmiResult {
    /**
     * The OS architecture of the AMI (ie: `i386` or `x86_64`).
     */
    readonly architecture: string;
    /**
     * The block device mappings of the AMI.
     * * `block_device_mappings.#.device_name` - The physical name of the device.
     * * `block_device_mappings.#.ebs.delete_on_termination` - `true` if the EBS volume
     * will be deleted on termination.
     * * `block_device_mappings.#.ebs.encrypted` - `true` if the EBS volume
     * is encrypted.
     * * `block_device_mappings.#.ebs.iops` - `0` if the EBS volume is
     * not a provisioned IOPS image, otherwise the supported IOPS count.
     * * `block_device_mappings.#.ebs.snapshot_id` - The ID of the snapshot.
     * * `block_device_mappings.#.ebs.volume_size` - The size of the volume, in GiB.
     * * `block_device_mappings.#.ebs.volume_type` - The volume type.
     * * `block_device_mappings.#.no_device` - Suppresses the specified device
     * included in the block device mapping of the AMI.
     * * `block_device_mappings.#.virtual_name` - The virtual device name (for
     * instance stores).
     */
    readonly blockDeviceMappings: { deviceName: string, ebs: {[key: string]: any}, noDevice: string, virtualName: string }[];
    /**
     * The date and time the image was created.
     */
    readonly creationDate: string;
    /**
     * The description of the AMI that was provided during image
     * creation.
     */
    readonly description: string;
    /**
     * The hypervisor type of the image.
     */
    readonly hypervisor: string;
    /**
     * The ID of the AMI. Should be the same as the resource `id`.
     */
    readonly imageId: string;
    /**
     * The location of the AMI.
     */
    readonly imageLocation: string;
    /**
     * The AWS account alias (for example, `amazon`, `self`) or
     * the AWS account ID of the AMI owner.
     */
    readonly imageOwnerAlias: string;
    /**
     * The type of image.
     */
    readonly imageType: string;
    /**
     * The kernel associated with the image, if any. Only applicable
     * for machine images.
     */
    readonly kernelId: string;
    /**
     * The name of the AMI that was provided during image creation.
     */
    readonly name: string;
    /**
     * The AWS account ID of the image owner.
     */
    readonly ownerId: string;
    /**
     * The value is Windows for `Windows` AMIs; otherwise blank.
     */
    readonly platform: string;
    /**
     * Any product codes associated with the AMI.
     * * `product_codes.#.product_code_id` - The product code.
     * * `product_codes.#.product_code_type` - The type of product code.
     */
    readonly productCodes: { productCodeId: string, productCodeType: string }[];
    /**
     * `true` if the image has public launch permissions.
     */
    readonly public: boolean;
    /**
     * The RAM disk associated with the image, if any. Only applicable
     * for machine images.
     */
    readonly ramdiskId: string;
    /**
     * The device name of the root device.
     */
    readonly rootDeviceName: string;
    /**
     * The type of root device (ie: `ebs` or `instance-store`).
     */
    readonly rootDeviceType: string;
    /**
     * The snapshot id associated with the root device, if any
     * (only applies to `ebs` root devices).
     */
    readonly rootSnapshotId: string;
    /**
     * Specifies whether enhanced networking is enabled.
     */
    readonly sriovNetSupport: string;
    /**
     * The current state of the AMI. If the state is `available`, the image
     * is successfully registered and can be used to launch an instance.
     */
    readonly state: string;
    /**
     * Describes a state change. Fields are `UNSET` if not available.
     * * `state_reason.code` - The reason code for the state change.
     * * `state_reason.message` - The message for the state change.
     */
    readonly stateReason: {[key: string]: any};
    /**
     * Any tags assigned to the image.
     * * `tags.#.key` - The key name of the tag.
     * * `tags.#.value` - The value of the tag.
     */
    readonly tags: {[key: string]: any};
    /**
     * The type of virtualization of the AMI (ie: `hvm` or
     * `paravirtual`).
     */
    readonly virtualizationType: string;
}
