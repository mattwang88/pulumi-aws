# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class SecurityGroup(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    description for the cache security group. Defaults to "Managed by Pulumi".
    """
    name: pulumi.Output[str]
    """
    Name for the cache security group. This value is stored as a lowercase string.
    """
    security_group_names: pulumi.Output[list]
    """
    List of EC2 security group names to be
    authorized for ingress to the cache security group
    """
    def __init__(__self__, resource_name, opts=None, description=None, name=None, security_group_names=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an ElastiCache Security Group to control access to one or more cache
        clusters.

        > **NOTE:** ElastiCache Security Groups are for use only when working with an
        ElastiCache cluster **outside** of a VPC. If you are using a VPC, see the
        ElastiCache Subnet Group resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elasticache_security_group.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: description for the cache security group. Defaults to "Managed by Pulumi".
        :param pulumi.Input[str] name: Name for the cache security group. This value is stored as a lowercase string.
        :param pulumi.Input[list] security_group_names: List of EC2 security group names to be
               authorized for ingress to the cache security group
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            if description is None:
                description = 'Managed by Pulumi'
            __props__['description'] = description
            __props__['name'] = name
            if security_group_names is None:
                raise TypeError("Missing required property 'security_group_names'")
            __props__['security_group_names'] = security_group_names
        super(SecurityGroup, __self__).__init__(
            'aws:elasticache/securityGroup:SecurityGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, name=None, security_group_names=None):
        """
        Get an existing SecurityGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: description for the cache security group. Defaults to "Managed by Pulumi".
        :param pulumi.Input[str] name: Name for the cache security group. This value is stored as a lowercase string.
        :param pulumi.Input[list] security_group_names: List of EC2 security group names to be
               authorized for ingress to the cache security group
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["name"] = name
        __props__["security_group_names"] = security_group_names
        return SecurityGroup(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

