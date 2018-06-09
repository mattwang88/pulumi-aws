# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class NetworkAcl(pulumi.CustomResource):
    """
    Provides an network ACL resource. You might set up network ACLs with rules similar
    to your security groups in order to add an additional layer of security to your VPC.
    
    ~> **NOTE on Network ACLs and Network ACL Rules:** Terraform currently
    provides both a standalone [Network ACL Rule](network_acl_rule.html) resource and a Network ACL resource with rules
    defined in-line. At this time you cannot use a Network ACL with in-line rules
    in conjunction with any Network ACL Rule resources. Doing so will cause
    a conflict of rule settings and will overwrite rules.
    """
    def __init__(__self__, __name__, __opts__=None, egress=None, ingress=None, subnet_id=None, subnet_ids=None, tags=None, vpc_id=None):
        """Create a NetworkAcl resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if egress and not isinstance(egress, list):
            raise TypeError('Expected property egress to be a list')
        __self__.egress = egress
        """
        Specifies an egress rule. Parameters defined below.
        """
        __props__['egress'] = egress

        if ingress and not isinstance(ingress, list):
            raise TypeError('Expected property ingress to be a list')
        __self__.ingress = ingress
        """
        Specifies an ingress rule. Parameters defined below.
        """
        __props__['ingress'] = ingress

        if subnet_id and not isinstance(subnet_id, basestring):
            raise TypeError('Expected property subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        The ID of the associated Subnet. This
        attribute is deprecated, please use the `subnet_ids` attribute instead
        """
        __props__['subnetId'] = subnet_id

        if subnet_ids and not isinstance(subnet_ids, list):
            raise TypeError('Expected property subnet_ids to be a list')
        __self__.subnet_ids = subnet_ids
        """
        A list of Subnet IDs to apply the ACL to
        """
        __props__['subnetIds'] = subnet_ids

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        __props__['tags'] = tags

        if not vpc_id:
            raise TypeError('Missing required property vpc_id')
        elif not isinstance(vpc_id, basestring):
            raise TypeError('Expected property vpc_id to be a basestring')
        __self__.vpc_id = vpc_id
        """
        The ID of the associated VPC.
        """
        __props__['vpcId'] = vpc_id

        super(NetworkAcl, __self__).__init__(
            'aws:ec2/networkAcl:NetworkAcl',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'egress' in outs:
            self.egress = outs['egress']
        if 'ingress' in outs:
            self.ingress = outs['ingress']
        if 'subnetId' in outs:
            self.subnet_id = outs['subnetId']
        if 'subnetIds' in outs:
            self.subnet_ids = outs['subnetIds']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'vpcId' in outs:
            self.vpc_id = outs['vpcId']
