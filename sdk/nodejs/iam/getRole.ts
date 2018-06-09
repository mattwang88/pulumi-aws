// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * This data source can be used to fetch information about a specific
 * IAM role. By using this data source, you can reference IAM role
 * properties without having to hard code ARNs as input.
 */
export function getRole(args?: GetRoleArgs): Promise<GetRoleResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:iam/getRole:getRole", {
        "name": args.name,
        "roleName": args.roleName,
    });
}

/**
 * A collection of arguments for invoking getRole.
 */
export interface GetRoleArgs {
    /**
     * The friendly IAM role name to match.
     */
    readonly name?: pulumi.Input<string>;
    readonly roleName?: pulumi.Input<string>;
}

/**
 * A collection of values returned by getRole.
 */
export interface GetRoleResult {
    /**
     * The Amazon Resource Name (ARN) specifying the role.
     */
    readonly arn: string;
    /**
     * The policy document associated with the role.
     */
    readonly assumeRolePolicy: string;
    readonly assumeRolePolicyDocument: string;
    readonly createDate: string;
    readonly description: string;
    readonly maxSessionDuration: number;
    /**
     * The path to the role.
     */
    readonly path: string;
    readonly roleId: string;
    /**
     * The stable and unique string identifying the role.
     */
    readonly uniqueId: string;
}
