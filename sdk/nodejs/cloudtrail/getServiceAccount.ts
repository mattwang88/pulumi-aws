// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to get the Account ID of the [AWS CloudTrail Service Account](http://docs.aws.amazon.com/awscloudtrail/latest/userguide/cloudtrail-supported-regions.html)
 * in a given region for the purpose of allowing CloudTrail to store trail data in S3.
 */
export function getServiceAccount(args?: GetServiceAccountArgs): Promise<GetServiceAccountResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:cloudtrail/getServiceAccount:getServiceAccount", {
        "region": args.region,
    });
}

/**
 * A collection of arguments for invoking getServiceAccount.
 */
export interface GetServiceAccountArgs {
    /**
     * Name of the region whose AWS CloudTrail account ID is desired.
     * Defaults to the region from the AWS provider configuration.
     */
    readonly region?: pulumi.Input<string>;
}

/**
 * A collection of values returned by getServiceAccount.
 */
export interface GetServiceAccountResult {
    /**
     * The ARN of the AWS CloudTrail service account in the selected region.
     */
    readonly arn: string;
}
