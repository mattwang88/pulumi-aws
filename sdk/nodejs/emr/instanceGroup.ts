// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides an Elastic MapReduce Cluster Instance Group configuration.
 * See [Amazon Elastic MapReduce Documentation](https://aws.amazon.com/documentation/emr/) for more information.
 * 
 * ~> **NOTE:** At this time, Instance Groups cannot be destroyed through the API nor
 * web interface. Instance Groups are destroyed when the EMR Cluster is destroyed.
 * Terraform will resize any Instance Group to zero when destroying the resource.
 */
export class InstanceGroup extends pulumi.CustomResource {
    /**
     * Get an existing InstanceGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceGroupState): InstanceGroup {
        return new InstanceGroup(name, <any>state, { id });
    }

    /**
     * ID of the EMR Cluster to attach to. Changing this forces a new resource to be created.
     */
    public readonly clusterId: pulumi.Output<string>;
    /**
     * One or more `ebs_config` blocks as defined below. Changing this forces a new resource to be created.
     */
    public readonly ebsConfigs: pulumi.Output<{ iops?: number, size: number, type: string, volumesPerInstance?: number }[] | undefined>;
    /**
     * Indicates whether an Amazon EBS volume is EBS-optimized. Changing this forces a new resource to be created.
     */
    public readonly ebsOptimized: pulumi.Output<boolean | undefined>;
    /**
     * Target number of instances for the instance group. Defaults to 0.
     */
    public readonly instanceCount: pulumi.Output<number | undefined>;
    /**
     * The EC2 instance type for all instances in the instance group. Changing this forces a new resource to be created.
     */
    public readonly instanceType: pulumi.Output<string>;
    /**
     * Human friendly name given to the instance group. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    public /*out*/ readonly runningInstanceCount: pulumi.Output<number>;
    public /*out*/ readonly status: pulumi.Output<string>;

    /**
     * Create a InstanceGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceGroupArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: InstanceGroupArgs | InstanceGroupState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: InstanceGroupState = argsOrState as InstanceGroupState | undefined;
            inputs["clusterId"] = state ? state.clusterId : undefined;
            inputs["ebsConfigs"] = state ? state.ebsConfigs : undefined;
            inputs["ebsOptimized"] = state ? state.ebsOptimized : undefined;
            inputs["instanceCount"] = state ? state.instanceCount : undefined;
            inputs["instanceType"] = state ? state.instanceType : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["runningInstanceCount"] = state ? state.runningInstanceCount : undefined;
            inputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as InstanceGroupArgs | undefined;
            if (!args || args.clusterId === undefined) {
                throw new Error("Missing required property 'clusterId'");
            }
            if (!args || args.instanceType === undefined) {
                throw new Error("Missing required property 'instanceType'");
            }
            inputs["clusterId"] = args ? args.clusterId : undefined;
            inputs["ebsConfigs"] = args ? args.ebsConfigs : undefined;
            inputs["ebsOptimized"] = args ? args.ebsOptimized : undefined;
            inputs["instanceCount"] = args ? args.instanceCount : undefined;
            inputs["instanceType"] = args ? args.instanceType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["runningInstanceCount"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        super("aws:emr/instanceGroup:InstanceGroup", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering InstanceGroup resources.
 */
export interface InstanceGroupState {
    /**
     * ID of the EMR Cluster to attach to. Changing this forces a new resource to be created.
     */
    readonly clusterId?: pulumi.Input<string>;
    /**
     * One or more `ebs_config` blocks as defined below. Changing this forces a new resource to be created.
     */
    readonly ebsConfigs?: pulumi.Input<{ iops?: pulumi.Input<number>, size: pulumi.Input<number>, type: pulumi.Input<string>, volumesPerInstance?: pulumi.Input<number> }[]>;
    /**
     * Indicates whether an Amazon EBS volume is EBS-optimized. Changing this forces a new resource to be created.
     */
    readonly ebsOptimized?: pulumi.Input<boolean>;
    /**
     * Target number of instances for the instance group. Defaults to 0.
     */
    readonly instanceCount?: pulumi.Input<number>;
    /**
     * The EC2 instance type for all instances in the instance group. Changing this forces a new resource to be created.
     */
    readonly instanceType?: pulumi.Input<string>;
    /**
     * Human friendly name given to the instance group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    readonly runningInstanceCount?: pulumi.Input<number>;
    readonly status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a InstanceGroup resource.
 */
export interface InstanceGroupArgs {
    /**
     * ID of the EMR Cluster to attach to. Changing this forces a new resource to be created.
     */
    readonly clusterId: pulumi.Input<string>;
    /**
     * One or more `ebs_config` blocks as defined below. Changing this forces a new resource to be created.
     */
    readonly ebsConfigs?: pulumi.Input<{ iops?: pulumi.Input<number>, size: pulumi.Input<number>, type: pulumi.Input<string>, volumesPerInstance?: pulumi.Input<number> }[]>;
    /**
     * Indicates whether an Amazon EBS volume is EBS-optimized. Changing this forces a new resource to be created.
     */
    readonly ebsOptimized?: pulumi.Input<boolean>;
    /**
     * Target number of instances for the instance group. Defaults to 0.
     */
    readonly instanceCount?: pulumi.Input<number>;
    /**
     * The EC2 instance type for all instances in the instance group. Changing this forces a new resource to be created.
     */
    readonly instanceType: pulumi.Input<string>;
    /**
     * Human friendly name given to the instance group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
}
