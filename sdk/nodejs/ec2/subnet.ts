// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides an VPC subnet resource.
 */
export class Subnet extends pulumi.CustomResource {
    /**
     * Get an existing Subnet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SubnetState): Subnet {
        return new Subnet(name, <any>state, { id });
    }

    /**
     * Specify true to indicate
     * that network interfaces created in the specified subnet should be
     * assigned an IPv6 address. Default is `false`
     */
    public readonly assignIpv6AddressOnCreation: pulumi.Output<boolean | undefined>;
    public readonly availabilityZone: pulumi.Output<string>;
    /**
     * The CIDR block for the subnet.
     */
    public readonly cidrBlock: pulumi.Output<string>;
    /**
     * The IPv6 network range for the subnet,
     * in CIDR notation. The subnet size must use a /64 prefix length.
     */
    public readonly ipv6CidrBlock: pulumi.Output<string>;
    public /*out*/ readonly ipv6CidrBlockAssociationId: pulumi.Output<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address. Default is `false`.
     */
    public readonly mapPublicIpOnLaunch: pulumi.Output<boolean | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The VPC ID.
     */
    public readonly vpcId: pulumi.Output<string>;

    /**
     * Create a Subnet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubnetArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: SubnetArgs | SubnetState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SubnetState = argsOrState as SubnetState | undefined;
            inputs["assignIpv6AddressOnCreation"] = state ? state.assignIpv6AddressOnCreation : undefined;
            inputs["availabilityZone"] = state ? state.availabilityZone : undefined;
            inputs["cidrBlock"] = state ? state.cidrBlock : undefined;
            inputs["ipv6CidrBlock"] = state ? state.ipv6CidrBlock : undefined;
            inputs["ipv6CidrBlockAssociationId"] = state ? state.ipv6CidrBlockAssociationId : undefined;
            inputs["mapPublicIpOnLaunch"] = state ? state.mapPublicIpOnLaunch : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as SubnetArgs | undefined;
            if (!args || args.cidrBlock === undefined) {
                throw new Error("Missing required property 'cidrBlock'");
            }
            if (!args || args.vpcId === undefined) {
                throw new Error("Missing required property 'vpcId'");
            }
            inputs["assignIpv6AddressOnCreation"] = args ? args.assignIpv6AddressOnCreation : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["cidrBlock"] = args ? args.cidrBlock : undefined;
            inputs["ipv6CidrBlock"] = args ? args.ipv6CidrBlock : undefined;
            inputs["mapPublicIpOnLaunch"] = args ? args.mapPublicIpOnLaunch : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vpcId"] = args ? args.vpcId : undefined;
            inputs["ipv6CidrBlockAssociationId"] = undefined /*out*/;
        }
        super("aws:ec2/subnet:Subnet", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Subnet resources.
 */
export interface SubnetState {
    /**
     * Specify true to indicate
     * that network interfaces created in the specified subnet should be
     * assigned an IPv6 address. Default is `false`
     */
    readonly assignIpv6AddressOnCreation?: pulumi.Input<boolean>;
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * The CIDR block for the subnet.
     */
    readonly cidrBlock?: pulumi.Input<string>;
    /**
     * The IPv6 network range for the subnet,
     * in CIDR notation. The subnet size must use a /64 prefix length.
     */
    readonly ipv6CidrBlock?: pulumi.Input<string>;
    readonly ipv6CidrBlockAssociationId?: pulumi.Input<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address. Default is `false`.
     */
    readonly mapPublicIpOnLaunch?: pulumi.Input<boolean>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID.
     */
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Subnet resource.
 */
export interface SubnetArgs {
    /**
     * Specify true to indicate
     * that network interfaces created in the specified subnet should be
     * assigned an IPv6 address. Default is `false`
     */
    readonly assignIpv6AddressOnCreation?: pulumi.Input<boolean>;
    readonly availabilityZone?: pulumi.Input<string>;
    /**
     * The CIDR block for the subnet.
     */
    readonly cidrBlock: pulumi.Input<string>;
    /**
     * The IPv6 network range for the subnet,
     * in CIDR notation. The subnet size must use a /64 prefix length.
     */
    readonly ipv6CidrBlock?: pulumi.Input<string>;
    /**
     * Specify true to indicate
     * that instances launched into the subnet should be assigned
     * a public IP address. Default is `false`.
     */
    readonly mapPublicIpOnLaunch?: pulumi.Input<boolean>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * The VPC ID.
     */
    readonly vpcId: pulumi.Input<string>;
}
