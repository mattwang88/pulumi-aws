// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Adds permission to create volumes off of a given EBS Snapshot.
 */
export class SnapshotCreateVolumePermission extends pulumi.CustomResource {
    /**
     * Get an existing SnapshotCreateVolumePermission resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SnapshotCreateVolumePermissionState): SnapshotCreateVolumePermission {
        return new SnapshotCreateVolumePermission(name, <any>state, { id });
    }

    /**
     * An AWS Account ID to add create volume permissions
     */
    public readonly accountId: pulumi.Output<string>;
    /**
     * A snapshot ID
     */
    public readonly snapshotId: pulumi.Output<string>;

    /**
     * Create a SnapshotCreateVolumePermission resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SnapshotCreateVolumePermissionArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: SnapshotCreateVolumePermissionArgs | SnapshotCreateVolumePermissionState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SnapshotCreateVolumePermissionState = argsOrState as SnapshotCreateVolumePermissionState | undefined;
            inputs["accountId"] = state ? state.accountId : undefined;
            inputs["snapshotId"] = state ? state.snapshotId : undefined;
        } else {
            const args = argsOrState as SnapshotCreateVolumePermissionArgs | undefined;
            if (!args || args.accountId === undefined) {
                throw new Error("Missing required property 'accountId'");
            }
            if (!args || args.snapshotId === undefined) {
                throw new Error("Missing required property 'snapshotId'");
            }
            inputs["accountId"] = args ? args.accountId : undefined;
            inputs["snapshotId"] = args ? args.snapshotId : undefined;
        }
        super("aws:ec2/snapshotCreateVolumePermission:SnapshotCreateVolumePermission", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SnapshotCreateVolumePermission resources.
 */
export interface SnapshotCreateVolumePermissionState {
    /**
     * An AWS Account ID to add create volume permissions
     */
    readonly accountId?: pulumi.Input<string>;
    /**
     * A snapshot ID
     */
    readonly snapshotId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SnapshotCreateVolumePermission resource.
 */
export interface SnapshotCreateVolumePermissionArgs {
    /**
     * An AWS Account ID to add create volume permissions
     */
    readonly accountId: pulumi.Input<string>;
    /**
     * A snapshot ID
     */
    readonly snapshotId: pulumi.Input<string>;
}
