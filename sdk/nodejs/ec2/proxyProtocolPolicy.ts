// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides a proxy protocol policy, which allows an ELB to carry a client connection information to a backend.
 */
export class ProxyProtocolPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ProxyProtocolPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProxyProtocolPolicyState): ProxyProtocolPolicy {
        return new ProxyProtocolPolicy(name, <any>state, { id });
    }

    /**
     * List of instance ports to which the policy
     * should be applied. This can be specified if the protocol is SSL or TCP.
     */
    public readonly instancePorts: pulumi.Output<string[]>;
    /**
     * The load balancer to which the policy
     * should be attached.
     */
    public readonly loadBalancer: pulumi.Output<string>;

    /**
     * Create a ProxyProtocolPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProxyProtocolPolicyArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: ProxyProtocolPolicyArgs | ProxyProtocolPolicyState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ProxyProtocolPolicyState = argsOrState as ProxyProtocolPolicyState | undefined;
            inputs["instancePorts"] = state ? state.instancePorts : undefined;
            inputs["loadBalancer"] = state ? state.loadBalancer : undefined;
        } else {
            const args = argsOrState as ProxyProtocolPolicyArgs | undefined;
            if (!args || args.instancePorts === undefined) {
                throw new Error("Missing required property 'instancePorts'");
            }
            if (!args || args.loadBalancer === undefined) {
                throw new Error("Missing required property 'loadBalancer'");
            }
            inputs["instancePorts"] = args ? args.instancePorts : undefined;
            inputs["loadBalancer"] = args ? args.loadBalancer : undefined;
        }
        super("aws:ec2/proxyProtocolPolicy:ProxyProtocolPolicy", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProxyProtocolPolicy resources.
 */
export interface ProxyProtocolPolicyState {
    /**
     * List of instance ports to which the policy
     * should be applied. This can be specified if the protocol is SSL or TCP.
     */
    readonly instancePorts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The load balancer to which the policy
     * should be attached.
     */
    readonly loadBalancer?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProxyProtocolPolicy resource.
 */
export interface ProxyProtocolPolicyArgs {
    /**
     * List of instance ports to which the policy
     * should be applied. This can be specified if the protocol is SSL or TCP.
     */
    readonly instancePorts: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The load balancer to which the policy
     * should be attached.
     */
    readonly loadBalancer: pulumi.Input<string>;
}
