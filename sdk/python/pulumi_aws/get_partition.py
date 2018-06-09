# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetPartitionResult(object):
    """
    A collection of values returned by getPartition.
    """
    def __init__(__self__, partition=None):
        if not partition:
            raise TypeError('Missing required argument partition')
        elif not isinstance(partition, basestring):
            raise TypeError('Expected argument partition to be a basestring')
        __self__.partition = partition

def get_partition():
    """
    Use this data source to lookup current AWS partition in which Terraform is working
    """
    __args__ = dict()

    __ret__ = pulumi.runtime.invoke('aws:index/getPartition:getPartition', __args__)

    return GetPartitionResult(
        partition=__ret__['partition'])
