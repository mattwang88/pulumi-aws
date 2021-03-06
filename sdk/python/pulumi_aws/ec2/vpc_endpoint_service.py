# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class VpcEndpointService(pulumi.CustomResource):
    acceptance_required: pulumi.Output[bool]
    """
    Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
    """
    allowed_principals: pulumi.Output[list]
    """
    The ARNs of one or more principals allowed to discover the endpoint service.
    """
    availability_zones: pulumi.Output[list]
    """
    The Availability Zones in which the service is available.
    """
    base_endpoint_dns_names: pulumi.Output[list]
    """
    The DNS names for the service.
    """
    manages_vpc_endpoints: pulumi.Output[bool]
    """
    Whether or not the service manages its VPC endpoints - `true` or `false`.
    """
    network_load_balancer_arns: pulumi.Output[list]
    """
    The ARNs of one or more Network Load Balancers for the endpoint service.
    """
    private_dns_name: pulumi.Output[str]
    """
    The private DNS name for the service.
    """
    service_name: pulumi.Output[str]
    """
    The service name.
    """
    service_type: pulumi.Output[str]
    """
    The service type, `Gateway` or `Interface`.
    """
    state: pulumi.Output[str]
    """
    The state of the VPC endpoint service.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, acceptance_required=None, allowed_principals=None, network_load_balancer_arns=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a VPC Endpoint Service resource.
        Service consumers can create an _Interface_ VPC Endpoint to connect to the service.

        > **NOTE on VPC Endpoint Services and VPC Endpoint Service Allowed Principals:** This provider provides
        both a standalone VPC Endpoint Service Allowed Principal resource
        and a VPC Endpoint Service resource with an `allowed_principals` attribute. Do not use the same principal ARN in both
        a VPC Endpoint Service resource and a VPC Endpoint Service Allowed Principal resource. Doing so will cause a conflict
        and will overwrite the association.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/vpc_endpoint_service.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] acceptance_required: Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
        :param pulumi.Input[list] allowed_principals: The ARNs of one or more principals allowed to discover the endpoint service.
        :param pulumi.Input[list] network_load_balancer_arns: The ARNs of one or more Network Load Balancers for the endpoint service.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
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

            if acceptance_required is None:
                raise TypeError("Missing required property 'acceptance_required'")
            __props__['acceptance_required'] = acceptance_required
            __props__['allowed_principals'] = allowed_principals
            if network_load_balancer_arns is None:
                raise TypeError("Missing required property 'network_load_balancer_arns'")
            __props__['network_load_balancer_arns'] = network_load_balancer_arns
            __props__['tags'] = tags
            __props__['availability_zones'] = None
            __props__['base_endpoint_dns_names'] = None
            __props__['manages_vpc_endpoints'] = None
            __props__['private_dns_name'] = None
            __props__['service_name'] = None
            __props__['service_type'] = None
            __props__['state'] = None
        super(VpcEndpointService, __self__).__init__(
            'aws:ec2/vpcEndpointService:VpcEndpointService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, acceptance_required=None, allowed_principals=None, availability_zones=None, base_endpoint_dns_names=None, manages_vpc_endpoints=None, network_load_balancer_arns=None, private_dns_name=None, service_name=None, service_type=None, state=None, tags=None):
        """
        Get an existing VpcEndpointService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] acceptance_required: Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
        :param pulumi.Input[list] allowed_principals: The ARNs of one or more principals allowed to discover the endpoint service.
        :param pulumi.Input[list] availability_zones: The Availability Zones in which the service is available.
        :param pulumi.Input[list] base_endpoint_dns_names: The DNS names for the service.
        :param pulumi.Input[bool] manages_vpc_endpoints: Whether or not the service manages its VPC endpoints - `true` or `false`.
        :param pulumi.Input[list] network_load_balancer_arns: The ARNs of one or more Network Load Balancers for the endpoint service.
        :param pulumi.Input[str] private_dns_name: The private DNS name for the service.
        :param pulumi.Input[str] service_name: The service name.
        :param pulumi.Input[str] service_type: The service type, `Gateway` or `Interface`.
        :param pulumi.Input[str] state: The state of the VPC endpoint service.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["acceptance_required"] = acceptance_required
        __props__["allowed_principals"] = allowed_principals
        __props__["availability_zones"] = availability_zones
        __props__["base_endpoint_dns_names"] = base_endpoint_dns_names
        __props__["manages_vpc_endpoints"] = manages_vpc_endpoints
        __props__["network_load_balancer_arns"] = network_load_balancer_arns
        __props__["private_dns_name"] = private_dns_name
        __props__["service_name"] = service_name
        __props__["service_type"] = service_type
        __props__["state"] = state
        __props__["tags"] = tags
        return VpcEndpointService(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

