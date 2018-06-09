// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to get information about an AWS Cloudwatch Log Group
 */
export function getLogGroup(args: GetLogGroupArgs): Promise<GetLogGroupResult> {
    return pulumi.runtime.invoke("aws:cloudwatch/getLogGroup:getLogGroup", {
        "name": args.name,
    });
}

/**
 * A collection of arguments for invoking getLogGroup.
 */
export interface GetLogGroupArgs {
    /**
     * The name of the Cloudwatch log group
     */
    readonly name: pulumi.Input<string>;
}

/**
 * A collection of values returned by getLogGroup.
 */
export interface GetLogGroupResult {
    /**
     * The ARN of the Cloudwatch log group
     */
    readonly arn: string;
    /**
     * The creation time of the log group, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.
     */
    readonly creationTime: number;
}
