// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

import {ARN} from "../index";

/**
 * Provides an SNS topic resource
 */
export class Topic extends pulumi.CustomResource {
    /**
     * Get an existing Topic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TopicState): Topic {
        return new Topic(name, <any>state, { id });
    }

    /**
     * IAM role for failure feedback
     */
    public readonly applicationFailureFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    public readonly applicationSuccessFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * Percentage of success to sample
     */
    public readonly applicationSuccessFeedbackSampleRate: pulumi.Output<number | undefined>;
    /**
     * The ARN of the SNS topic, as a more obvious property (clone of id)
     */
    public /*out*/ readonly arn: pulumi.Output<ARN>;
    /**
     * The SNS delivery policy
     */
    public readonly deliveryPolicy: pulumi.Output<string | undefined>;
    /**
     * The display name for the SNS topic
     */
    public readonly displayName: pulumi.Output<string | undefined>;
    /**
     * IAM role for failure feedback
     */
    public readonly httpFailureFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    public readonly httpSuccessFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * Percentage of success to sample
     */
    public readonly httpSuccessFeedbackSampleRate: pulumi.Output<number | undefined>;
    /**
     * IAM role for failure feedback
     */
    public readonly lambdaFailureFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    public readonly lambdaSuccessFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * Percentage of success to sample
     */
    public readonly lambdaSuccessFeedbackSampleRate: pulumi.Output<number | undefined>;
    /**
     * The friendly name for the SNS topic. By default generated by Terraform.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The friendly name for the SNS topic. Conflicts with `name`.
     */
    public readonly namePrefix: pulumi.Output<string | undefined>;
    /**
     * The fully-formed AWS policy as JSON
     */
    public readonly policy: pulumi.Output<string>;
    /**
     * IAM role for failure feedback
     */
    public readonly sqsFailureFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    public readonly sqsSuccessFeedbackRoleArn: pulumi.Output<string | undefined>;
    /**
     * Percentage of success to sample
     */
    public readonly sqsSuccessFeedbackSampleRate: pulumi.Output<number | undefined>;

