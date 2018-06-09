// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * The VPC Endpoint data source provides details about
 * a specific VPC endpoint.
 */
export function getVpcEndpoint(args?: GetVpcEndpointArgs): Promise<GetVpcEndpointResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:ec2/getVpcEndpoint:getVpcEndpoint", {
        "id": args.id,
        "serviceName": args.serviceName,
        "state": args.state,
        "vpcId": args.vpcId,
    });
}

/**
 * A collection of arguments for invoking getVpcEndpoint.
 */
export interface GetVpcEndpointArgs {
    /**
     * The ID of the specific VPC Endpoint to retrieve.
     */
    readonly id?: pulumi.Input<string>;
    /**
     * The AWS service name of the specific VPC Endpoint to retrieve.
     */
    readonly serviceName?: pulumi.Input<string>;
    /**
     * The state of the specific VPC Endpoint to retrieve.
     */
    readonly state?: pulumi.Input<string>;
    /**
     * The ID of the VPC in which the specific VPC Endpoint is used.
     */
    readonly vpcId?: pulumi.Input<string>;
}

/**
 * A collection of values returned by getVpcEndpoint.
 */
export interface GetVpcEndpointResult {
    /**
     * The list of CIDR blocks for the exposed AWS service. Applicable for endpoints of type `Gateway`.
     */
    readonly cidrBlocks: string[];
    /**
     * The DNS entries for the VPC Endpoint. Applicable for endpoints of type `Interface`. DNS blocks are documented below.
     */
    readonly dnsEntries: { dnsName: string, hostedZoneId: string }[];
    readonly id: string;
    /**
     * One or more network interfaces for the VPC Endpoint. Applicable for endpoints of type `Interface`.
     */
    readonly networkInterfaceIds: string[];
    /**
     * The policy document associated with the VPC Endpoint. Applicable for endpoints of type `Gateway`.
     */
    readonly policy: string;
    /**
     * The prefix list ID of the exposed AWS service. Applicable for endpoints of type `Gateway`.
     */
    readonly prefixListId: string;
    /**
     * Whether or not the VPC is associated with a private hosted zone - `true` or `false`. Applicable for endpoints of type `Interface`.
     */
    readonly privateDnsEnabled: boolean;
    /**
     * One or more route tables associated with the VPC Endpoint. Applicable for endpoints of type `Gateway`.
     */
    readonly routeTableIds: string[];
    /**
     * One or more security groups associated with the network interfaces. Applicable for endpoints of type `Interface`.
     */
    readonly securityGroupIds: string[];
    readonly serviceName: string;
    readonly state: string;
    /**
     * One or more subnets in which the VPC Endpoint is located. Applicable for endpoints of type `Interface`.
     */
    readonly subnetIds: string[];
    /**
     * The VPC Endpoint type, `Gateway` or `Interface`.
     */
    readonly vpcEndpointType: string;
    readonly vpcId: string;
}
