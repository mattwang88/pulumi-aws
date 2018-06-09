// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides a resource-based access control mechanism for a KMS customer master key.
 */
export class Grant extends pulumi.CustomResource {
    /**
     * Get an existing Grant resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GrantState): Grant {
        return new Grant(name, <any>state, { id });
    }

    /**
     * A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
     */
    public readonly constraints: pulumi.Output<{ encryptionContextEquals?: {[key: string]: string}, encryptionContextSubset?: {[key: string]: string} }[] | undefined>;
    /**
     * A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
     * * `retire_on_delete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
     * See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
     */
    public readonly grantCreationTokens: pulumi.Output<string[] | undefined>;
    /**
     * The unique identifier for the grant.
     */
    public /*out*/ readonly grantId: pulumi.Output<string>;
    /**
     * The grant token for the created grant. For more information, see [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token).
     */
    public /*out*/ readonly grantToken: pulumi.Output<string>;
    /**
     * The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, terraform's state may not always be refreshed to reflect what is true in AWS.
     */
    public readonly granteePrincipal: pulumi.Output<string>;
    /**
     * The unique identifier for the customer master key (CMK) that the grant applies to.
     */
    public readonly keyId: pulumi.Output<string>;
    /**
     * A friendly name for identifying the grant.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
     */
    public readonly operations: pulumi.Output<string[]>;
    public readonly retireOnDelete: pulumi.Output<boolean | undefined>;
    public readonly retiringPrincipal: pulumi.Output<string | undefined>;

    /**
     * Create a Grant resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GrantArgs, opts?: pulumi.ResourceOptions)
    constructor(name: string, argsOrState?: GrantArgs | GrantState, opts?: pulumi.ResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: GrantState = argsOrState as GrantState | undefined;
            inputs["constraints"] = state ? state.constraints : undefined;
            inputs["grantCreationTokens"] = state ? state.grantCreationTokens : undefined;
            inputs["grantId"] = state ? state.grantId : undefined;
            inputs["grantToken"] = state ? state.grantToken : undefined;
            inputs["granteePrincipal"] = state ? state.granteePrincipal : undefined;
            inputs["keyId"] = state ? state.keyId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["operations"] = state ? state.operations : undefined;
            inputs["retireOnDelete"] = state ? state.retireOnDelete : undefined;
            inputs["retiringPrincipal"] = state ? state.retiringPrincipal : undefined;
        } else {
            const args = argsOrState as GrantArgs | undefined;
            if (!args || args.granteePrincipal === undefined) {
                throw new Error("Missing required property 'granteePrincipal'");
            }
            if (!args || args.keyId === undefined) {
                throw new Error("Missing required property 'keyId'");
            }
            if (!args || args.operations === undefined) {
                throw new Error("Missing required property 'operations'");
            }
            inputs["constraints"] = args ? args.constraints : undefined;
            inputs["grantCreationTokens"] = args ? args.grantCreationTokens : undefined;
            inputs["granteePrincipal"] = args ? args.granteePrincipal : undefined;
            inputs["keyId"] = args ? args.keyId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["operations"] = args ? args.operations : undefined;
            inputs["retireOnDelete"] = args ? args.retireOnDelete : undefined;
            inputs["retiringPrincipal"] = args ? args.retiringPrincipal : undefined;
            inputs["grantId"] = undefined /*out*/;
            inputs["grantToken"] = undefined /*out*/;
        }
        super("aws:kms/grant:Grant", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Grant resources.
 */
export interface GrantState {
    /**
     * A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
     */
    readonly constraints?: pulumi.Input<{ encryptionContextEquals?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, encryptionContextSubset?: pulumi.Input<{[key: string]: pulumi.Input<string>}> }[]>;
    /**
     * A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
     * * `retire_on_delete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
     * See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
     */
    readonly grantCreationTokens?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The unique identifier for the grant.
     */
    readonly grantId?: pulumi.Input<string>;
    /**
     * The grant token for the created grant. For more information, see [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token).
     */
    readonly grantToken?: pulumi.Input<string>;
    /**
     * The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, terraform's state may not always be refreshed to reflect what is true in AWS.
     */
    readonly granteePrincipal?: pulumi.Input<string>;
    /**
     * The unique identifier for the customer master key (CMK) that the grant applies to.
     */
    readonly keyId?: pulumi.Input<string>;
    /**
     * A friendly name for identifying the grant.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
     */
    readonly operations?: pulumi.Input<pulumi.Input<string>[]>;
    readonly retireOnDelete?: pulumi.Input<boolean>;
    readonly retiringPrincipal?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Grant resource.
 */
export interface GrantArgs {
    /**
     * A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
     */
    readonly constraints?: pulumi.Input<{ encryptionContextEquals?: pulumi.Input<{[key: string]: pulumi.Input<string>}>, encryptionContextSubset?: pulumi.Input<{[key: string]: pulumi.Input<string>}> }[]>;
    /**
     * A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
     * * `retire_on_delete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
     * See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
     */
    readonly grantCreationTokens?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, terraform's state may not always be refreshed to reflect what is true in AWS.
     */
    readonly granteePrincipal: pulumi.Input<string>;
    /**
     * The unique identifier for the customer master key (CMK) that the grant applies to.
     */
    readonly keyId: pulumi.Input<string>;
    /**
     * A friendly name for identifying the grant.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
     */
    readonly operations: pulumi.Input<pulumi.Input<string>[]>;
    readonly retireOnDelete?: pulumi.Input<boolean>;
    readonly retiringPrincipal?: pulumi.Input<string>;
}
