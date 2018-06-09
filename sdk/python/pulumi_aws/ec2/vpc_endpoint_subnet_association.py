# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class VpcEndpointSubnetAssociation(pulumi.CustomResource):
    """
    Provides a resource to create an association between a VPC endpoint and a subnet.
    
    ~> **NOTE on VPC Endpoints and VPC Endpoint Subnet Associations:** Terraform provides
    both a standalone VPC Endpoint Subnet Association (an association between a VPC endpoint
    and a single `subnet_id`) and a [VPC Endpoint](vpc_endpoint.html) resource with a `subnet_ids`
    attribute. Do not use the same subnet ID in both a VPC Endpoint resource and a VPC Endpoint Subnet
    Association resource. Doing so will cause a conflict of associations and will overwrite the association.
    """
    def __init__(__self__, __name__, __opts__=None, subnet_id=None, vpc_endpoint_id=None):
        """Create a VpcEndpointSubnetAssociation resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not subnet_id:
            raise TypeError('Missing required property subnet_id')
        elif not isinstance(subnet_id, basestring):
            raise TypeError('Expected property subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        The ID of the subnet to be associated with the VPC endpoint.
        """
        __props__['subnetId'] = subnet_id

        if not vpc_endpoint_id:
            raise TypeError('Missing required property vpc_endpoint_id')
        elif not isinstance(vpc_endpoint_id, basestring):
            raise TypeError('Expected property vpc_endpoint_id to be a basestring')
        __self__.vpc_endpoint_id = vpc_endpoint_id
        """
        The ID of the VPC endpoint with which the subnet will be associated.
        """
        __props__['vpcEndpointId'] = vpc_endpoint_id

        super(VpcEndpointSubnetAssociation, __self__).__init__(
            'aws:ec2/vpcEndpointSubnetAssociation:VpcEndpointSubnetAssociation',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'subnetId' in outs:
            self.subnet_id = outs['subnetId']
        if 'vpcEndpointId' in outs:
            self.vpc_endpoint_id = outs['vpcEndpointId']
