// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides a WAF Regional Rule Group Resource
 */
export class RuleGroup extends pulumi.CustomResource {
    /**
     * Get an existing RuleGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RuleGroupState): RuleGroup {
        return new RuleGroup(name, <any>state, { id });
    }

    /**
     * A list of activated rules, see below
     */
    public readonly activatedRules: pulumi.Output<{ action: { type: string }, priority: number, ruleId: string, type?: string }[] | undefined>;
    /**
     * A friendly name for the metrics from the rule group
     */
    public readonly metricName: pulumi.Output<string>;
    /**
     * A friendly name of the rule group
     */
    public readonly name: pulumi.Output<string>;

    /**
     * Create a RuleGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RuleGroupArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: RuleGroupArgs | RuleGroupState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: RuleGroupState = argsOrState as RuleGroupState | undefined;
            inputs["activatedRules"] = state ? state.activatedRules : undefined;
            inputs["metricName"] = state ? state.metricName : undefined;
            inputs["name"] = state ? state.name : undefined;
        } else {
            const args = argsOrState as RuleGroupArgs | undefined;
            if (!args || args.metricName === undefined) {
                throw new Error("Missing required property 'metricName'");
            }
            inputs["activatedRules"] = args ? args.activatedRules : undefined;
            inputs["metricName"] = args ? args.metricName : undefined;
            inputs["name"] = args ? args.name : undefined;
        }
        super("aws:wafregional/ruleGroup:RuleGroup", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RuleGroup resources.
 */
export interface RuleGroupState {
    /**
     * A list of activated rules, see below
     */
    readonly activatedRules?: pulumi.Input<{ action: pulumi.Input<{ type: pulumi.Input<string> }>, priority: pulumi.Input<number>, ruleId: pulumi.Input<string>, type?: pulumi.Input<string> }[]>;
    /**
     * A friendly name for the metrics from the rule group
     */
    readonly metricName?: pulumi.Input<string>;
    /**
     * A friendly name of the rule group
     */
    readonly name?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RuleGroup resource.
 */
export interface RuleGroupArgs {
    /**
     * A list of activated rules, see below
     */
    readonly activatedRules?: pulumi.Input<{ action: pulumi.Input<{ type: pulumi.Input<string> }>, priority: pulumi.Input<number>, ruleId: pulumi.Input<string>, type?: pulumi.Input<string> }[]>;
    /**
     * A friendly name for the metrics from the rule group
     */
    readonly metricName: pulumi.Input<string>;
    /**
     * A friendly name of the rule group
     */
    readonly name?: pulumi.Input<string>;
}
