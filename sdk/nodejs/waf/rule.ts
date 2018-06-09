// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides a WAF Rule Resource
 */
export class Rule extends pulumi.CustomResource {
    /**
     * Get an existing Rule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RuleState): Rule {
        return new Rule(name, <any>state, { id });
    }

    /**
     * The name or description for the Amazon CloudWatch metric of this rule.
     */
    public readonly metricName: pulumi.Output<string>;
    /**
     * The name or description of the rule.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * One of ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects to include in a rule.
     */
    public readonly predicates: pulumi.Output<{ dataId: string, negated: boolean, type: string }[] | undefined>;

    /**
     * Create a Rule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RuleArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: RuleArgs | RuleState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: RuleState = argsOrState as RuleState | undefined;
            inputs["metricName"] = state ? state.metricName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["predicates"] = state ? state.predicates : undefined;
        } else {
            const args = argsOrState as RuleArgs | undefined;
            if (!args || args.metricName === undefined) {
                throw new Error("Missing required property 'metricName'");
            }
            inputs["metricName"] = args ? args.metricName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["predicates"] = args ? args.predicates : undefined;
        }
        super("aws:waf/rule:Rule", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Rule resources.
 */
export interface RuleState {
    /**
     * The name or description for the Amazon CloudWatch metric of this rule.
     */
    readonly metricName?: pulumi.Input<string>;
    /**
     * The name or description of the rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * One of ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects to include in a rule.
     */
    readonly predicates?: pulumi.Input<{ dataId: pulumi.Input<string>, negated: pulumi.Input<boolean>, type: pulumi.Input<string> }[]>;
}

/**
 * The set of arguments for constructing a Rule resource.
 */
export interface RuleArgs {
    /**
     * The name or description for the Amazon CloudWatch metric of this rule.
     */
    readonly metricName: pulumi.Input<string>;
    /**
     * The name or description of the rule.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * One of ByteMatchSet, IPSet, SizeConstraintSet, SqlInjectionMatchSet, or XssMatchSet objects to include in a rule.
     */
    readonly predicates?: pulumi.Input<{ dataId: pulumi.Input<string>, negated: pulumi.Input<boolean>, type: pulumi.Input<string> }[]>;
}
