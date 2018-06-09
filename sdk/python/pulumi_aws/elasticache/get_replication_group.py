# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetReplicationGroupResult(object):
    """
    A collection of values returned by getReplicationGroup.
    """
    def __init__(__self__, auth_token_enabled=None, automatic_failover_enabled=None, configuration_endpoint_address=None, node_type=None, number_cache_clusters=None, port=None, primary_endpoint_address=None, replication_group_description=None, snapshot_retention_limit=None, snapshot_window=None):
        if not auth_token_enabled:
            raise TypeError('Missing required argument auth_token_enabled')
        elif not isinstance(auth_token_enabled, bool):
            raise TypeError('Expected argument auth_token_enabled to be a bool')
        __self__.auth_token_enabled = auth_token_enabled
        """
        A flag that enables using an AuthToken (password) when issuing Redis commands.
        """
        if not automatic_failover_enabled:
            raise TypeError('Missing required argument automatic_failover_enabled')
        elif not isinstance(automatic_failover_enabled, bool):
            raise TypeError('Expected argument automatic_failover_enabled to be a bool')
        __self__.automatic_failover_enabled = automatic_failover_enabled
        """
        A flag whether a read-only replica will be automatically promoted to read/write primary if the existing primary fails.
        """
        if not configuration_endpoint_address:
            raise TypeError('Missing required argument configuration_endpoint_address')
        elif not isinstance(configuration_endpoint_address, basestring):
            raise TypeError('Expected argument configuration_endpoint_address to be a basestring')
        __self__.configuration_endpoint_address = configuration_endpoint_address
        """
        The configuration endpoint address to allow host discovery.
        """
        if not node_type:
            raise TypeError('Missing required argument node_type')
        elif not isinstance(node_type, basestring):
            raise TypeError('Expected argument node_type to be a basestring')
        __self__.node_type = node_type
        """
        The cluster node type.
        """
        if not number_cache_clusters:
            raise TypeError('Missing required argument number_cache_clusters')
        elif not isinstance(number_cache_clusters, int):
            raise TypeError('Expected argument number_cache_clusters to be a int')
        __self__.number_cache_clusters = number_cache_clusters
        """
        The number of cache clusters that the replication group has.
        """
        if not port:
            raise TypeError('Missing required argument port')
        elif not isinstance(port, int):
            raise TypeError('Expected argument port to be a int')
        __self__.port = port
        """
        The port number on which the configuration endpoint will accept connections.
        """
        if not primary_endpoint_address:
            raise TypeError('Missing required argument primary_endpoint_address')
        elif not isinstance(primary_endpoint_address, basestring):
            raise TypeError('Expected argument primary_endpoint_address to be a basestring')
        __self__.primary_endpoint_address = primary_endpoint_address
        """
        The endpoint of the primary node in this node group (shard).
        """
        if not replication_group_description:
            raise TypeError('Missing required argument replication_group_description')
        elif not isinstance(replication_group_description, basestring):
            raise TypeError('Expected argument replication_group_description to be a basestring')
        __self__.replication_group_description = replication_group_description
        """
        The description of the replication group.
        """
        if not snapshot_retention_limit:
            raise TypeError('Missing required argument snapshot_retention_limit')
        elif not isinstance(snapshot_retention_limit, int):
            raise TypeError('Expected argument snapshot_retention_limit to be a int')
        __self__.snapshot_retention_limit = snapshot_retention_limit
        """
        The number of days for which ElastiCache retains automatic cache cluster snapshots before deleting them.
        """
        if not snapshot_window:
            raise TypeError('Missing required argument snapshot_window')
        elif not isinstance(snapshot_window, basestring):
            raise TypeError('Expected argument snapshot_window to be a basestring')
        __self__.snapshot_window = snapshot_window
        """
        The daily time range (in UTC) during which ElastiCache begins taking a daily snapshot of your node group (shard).
        """

def get_replication_group(replication_group_id=None):
    """
    Use this data source to get information about an Elasticache Replication Group.
    """
    __args__ = dict()

    __args__['replicationGroupId'] = replication_group_id
    __ret__ = pulumi.runtime.invoke('aws:elasticache/getReplicationGroup:getReplicationGroup', __args__)

    return GetReplicationGroupResult(
        auth_token_enabled=__ret__['authTokenEnabled'],
        automatic_failover_enabled=__ret__['automaticFailoverEnabled'],
        configuration_endpoint_address=__ret__['configurationEndpointAddress'],
        node_type=__ret__['nodeType'],
        number_cache_clusters=__ret__['numberCacheClusters'],
        port=__ret__['port'],
        primary_endpoint_address=__ret__['primaryEndpointAddress'],
        replication_group_description=__ret__['replicationGroupDescription'],
        snapshot_retention_limit=__ret__['snapshotRetentionLimit'],
        snapshot_window=__ret__['snapshotWindow'])
