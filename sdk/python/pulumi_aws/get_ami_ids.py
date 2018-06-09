# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetAmiIdsResult(object):
    """
    A collection of values returned by getAmiIds.
    """
    def __init__(__self__, ids=None):
        if not ids:
            raise TypeError('Missing required argument ids')
        elif not isinstance(ids, list):
            raise TypeError('Expected argument ids to be a list')
        __self__.ids = ids

def get_ami_ids(executable_users=None, filters=None, name_regex=None, owners=None):
    """
    Use this data source to get a list of AMI IDs matching the specified criteria.
    """
    __args__ = dict()

    __args__['executableUsers'] = executable_users
    __args__['filters'] = filters
    __args__['nameRegex'] = name_regex
    __args__['owners'] = owners
    __ret__ = pulumi.runtime.invoke('aws:index/getAmiIds:getAmiIds', __args__)

    return GetAmiIdsResult(
        ids=__ret__['ids'])
