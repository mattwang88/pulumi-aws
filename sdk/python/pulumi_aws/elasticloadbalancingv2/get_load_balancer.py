# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetLoadBalancerResult(object):
    """
    A collection of values returned by getLoadBalancer.
    """
    def __init__(__self__, access_logs=None, arn=None, arn_suffix=None, dns_name=None, enable_deletion_protection=None, idle_timeout=None, internal=None, load_balancer_type=None, name=None, security_groups=None, subnet_mappings=None, subnets=None, tags=None, vpc_id=None, zone_id=None):
        if not access_logs:
            raise TypeError('Missing required argument access_logs')
        elif not isinstance(access_logs, dict):
            raise TypeError('Expected argument access_logs to be a dict')
        __self__.access_logs = access_logs
        if not arn:
            raise TypeError('Missing required argument arn')
        elif not isinstance(arn, basestring):
            raise TypeError('Expected argument arn to be a basestring')
        __self__.arn = arn
        if not arn_suffix:
            raise TypeError('Missing required argument arn_suffix')
        elif not isinstance(arn_suffix, basestring):
            raise TypeError('Expected argument arn_suffix to be a basestring')
        __self__.arn_suffix = arn_suffix
        if not dns_name:
            raise TypeError('Missing required argument dns_name')
        elif not isinstance(dns_name, basestring):
            raise TypeError('Expected argument dns_name to be a basestring')
        __self__.dns_name = dns_name
        if not enable_deletion_protection:
            raise TypeError('Missing required argument enable_deletion_protection')
        elif not isinstance(enable_deletion_protection, bool):
            raise TypeError('Expected argument enable_deletion_protection to be a bool')
        __self__.enable_deletion_protection = enable_deletion_protection
        if not idle_timeout:
            raise TypeError('Missing required argument idle_timeout')
        elif not isinstance(idle_timeout, int):
            raise TypeError('Expected argument idle_timeout to be a int')
        __self__.idle_timeout = idle_timeout
        if not internal:
            raise TypeError('Missing required argument internal')
        elif not isinstance(internal, bool):
            raise TypeError('Expected argument internal to be a bool')
        __self__.internal = internal
        if not load_balancer_type:
            raise TypeError('Missing required argument load_balancer_type')
        elif not isinstance(load_balancer_type, basestring):
            raise TypeError('Expected argument load_balancer_type to be a basestring')
        __self__.load_balancer_type = load_balancer_type
        if not name:
            raise TypeError('Missing required argument name')
        elif not isinstance(name, basestring):
            raise TypeError('Expected argument name to be a basestring')
        __self__.name = name
        if not security_groups:
            raise TypeError('Missing required argument security_groups')
        elif not isinstance(security_groups, list):
            raise TypeError('Expected argument security_groups to be a list')
        __self__.security_groups = security_groups
        if not subnet_mappings:
            raise TypeError('Missing required argument subnet_mappings')
        elif not isinstance(subnet_mappings, list):
            raise TypeError('Expected argument subnet_mappings to be a list')
        __self__.subnet_mappings = subnet_mappings
        if not subnets:
            raise TypeError('Missing required argument subnets')
        elif not isinstance(subnets, list):
            raise TypeError('Expected argument subnets to be a list')
        __self__.subnets = subnets
        if not tags:
            raise TypeError('Missing required argument tags')
        elif not isinstance(tags, dict):
            raise TypeError('Expected argument tags to be a dict')
        __self__.tags = tags
        if not vpc_id:
            raise TypeError('Missing required argument vpc_id')
        elif not isinstance(vpc_id, basestring):
            raise TypeError('Expected argument vpc_id to be a basestring')
        __self__.vpc_id = vpc_id
        if not zone_id:
            raise TypeError('Missing required argument zone_id')
        elif not isinstance(zone_id, basestring):
            raise TypeError('Expected argument zone_id to be a basestring')
        __self__.zone_id = zone_id

def get_load_balancer(arn=None, name=None, tags=None):
    """
    ~> **Note:** `aws_alb` is known as `aws_lb`. The functionality is identical.
    
    Provides information about a Load Balancer.
    
    This data source can prove useful when a module accepts an LB as an input
    variable and needs to, for example, determine the security groups associated
    with it, etc.
    """
    __args__ = dict()

    __args__['arn'] = arn
    __args__['name'] = name
    __args__['tags'] = tags
    __ret__ = pulumi.runtime.invoke('aws:elasticloadbalancingv2/getLoadBalancer:getLoadBalancer', __args__)

    return GetLoadBalancerResult(
        access_logs=__ret__['accessLogs'],
        arn=__ret__['arn'],
        arn_suffix=__ret__['arnSuffix'],
        dns_name=__ret__['dnsName'],
        enable_deletion_protection=__ret__['enableDeletionProtection'],
        idle_timeout=__ret__['idleTimeout'],
        internal=__ret__['internal'],
        load_balancer_type=__ret__['loadBalancerType'],
        name=__ret__['name'],
        security_groups=__ret__['securityGroups'],
        subnet_mappings=__ret__['subnetMappings'],
        subnets=__ret__['subnets'],
        tags=__ret__['tags'],
        vpc_id=__ret__['vpcId'],
        zone_id=__ret__['zoneId'])