    /**
     * Create a Topic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: TopicArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: TopicArgs | TopicState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: TopicState = argsOrState as TopicState | undefined;
            inputs["applicationFailureFeedbackRoleArn"] = state ? state.applicationFailureFeedbackRoleArn : undefined;
            inputs["applicationSuccessFeedbackRoleArn"] = state ? state.applicationSuccessFeedbackRoleArn : undefined;
            inputs["applicationSuccessFeedbackSampleRate"] = state ? state.applicationSuccessFeedbackSampleRate : undefined;
            inputs["arn"] = state ? state.arn : undefined;
            inputs["deliveryPolicy"] = state ? state.deliveryPolicy : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["httpFailureFeedbackRoleArn"] = state ? state.httpFailureFeedbackRoleArn : undefined;
            inputs["httpSuccessFeedbackRoleArn"] = state ? state.httpSuccessFeedbackRoleArn : undefined;
            inputs["httpSuccessFeedbackSampleRate"] = state ? state.httpSuccessFeedbackSampleRate : undefined;
            inputs["lambdaFailureFeedbackRoleArn"] = state ? state.lambdaFailureFeedbackRoleArn : undefined;
            inputs["lambdaSuccessFeedbackRoleArn"] = state ? state.lambdaSuccessFeedbackRoleArn : undefined;
            inputs["lambdaSuccessFeedbackSampleRate"] = state ? state.lambdaSuccessFeedbackSampleRate : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namePrefix"] = state ? state.namePrefix : undefined;
            inputs["policy"] = state ? state.policy : undefined;
            inputs["sqsFailureFeedbackRoleArn"] = state ? state.sqsFailureFeedbackRoleArn : undefined;
            inputs["sqsSuccessFeedbackRoleArn"] = state ? state.sqsSuccessFeedbackRoleArn : undefined;
            inputs["sqsSuccessFeedbackSampleRate"] = state ? state.sqsSuccessFeedbackSampleRate : undefined;
        } else {
            const args = argsOrState as TopicArgs | undefined;
            inputs["applicationFailureFeedbackRoleArn"] = args ? args.applicationFailureFeedbackRoleArn : undefined;
            inputs["applicationSuccessFeedbackRoleArn"] = args ? args.applicationSuccessFeedbackRoleArn : undefined;
            inputs["applicationSuccessFeedbackSampleRate"] = args ? args.applicationSuccessFeedbackSampleRate : undefined;
            inputs["deliveryPolicy"] = args ? args.deliveryPolicy : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["httpFailureFeedbackRoleArn"] = args ? args.httpFailureFeedbackRoleArn : undefined;
            inputs["httpSuccessFeedbackRoleArn"] = args ? args.httpSuccessFeedbackRoleArn : undefined;
            inputs["httpSuccessFeedbackSampleRate"] = args ? args.httpSuccessFeedbackSampleRate : undefined;
            inputs["lambdaFailureFeedbackRoleArn"] = args ? args.lambdaFailureFeedbackRoleArn : undefined;
            inputs["lambdaSuccessFeedbackRoleArn"] = args ? args.lambdaSuccessFeedbackRoleArn : undefined;
            inputs["lambdaSuccessFeedbackSampleRate"] = args ? args.lambdaSuccessFeedbackSampleRate : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namePrefix"] = args ? args.namePrefix : undefined;
            inputs["policy"] = args ? args.policy : undefined;
            inputs["sqsFailureFeedbackRoleArn"] = args ? args.sqsFailureFeedbackRoleArn : undefined;
            inputs["sqsSuccessFeedbackRoleArn"] = args ? args.sqsSuccessFeedbackRoleArn : undefined;
            inputs["sqsSuccessFeedbackSampleRate"] = args ? args.sqsSuccessFeedbackSampleRate : undefined;
            inputs["arn"] = undefined /*out*/;
        }
        super("aws:sns/topic:Topic", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Topic resources.
 */
export interface TopicState {
    /**
     * IAM role for failure feedback
     */
    readonly applicationFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly applicationSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly applicationSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * The ARN of the SNS topic, as a more obvious property (clone of id)
     */
    readonly arn?: pulumi.Input<ARN>;
    /**
     * The SNS delivery policy
     */
    readonly deliveryPolicy?: pulumi.Input<string>;
    /**
     * The display name for the SNS topic
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * IAM role for failure feedback
     */
    readonly httpFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly httpSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly httpSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * IAM role for failure feedback
     */
    readonly lambdaFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly lambdaSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly lambdaSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * The friendly name for the SNS topic. By default generated by Terraform.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The friendly name for the SNS topic. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * The fully-formed AWS policy as JSON
     */
    readonly policy?: pulumi.Input<string>;
    /**
     * IAM role for failure feedback
     */
    readonly sqsFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly sqsSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly sqsSuccessFeedbackSampleRate?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Topic resource.
 */
export interface TopicArgs {
    /**
     * IAM role for failure feedback
     */
    readonly applicationFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly applicationSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly applicationSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * The SNS delivery policy
     */
    readonly deliveryPolicy?: pulumi.Input<string>;
    /**
     * The display name for the SNS topic
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * IAM role for failure feedback
     */
    readonly httpFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly httpSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly httpSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * IAM role for failure feedback
     */
    readonly lambdaFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly lambdaSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly lambdaSuccessFeedbackSampleRate?: pulumi.Input<number>;
    /**
     * The friendly name for the SNS topic. By default generated by Terraform.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The friendly name for the SNS topic. Conflicts with `name`.
     */
    readonly namePrefix?: pulumi.Input<string>;
    /**
     * The fully-formed AWS policy as JSON
     */
    readonly policy?: pulumi.Input<string>;
    /**
     * IAM role for failure feedback
     */
    readonly sqsFailureFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * The IAM role permitted to receive success feedback for this topic
     */
    readonly sqsSuccessFeedbackRoleArn?: pulumi.Input<string>;
    /**
     * Percentage of success to sample
     */
    readonly sqsSuccessFeedbackSampleRate?: pulumi.Input<number>;
}
