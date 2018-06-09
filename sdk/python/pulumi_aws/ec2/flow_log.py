# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class FlowLog(pulumi.CustomResource):
    """
    Provides a VPC/Subnet/ENI Flow Log to capture IP traffic for a specific network
    interface, subnet, or VPC. Logs are sent to a CloudWatch Log Group.
    """
    def __init__(__self__, __name__, __opts__=None, eni_id=None, iam_role_arn=None, log_group_name=None, subnet_id=None, traffic_type=None, vpc_id=None):
        """Create a FlowLog resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if eni_id and not isinstance(eni_id, basestring):
            raise TypeError('Expected property eni_id to be a basestring')
        __self__.eni_id = eni_id
        """
        Elastic Network Interface ID to attach to
        """
        __props__['eniId'] = eni_id

        if not iam_role_arn:
            raise TypeError('Missing required property iam_role_arn')
        elif not isinstance(iam_role_arn, basestring):
            raise TypeError('Expected property iam_role_arn to be a basestring')
        __self__.iam_role_arn = iam_role_arn
        """
        The ARN for the IAM role that's used to post flow
        logs to a CloudWatch Logs log group
        """
        __props__['iamRoleArn'] = iam_role_arn

        if not log_group_name:
            raise TypeError('Missing required property log_group_name')
        elif not isinstance(log_group_name, basestring):
            raise TypeError('Expected property log_group_name to be a basestring')
        __self__.log_group_name = log_group_name
        """
        The name of the CloudWatch log group
        """
        __props__['logGroupName'] = log_group_name

        if subnet_id and not isinstance(subnet_id, basestring):
            raise TypeError('Expected property subnet_id to be a basestring')
        __self__.subnet_id = subnet_id
        """
        Subnet ID to attach to
        """
        __props__['subnetId'] = subnet_id

        if not traffic_type:
            raise TypeError('Missing required property traffic_type')
        elif not isinstance(traffic_type, basestring):
            raise TypeError('Expected property traffic_type to be a basestring')
        __self__.traffic_type = traffic_type
        """
        The type of traffic to capture. Valid values:
        `ACCEPT`,`REJECT`, `ALL`
        """
        __props__['trafficType'] = traffic_type

        if vpc_id and not isinstance(vpc_id, basestring):
            raise TypeError('Expected property vpc_id to be a basestring')
        __self__.vpc_id = vpc_id
        """
        VPC ID to attach to
        """
        __props__['vpcId'] = vpc_id

        super(FlowLog, __self__).__init__(
            'aws:ec2/flowLog:FlowLog',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'eniId' in outs:
            self.eni_id = outs['eniId']
        if 'iamRoleArn' in outs:
            self.iam_role_arn = outs['iamRoleArn']
        if 'logGroupName' in outs:
            self.log_group_name = outs['logGroupName']
        if 'subnetId' in outs:
            self.subnet_id = outs['subnetId']
        if 'trafficType' in outs:
            self.traffic_type = outs['trafficType']
        if 'vpcId' in outs:
            self.vpc_id = outs['vpcId']
