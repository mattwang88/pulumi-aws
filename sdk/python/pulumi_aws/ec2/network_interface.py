# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class NetworkInterface(pulumi.CustomResource):
    """
    Provides an Elastic network interface (ENI) resource.
    """
    def __init__(__self__, __name__, __opts__=None, attachments=None, description=None, private_ip=None, private_ips=None, private_ips_count=None, security_groups=None, source_dest_check=None, subnet_id=None, tags=None):
        """Create a NetworkInterface resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if attachments and not isinstance(attachments, list):
            raise TypeError('Expected property attachments to be a list')
        __self__.attachments = attachments
        """
        Block to define the attachment of the ENI. Documented below.
        """
        __props__['attachments'] = attachments

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        A description for the network interface.
        """
        __props__['description'] = description

        if private_ip and not isinstance(private_ip, basestring):
            raise TypeError('Expected property private_ip to be a basestring')
        __self__.private_ip = private_ip
        __props__['privateIp'] = private_ip

        if private_ips and not isinstance(private_ips, list):
            raise TypeError('Expected property private_ips to be a list')
        __self__.private_ips = private_ips
        """
        List of private IPs to assign to the ENI.
        """
        __props__['privateIps'] = private_ips

        if private_ips_count and not isinstance(private_ips_count, int):
            raise TypeError('Expected property private_ips_count to be a int')
        __self__.private_ips_count = private_ips_count
        """
        Number of private IPs to assign to the ENI.
        """
        __props__['privateIpsCount'] = private_ips_count

        if security_groups and not isinstance(security_groups, list):
            raise TypeError('Expected property security_groups to be a list')
        __self__.security_groups = security_groups
        """
        List of security group IDs to assign to the ENI.
        """
        __props__['securityGroups'] = security_groups

        if source_dest_check and not isinstance(source_dest_check, bool):
            raise TypeError('Expected property source_dest_check to be a bool')
        __self__.source_dest_check = source_dest_check
        """
        Whether to enable source destination checking for the ENI. Default true.
        """
        __props__['sourceDestCheck'] = source_dest_check

        if not subnet_id:
            raise TypeError('Missing required property subnet_id')
        elif not isinstance(subnet_id, basestring):
            raise TypeError('Expected property subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        Subnet ID to create the ENI in.
        """
        __props__['subnetId'] = subnet_id

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        __props__['tags'] = tags

        __self__.private_dns_name = pulumi.runtime.UNKNOWN

        super(NetworkInterface, __self__).__init__(
            'aws:ec2/networkInterface:NetworkInterface',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'attachments' in outs:
            self.attachments = outs['attachments']
        if 'description' in outs:
            self.description = outs['description']
        if 'privateDnsName' in outs:
            self.private_dns_name = outs['privateDnsName']
        if 'privateIp' in outs:
            self.private_ip = outs['privateIp']
        if 'privateIps' in outs:
            self.private_ips = outs['privateIps']
        if 'privateIpsCount' in outs:
            self.private_ips_count = outs['privateIpsCount']
        if 'securityGroups' in outs:
            self.security_groups = outs['securityGroups']
        if 'sourceDestCheck' in outs:
            self.source_dest_check = outs['sourceDestCheck']
        if 'subnetId' in outs:
            self.subnet_id = outs['subnetId']
        if 'tags' in outs:
            self.tags = outs['tags']
