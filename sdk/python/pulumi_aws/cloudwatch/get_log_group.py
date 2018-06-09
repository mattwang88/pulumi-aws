# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetLogGroupResult(object):
    """
    A collection of values returned by getLogGroup.
    """
    def __init__(__self__, arn=None, creation_time=None):
        if not arn:
            raise TypeError('Missing required argument arn')
        elif not isinstance(arn, basestring):
            raise TypeError('Expected argument arn to be a basestring')
        __self__.arn = arn
        """
        The ARN of the Cloudwatch log group
        """
        if not creation_time:
            raise TypeError('Missing required argument creation_time')
        elif not isinstance(creation_time, int):
            raise TypeError('Expected argument creation_time to be a int')
        __self__.creation_time = creation_time
        """
        The creation time of the log group, expressed as the number of milliseconds after Jan 1, 1970 00:00:00 UTC.
        """

def get_log_group(name=None):
    """
    Use this data source to get information about an AWS Cloudwatch Log Group
    """
    __args__ = dict()

    __args__['name'] = name
    __ret__ = pulumi.runtime.invoke('aws:cloudwatch/getLogGroup:getLogGroup', __args__)

    return GetLogGroupResult(
        arn=__ret__['arn'],
        creation_time=__ret__['creationTime'])
