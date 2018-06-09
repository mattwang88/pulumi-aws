# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

def get_hosted_zone(region=None):
    """
    Use this data source to get the ID of an [elastic beanstalk hosted zone](http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region).
    """
    __args__ = dict()

    __args__['region'] = region
    __ret__ = pulumi.runtime.invoke('aws:elasticbeanstalk/getHostedZone:getHostedZone', __args__)

