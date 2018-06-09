# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetRulesPackagesResult(object):
    """
    A collection of values returned by getRulesPackages.
    """
    def __init__(__self__, arns=None):
        if not arns:
            raise TypeError('Missing required argument arns')
        elif not isinstance(arns, list):
            raise TypeError('Expected argument arns to be a list')
        __self__.arns = arns
        """
        A list of the AWS Inspector Rules Packages arns available in the AWS region.
        """

def get_rules_packages():
    """
    The AWS Inspector Rules Packages data source allows access to the list of AWS
    Inspector Rules Packages which can be used by AWS Inspector within the region
    configured in the provider.
    """
    __args__ = dict()

    __ret__ = pulumi.runtime.invoke('aws:inspector/getRulesPackages:getRulesPackages', __args__)

    return GetRulesPackagesResult(
        arns=__ret__['arns'])
