// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * The IAM Account Alias data source allows access to the account alias
 * for the effective account in which Terraform is working.
 */
export function getAccountAlias(): Promise<GetAccountAliasResult> {
    return pulumi.runtime.invoke("aws:iam/getAccountAlias:getAccountAlias", {
    });
}

/**
 * A collection of values returned by getAccountAlias.
 */
export interface GetAccountAliasResult {
    /**
     * The alias associated with the AWS account.
     */
    readonly accountAlias: string;
}
