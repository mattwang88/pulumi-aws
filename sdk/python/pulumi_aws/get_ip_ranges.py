# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetIpRangesResult(object):
    """
    A collection of values returned by getIpRanges.
    """
    def __init__(__self__, cidr_blocks=None, create_date=None, sync_token=None):
        if not cidr_blocks:
            raise TypeError('Missing required argument cidr_blocks')
        elif not isinstance(cidr_blocks, list):
            raise TypeError('Expected argument cidr_blocks to be a list')
        __self__.cidr_blocks = cidr_blocks
        """
        The lexically ordered list of CIDR blocks.
        """
        if not create_date:
            raise TypeError('Missing required argument create_date')
        elif not isinstance(create_date, basestring):
            raise TypeError('Expected argument create_date to be a basestring')
        __self__.create_date = create_date
        """
        The publication time of the IP ranges (e.g. `2016-08-03-23-46-05`).
        """
        if not sync_token:
            raise TypeError('Missing required argument sync_token')
        elif not isinstance(sync_token, int):
            raise TypeError('Expected argument sync_token to be a int')
        __self__.sync_token = sync_token
        """
        The publication time of the IP ranges, in Unix epoch time format
        (e.g. `1470267965`).
        """

def get_ip_ranges(regions=None, services=None):
    """
    Use this data source to get the [IP ranges][1] of various AWS products and services.
    """
    __args__ = dict()

    __args__['regions'] = regions
    __args__['services'] = services
    __ret__ = pulumi.runtime.invoke('aws:index/getIpRanges:getIpRanges', __args__)

    return GetIpRangesResult(
        cidr_blocks=__ret__['cidrBlocks'],
        create_date=__ret__['createDate'],
        sync_token=__ret__['syncToken'])