// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Use this data source to get information about an Elasticache Replication Group.
 */
export function getReplicationGroup(args: GetReplicationGroupArgs): Promise<GetReplicationGroupResult> {
    return pulumi.runtime.invoke("aws:elasticache/getReplicationGroup:getReplicationGroup", {
        "replicationGroupId": args.replicationGroupId,
    });
}

/**
 * A collection of arguments for invoking getReplicationGroup.
 */
export interface GetReplicationGroupArgs {
    /**
     * The identifier for the replication group.
     */
    readonly replicationGroupId: pulumi.Input<string>;
}

/**
 * A collection of values returned by getReplicationGroup.
 */
export interface GetReplicationGroupResult {
    /**
     * A flag that enables using an AuthToken (password) when issuing Redis commands.
     */
    readonly authTokenEnabled: boolean;
    /**
     * A flag whether a read-only replica will be automatically promoted to read/write primary if the existing primary fails.
     */
    readonly automaticFailoverEnabled: boolean;
    /**
     * The configuration endpoint address to allow host discovery.
     */
    readonly configurationEndpointAddress: string;
    /**
     * The cluster node type.
     */
    readonly nodeType: string;
    /**
     * The number of cache clusters that the replication group has.
     */
    readonly numberCacheClusters: number;
    /**
     * The port number on which the configuration endpoint will accept connections.
     */
    readonly port: number;
    /**
     * The endpoint of the primary node in this node group (shard).
     */
    readonly primaryEndpointAddress: string;
    /**
     * The description of the replication group.
     */
    readonly replicationGroupDescription: string;
    /**
     * The number of days for which ElastiCache retains automatic cache cluster snapshots before deleting them.
     */
    readonly snapshotRetentionLimit: number;
    /**
     * The daily time range (in UTC) during which ElastiCache begins taking a daily snapshot of your node group (shard).
     */
    readonly snapshotWindow: string;
}
