// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * `aws_availability_zone` provides details about a specific availability zone (AZ)
 * in the current region.
 * 
 * This can be used both to validate an availability zone given in a variable
 * and to split the AZ name into its component parts of an AWS region and an
 * AZ identifier letter. The latter may be useful e.g. for implementing a
 * consistent subnet numbering scheme across several regions by mapping both
 * the region and the subnet letter to network numbers.
 * 
 * This is different from the `aws_availability_zones` (plural) data source,
 * which provides a list of the available zones.
 */
export function getAvailabilityZone(args?: GetAvailabilityZoneArgs): Promise<GetAvailabilityZoneResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:index/getAvailabilityZone:getAvailabilityZone", {
        "name": args.name,
        "state": args.state,
    });
}

/**
 * A collection of arguments for invoking getAvailabilityZone.
 */
export interface GetAvailabilityZoneArgs {
    /**
     * The full name of the availability zone to select.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A specific availability zone state to require. May
     * be any of `"available"`, `"information"` or `"impaired"`.
     */
    readonly state?: pulumi.Input<string>;
}

/**
 * A collection of values returned by getAvailabilityZone.
 */
export interface GetAvailabilityZoneResult {
    /**
     * The name of the selected availability zone.
     */
    readonly name: string;
    /**
     * The part of the AZ name that appears after the region name,
     * uniquely identifying the AZ within its region.
     */
    readonly nameSuffix: string;
    /**
     * The region where the selected availability zone resides.
     * This is always the region selected on the provider, since this data source
     * searches only within that region.
     */
    readonly region: string;
    /**
     * The current state of the AZ.
     */
    readonly state: string;
}
