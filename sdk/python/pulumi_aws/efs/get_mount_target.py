# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetMountTargetResult:
    """
    A collection of values returned by getMountTarget.
    """
    def __init__(__self__, dns_name=None, file_system_arn=None, file_system_id=None, id=None, ip_address=None, mount_target_id=None, network_interface_id=None, security_groups=None, subnet_id=None):
        if dns_name and not isinstance(dns_name, str):
            raise TypeError("Expected argument 'dns_name' to be a str")
        __self__.dns_name = dns_name
        """
        The DNS name for the given subnet/AZ per [documented convention](http://docs.aws.amazon.com/efs/latest/ug/mounting-fs-mount-cmd-dns-name.html).
        """
        if file_system_arn and not isinstance(file_system_arn, str):
            raise TypeError("Expected argument 'file_system_arn' to be a str")
        __self__.file_system_arn = file_system_arn
        """
        Amazon Resource Name of the file system for which the mount target is intended.
        """
        if file_system_id and not isinstance(file_system_id, str):
            raise TypeError("Expected argument 'file_system_id' to be a str")
        __self__.file_system_id = file_system_id
        """
        ID of the file system for which the mount target is intended.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
        if ip_address and not isinstance(ip_address, str):
            raise TypeError("Expected argument 'ip_address' to be a str")
        __self__.ip_address = ip_address
        """
        Address at which the file system may be mounted via the mount target.
        """
        if mount_target_id and not isinstance(mount_target_id, str):
            raise TypeError("Expected argument 'mount_target_id' to be a str")
        __self__.mount_target_id = mount_target_id
        if network_interface_id and not isinstance(network_interface_id, str):
            raise TypeError("Expected argument 'network_interface_id' to be a str")
        __self__.network_interface_id = network_interface_id
        """
        The ID of the network interface that Amazon EFS created when it created the mount target.
        """
        if security_groups and not isinstance(security_groups, list):
            raise TypeError("Expected argument 'security_groups' to be a list")
        __self__.security_groups = security_groups
        """
        List of VPC security group IDs attached to the mount target.
        """
        if subnet_id and not isinstance(subnet_id, str):
            raise TypeError("Expected argument 'subnet_id' to be a str")
        __self__.subnet_id = subnet_id
        """
        ID of the mount target's subnet.
        """
class AwaitableGetMountTargetResult(GetMountTargetResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetMountTargetResult(
            dns_name=self.dns_name,
            file_system_arn=self.file_system_arn,
            file_system_id=self.file_system_id,
            id=self.id,
            ip_address=self.ip_address,
            mount_target_id=self.mount_target_id,
            network_interface_id=self.network_interface_id,
            security_groups=self.security_groups,
            subnet_id=self.subnet_id)

def get_mount_target(mount_target_id=None,opts=None):
    """
    Provides information about an Elastic File System Mount Target (EFS).

    > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/efs_mount_target.html.markdown.


    :param str mount_target_id: ID of the mount target that you want to have described
    """
    __args__ = dict()


    __args__['mountTargetId'] = mount_target_id
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:efs/getMountTarget:getMountTarget', __args__, opts=opts).value

    return AwaitableGetMountTargetResult(
        dns_name=__ret__.get('dnsName'),
        file_system_arn=__ret__.get('fileSystemArn'),
        file_system_id=__ret__.get('fileSystemId'),
        id=__ret__.get('id'),
        ip_address=__ret__.get('ipAddress'),
        mount_target_id=__ret__.get('mountTargetId'),
        network_interface_id=__ret__.get('networkInterfaceId'),
        security_groups=__ret__.get('securityGroups'),
        subnet_id=__ret__.get('subnetId'))
