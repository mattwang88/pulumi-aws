// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides an RDS DB cluster parameter group resource.
 */
export class ClusterParameterGroup extends pulumi.CustomResource {
    /**
     * Get an existing ClusterParameterGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClusterParameterGroupState): ClusterParameterGroup {
        return new ClusterParameterGroup(name, <any>state, { id });
    }

    /**
     * The ARN of the db cluster parameter group.
     */
    public /*out*/ readonly arn: pulumi.Output<string>;
    /**
     * The description of the DB cluster parameter group. Defaults to "Managed by Terraform".
     */
    public readonly description: pulumi.Output<string>;
    /**
     * The family of the DB cluster parameter group.
     */
    public readonly family: pulumi.Output<string>;
    /**
     * The name of the DB parameter.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    public readonly namePrefix: pulumi.Output<string>;
    /**
     * A list of DB parameters to apply. Note that parameters may differ from a family to an other. Full list of all parameters can be discovered via [`aws rds describe-db-cluster-parameters`](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-cluster-parameters.html) after initial creation of the group.
     */
    public readonly parameters: pulumi.Output<{ applyMethod?: string, name: string, value: string }[] | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a ClusterParameterGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterParameterGroupArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: ClusterParameterGroupArgs | ClusterParameterGroupState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ClusterParameterGroupState = argsOrState as ClusterParameterGroupState | undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["family"] = state ? state.family : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namePrefix"] = state ? state.namePrefix : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ClusterParameterGroupArgs | undefined;
            if (!args || args.family === undefined) {
                throw new Error("Missing required property 'family'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["family"] = args ? args.family : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namePrefix"] = args ? args.namePrefix : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        super("aws:rds/clusterParameterGroup:ClusterParameterGroup", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ClusterParameterGroup resources.
 */
export interface ClusterParameterGroupState {
    /**
     * The ARN of the db cluster parameter group.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The description of the DB cluster parameter group. Defaults to "Managed by Terraform".
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The family of the DB cluster parameter group.
     */
    readonly family?: pulumi.Input<string>;
    /**
     * The name of the DB parameter.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * A list of DB parameters to apply. Note that parameters may differ from a family to an other. Full list of all parameters can be discovered via [`aws rds describe-db-cluster-parameters`](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-cluster-parameters.html) after initial creation of the group.
     */
    readonly parameters?: pulumi.Input<{ applyMethod?: pulumi.Input<string>, name: pulumi.Input<string>, value: pulumi.Input<string> }[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a ClusterParameterGroup resource.
 */
export interface ClusterParameterGroupArgs {
    /**
     * The description of the DB cluster parameter group. Defaults to "Managed by Terraform".
     */
    readonly description?: pulumi.Input<string>;
    /**
     * The family of the DB cluster parameter group.
     */
    readonly family: pulumi.Input<string>;
    /**
     * The name of the DB parameter.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Creates a unique name beginning with the specified prefix. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * A list of DB parameters to apply. Note that parameters may differ from a family to an other. Full list of all parameters can be discovered via [`aws rds describe-db-cluster-parameters`](https://docs.aws.amazon.com/cli/latest/reference/rds/describe-db-cluster-parameters.html) after initial creation of the group.
     */
    readonly parameters?: pulumi.Input<{ applyMethod?: pulumi.Input<string>, name: pulumi.Input<string>, value: pulumi.Input<string> }[]>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
