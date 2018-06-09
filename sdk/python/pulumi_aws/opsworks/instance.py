# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Instance(pulumi.CustomResource):
    """
    Provides an OpsWorks instance resource.
    """
    def __init__(__self__, __name__, __opts__=None, agent_version=None, ami_id=None, architecture=None, auto_scaling_type=None, availability_zone=None, created_at=None, delete_ebs=None, delete_eip=None, ebs_block_devices=None, ebs_optimized=None, ecs_cluster_arn=None, elastic_ip=None, ephemeral_block_devices=None, hostname=None, infrastructure_class=None, install_updates_on_boot=None, instance_profile_arn=None, instance_type=None, last_service_error_id=None, layer_ids=None, os=None, platform=None, private_dns=None, private_ip=None, public_dns=None, public_ip=None, registered_by=None, reported_agent_version=None, reported_os_family=None, reported_os_name=None, reported_os_version=None, root_block_devices=None, root_device_type=None, root_device_volume_id=None, security_group_ids=None, ssh_host_dsa_key_fingerprint=None, ssh_host_rsa_key_fingerprint=None, ssh_key_name=None, stack_id=None, state=None, status=None, subnet_id=None, tenancy=None, virtualization_type=None):
        """Create a Instance resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if agent_version and not isinstance(agent_version, basestring):
            raise TypeError('Expected property agent_version to be a basestring')
        __self__.agent_version = agent_version
        """
        The AWS OpsWorks agent to install.  Defaults to `"INHERIT"`.
        """
        __props__['agentVersion'] = agent_version

        if ami_id and not isinstance(ami_id, basestring):
            raise TypeError('Expected property ami_id to be a basestring')
        __self__.ami_id = ami_id
        """
        The AMI to use for the instance.  If an AMI is specified, `os` must be `"Custom"`.
        """
        __props__['amiId'] = ami_id

        if architecture and not isinstance(architecture, basestring):
            raise TypeError('Expected property architecture to be a basestring')
        __self__.architecture = architecture
        """
        Machine architecture for created instances.  Can be either `"x86_64"` (the default) or `"i386"`
        """
        __props__['architecture'] = architecture

        if auto_scaling_type and not isinstance(auto_scaling_type, basestring):
            raise TypeError('Expected property auto_scaling_type to be a basestring')
        __self__.auto_scaling_type = auto_scaling_type
        """
        Creates load-based or time-based instances.  If set, can be either: `"load"` or `"timer"`.
        """
        __props__['autoScalingType'] = auto_scaling_type

        if availability_zone and not isinstance(availability_zone, basestring):
            raise TypeError('Expected property availability_zone to be a basestring')
        __self__.availability_zone = availability_zone
        """
        Name of the availability zone where instances will be created
        by default.
        """
        __props__['availabilityZone'] = availability_zone

        if created_at and not isinstance(created_at, basestring):
            raise TypeError('Expected property created_at to be a basestring')
        __self__.created_at = created_at
        __props__['createdAt'] = created_at

        if delete_ebs and not isinstance(delete_ebs, bool):
            raise TypeError('Expected property delete_ebs to be a bool')
        __self__.delete_ebs = delete_ebs
        __props__['deleteEbs'] = delete_ebs

        if delete_eip and not isinstance(delete_eip, bool):
            raise TypeError('Expected property delete_eip to be a bool')
        __self__.delete_eip = delete_eip
        __props__['deleteEip'] = delete_eip

        if ebs_block_devices and not isinstance(ebs_block_devices, list):
            raise TypeError('Expected property ebs_block_devices to be a list')
        __self__.ebs_block_devices = ebs_block_devices
        """
        Additional EBS block devices to attach to the
        instance.  See [Block Devices](#block-devices) below for details.
        """
        __props__['ebsBlockDevices'] = ebs_block_devices

        if ebs_optimized and not isinstance(ebs_optimized, bool):
            raise TypeError('Expected property ebs_optimized to be a bool')
        __self__.ebs_optimized = ebs_optimized
        """
        If true, the launched EC2 instance will be EBS-optimized.
        """
        __props__['ebsOptimized'] = ebs_optimized

        if ecs_cluster_arn and not isinstance(ecs_cluster_arn, basestring):
            raise TypeError('Expected property ecs_cluster_arn to be a basestring')
        __self__.ecs_cluster_arn = ecs_cluster_arn
        __props__['ecsClusterArn'] = ecs_cluster_arn

        if elastic_ip and not isinstance(elastic_ip, basestring):
            raise TypeError('Expected property elastic_ip to be a basestring')
        __self__.elastic_ip = elastic_ip
        __props__['elasticIp'] = elastic_ip

        if ephemeral_block_devices and not isinstance(ephemeral_block_devices, list):
            raise TypeError('Expected property ephemeral_block_devices to be a list')
        __self__.ephemeral_block_devices = ephemeral_block_devices
        """
        Customize Ephemeral (also known as
        "Instance Store") volumes on the instance. See [Block Devices](#block-devices) below for details.
        """
        __props__['ephemeralBlockDevices'] = ephemeral_block_devices

        if hostname and not isinstance(hostname, basestring):
            raise TypeError('Expected property hostname to be a basestring')
        __self__.hostname = hostname
        """
        The instance's host name.
        """
        __props__['hostname'] = hostname

        if infrastructure_class and not isinstance(infrastructure_class, basestring):
            raise TypeError('Expected property infrastructure_class to be a basestring')
        __self__.infrastructure_class = infrastructure_class
        __props__['infrastructureClass'] = infrastructure_class

        if install_updates_on_boot and not isinstance(install_updates_on_boot, bool):
            raise TypeError('Expected property install_updates_on_boot to be a bool')
        __self__.install_updates_on_boot = install_updates_on_boot
        """
        Controls where to install OS and package updates when the instance boots.  Defaults to `true`.
        """
        __props__['installUpdatesOnBoot'] = install_updates_on_boot

        if instance_profile_arn and not isinstance(instance_profile_arn, basestring):
            raise TypeError('Expected property instance_profile_arn to be a basestring')
        __self__.instance_profile_arn = instance_profile_arn
        __props__['instanceProfileArn'] = instance_profile_arn

        if instance_type and not isinstance(instance_type, basestring):
            raise TypeError('Expected property instance_type to be a basestring')
        __self__.instance_type = instance_type
        """
        The type of instance to start
        """
        __props__['instanceType'] = instance_type

        if last_service_error_id and not isinstance(last_service_error_id, basestring):
            raise TypeError('Expected property last_service_error_id to be a basestring')
        __self__.last_service_error_id = last_service_error_id
        __props__['lastServiceErrorId'] = last_service_error_id

        if not layer_ids:
            raise TypeError('Missing required property layer_ids')
        elif not isinstance(layer_ids, list):
            raise TypeError('Expected property layer_ids to be a list')
        __self__.layer_ids = layer_ids
        """
        The ids of the layers the instance will belong to.
        """
        __props__['layerIds'] = layer_ids

        if os and not isinstance(os, basestring):
            raise TypeError('Expected property os to be a basestring')
        __self__.os = os
        """
        Name of operating system that will be installed.
        """
        __props__['os'] = os

        if platform and not isinstance(platform, basestring):
            raise TypeError('Expected property platform to be a basestring')
        __self__.platform = platform
        __props__['platform'] = platform

        if private_dns and not isinstance(private_dns, basestring):
            raise TypeError('Expected property private_dns to be a basestring')
        __self__.private_dns = private_dns
        """
        The private DNS name assigned to the instance. Can only be
        used inside the Amazon EC2, and only available if you've enabled DNS hostnames
        for your VPC
        """
        __props__['privateDns'] = private_dns

        if private_ip and not isinstance(private_ip, basestring):
            raise TypeError('Expected property private_ip to be a basestring')
        __self__.private_ip = private_ip
        """
        The private IP address assigned to the instance
        """
        __props__['privateIp'] = private_ip

        if public_dns and not isinstance(public_dns, basestring):
            raise TypeError('Expected property public_dns to be a basestring')
        __self__.public_dns = public_dns
        """
        The public DNS name assigned to the instance. For EC2-VPC, this
        is only available if you've enabled DNS hostnames for your VPC
        """
        __props__['publicDns'] = public_dns

        if public_ip and not isinstance(public_ip, basestring):
            raise TypeError('Expected property public_ip to be a basestring')
        __self__.public_ip = public_ip
        """
        The public IP address assigned to the instance, if applicable.
        """
        __props__['publicIp'] = public_ip

        if registered_by and not isinstance(registered_by, basestring):
            raise TypeError('Expected property registered_by to be a basestring')
        __self__.registered_by = registered_by
        __props__['registeredBy'] = registered_by

        if reported_agent_version and not isinstance(reported_agent_version, basestring):
            raise TypeError('Expected property reported_agent_version to be a basestring')
        __self__.reported_agent_version = reported_agent_version
        __props__['reportedAgentVersion'] = reported_agent_version

        if reported_os_family and not isinstance(reported_os_family, basestring):
            raise TypeError('Expected property reported_os_family to be a basestring')
        __self__.reported_os_family = reported_os_family
        __props__['reportedOsFamily'] = reported_os_family

        if reported_os_name and not isinstance(reported_os_name, basestring):
            raise TypeError('Expected property reported_os_name to be a basestring')
        __self__.reported_os_name = reported_os_name
        __props__['reportedOsName'] = reported_os_name

        if reported_os_version and not isinstance(reported_os_version, basestring):
            raise TypeError('Expected property reported_os_version to be a basestring')
        __self__.reported_os_version = reported_os_version
        __props__['reportedOsVersion'] = reported_os_version

        if root_block_devices and not isinstance(root_block_devices, list):
            raise TypeError('Expected property root_block_devices to be a list')
        __self__.root_block_devices = root_block_devices
        """
        Customize details about the root block
        device of the instance. See [Block Devices](#block-devices) below for details.
        """
        __props__['rootBlockDevices'] = root_block_devices

        if root_device_type and not isinstance(root_device_type, basestring):
            raise TypeError('Expected property root_device_type to be a basestring')
        __self__.root_device_type = root_device_type
        """
        Name of the type of root device instances will have by default.  Can be either `"ebs"` or `"instance-store"`
        """
        __props__['rootDeviceType'] = root_device_type

        if root_device_volume_id and not isinstance(root_device_volume_id, basestring):
            raise TypeError('Expected property root_device_volume_id to be a basestring')
        __self__.root_device_volume_id = root_device_volume_id
        __props__['rootDeviceVolumeId'] = root_device_volume_id

        if security_group_ids and not isinstance(security_group_ids, list):
            raise TypeError('Expected property security_group_ids to be a list')
        __self__.security_group_ids = security_group_ids
        """
        The associated security groups.
        """
        __props__['securityGroupIds'] = security_group_ids

        if ssh_host_dsa_key_fingerprint and not isinstance(ssh_host_dsa_key_fingerprint, basestring):
            raise TypeError('Expected property ssh_host_dsa_key_fingerprint to be a basestring')
        __self__.ssh_host_dsa_key_fingerprint = ssh_host_dsa_key_fingerprint
        __props__['sshHostDsaKeyFingerprint'] = ssh_host_dsa_key_fingerprint

        if ssh_host_rsa_key_fingerprint and not isinstance(ssh_host_rsa_key_fingerprint, basestring):
            raise TypeError('Expected property ssh_host_rsa_key_fingerprint to be a basestring')
        __self__.ssh_host_rsa_key_fingerprint = ssh_host_rsa_key_fingerprint
        __props__['sshHostRsaKeyFingerprint'] = ssh_host_rsa_key_fingerprint

        if ssh_key_name and not isinstance(ssh_key_name, basestring):
            raise TypeError('Expected property ssh_key_name to be a basestring')
        __self__.ssh_key_name = ssh_key_name
        """
        Name of the SSH keypair that instances will have by default.
        """
        __props__['sshKeyName'] = ssh_key_name

        if not stack_id:
            raise TypeError('Missing required property stack_id')
        elif not isinstance(stack_id, basestring):
            raise TypeError('Expected property stack_id to be a basestring')
        __self__.stack_id = stack_id
        """
        The id of the stack the instance will belong to.
        """
        __props__['stackId'] = stack_id

        if state and not isinstance(state, basestring):
            raise TypeError('Expected property state to be a basestring')
        __self__.state = state
        """
        The desired state of the instance.  Can be either `"running"` or `"stopped"`.
        """
        __props__['state'] = state

        if status and not isinstance(status, basestring):
            raise TypeError('Expected property status to be a basestring')
        __self__.status = status
        __props__['status'] = status

        if subnet_id and not isinstance(subnet_id, basestring):
            raise TypeError('Expected property subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        Subnet ID to attach to
        """
        __props__['subnetId'] = subnet_id

        if tenancy and not isinstance(tenancy, basestring):
            raise TypeError('Expected property tenancy to be a basestring')
        __self__.tenancy = tenancy
        """
        Instance tenancy to use. Can be one of `"default"`, `"dedicated"` or `"host"`
        """
        __props__['tenancy'] = tenancy

        if virtualization_type and not isinstance(virtualization_type, basestring):
            raise TypeError('Expected property virtualization_type to be a basestring')
        __self__.virtualization_type = virtualization_type
        """
        Keyword to choose what virtualization mode created instances
        will use. Can be either `"paravirtual"` or `"hvm"`.
        """
        __props__['virtualizationType'] = virtualization_type

        __self__.ec2_instance_id = pulumi.runtime.UNKNOWN
        """
        EC2 instance ID
        """

        super(Instance, __self__).__init__(
            'aws:opsworks/instance:Instance',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'agentVersion' in outs:
            self.agent_version = outs['agentVersion']
        if 'amiId' in outs:
            self.ami_id = outs['amiId']
        if 'architecture' in outs:
            self.architecture = outs['architecture']
        if 'autoScalingType' in outs:
            self.auto_scaling_type = outs['autoScalingType']
        if 'availabilityZone' in outs:
            self.availability_zone = outs['availabilityZone']
        if 'createdAt' in outs:
            self.created_at = outs['createdAt']
        if 'deleteEbs' in outs:
            self.delete_ebs = outs['deleteEbs']
        if 'deleteEip' in outs:
            self.delete_eip = outs['deleteEip']
        if 'ebsBlockDevices' in outs:
            self.ebs_block_devices = outs['ebsBlockDevices']
        if 'ebsOptimized' in outs:
            self.ebs_optimized = outs['ebsOptimized']
        if 'ec2InstanceId' in outs:
            self.ec2_instance_id = outs['ec2InstanceId']
        if 'ecsClusterArn' in outs:
            self.ecs_cluster_arn = outs['ecsClusterArn']
        if 'elasticIp' in outs:
            self.elastic_ip = outs['elasticIp']
        if 'ephemeralBlockDevices' in outs:
            self.ephemeral_block_devices = outs['ephemeralBlockDevices']
        if 'hostname' in outs:
            self.hostname = outs['hostname']
        if 'infrastructureClass' in outs:
            self.infrastructure_class = outs['infrastructureClass']
        if 'installUpdatesOnBoot' in outs:
            self.install_updates_on_boot = outs['installUpdatesOnBoot']
        if 'instanceProfileArn' in outs:
            self.instance_profile_arn = outs['instanceProfileArn']
        if 'instanceType' in outs:
            self.instance_type = outs['instanceType']
        if 'lastServiceErrorId' in outs:
            self.last_service_error_id = outs['lastServiceErrorId']
        if 'layerIds' in outs:
            self.layer_ids = outs['layerIds']
        if 'os' in outs:
            self.os = outs['os']
        if 'platform' in outs:
            self.platform = outs['platform']
        if 'privateDns' in outs:
            self.private_dns = outs['privateDns']
        if 'privateIp' in outs:
            self.private_ip = outs['privateIp']
        if 'publicDns' in outs:
            self.public_dns = outs['publicDns']
        if 'publicIp' in outs:
            self.public_ip = outs['publicIp']
        if 'registeredBy' in outs:
            self.registered_by = outs['registeredBy']
        if 'reportedAgentVersion' in outs:
            self.reported_agent_version = outs['reportedAgentVersion']
        if 'reportedOsFamily' in outs:
            self.reported_os_family = outs['reportedOsFamily']
        if 'reportedOsName' in outs:
            self.reported_os_name = outs['reportedOsName']
        if 'reportedOsVersion' in outs:
            self.reported_os_version = outs['reportedOsVersion']
        if 'rootBlockDevices' in outs:
            self.root_block_devices = outs['rootBlockDevices']
        if 'rootDeviceType' in outs:
            self.root_device_type = outs['rootDeviceType']
        if 'rootDeviceVolumeId' in outs:
            self.root_device_volume_id = outs['rootDeviceVolumeId']
        if 'securityGroupIds' in outs:
            self.security_group_ids = outs['securityGroupIds']
        if 'sshHostDsaKeyFingerprint' in outs:
            self.ssh_host_dsa_key_fingerprint = outs['sshHostDsaKeyFingerprint']
        if 'sshHostRsaKeyFingerprint' in outs:
            self.ssh_host_rsa_key_fingerprint = outs['sshHostRsaKeyFingerprint']
        if 'sshKeyName' in outs:
            self.ssh_key_name = outs['sshKeyName']
        if 'stackId' in outs:
            self.stack_id = outs['stackId']
        if 'state' in outs:
            self.state = outs['state']
        if 'status' in outs:
            self.status = outs['status']
        if 'subnetId' in outs:
            self.subnet_id = outs['subnetId']
        if 'tenancy' in outs:
            self.tenancy = outs['tenancy']
        if 'virtualizationType' in outs:
            self.virtualization_type = outs['virtualizationType']
