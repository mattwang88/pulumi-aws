# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetClusterResult(object):
    """
    A collection of values returned by getCluster.
    """
    def __init__(__self__, certificate_authority=None, created_at=None, endpoint=None, role_arn=None, version=None, vpc_config=None):
        if not certificate_authority:
            raise TypeError('Missing required argument certificate_authority')
        elif not isinstance(certificate_authority, dict):
            raise TypeError('Expected argument certificate_authority to be a dict')
        __self__.certificate_authority = certificate_authority
        """
        Nested attribute containing `certificate-authority-data` for your cluster.
        """
        if not created_at:
            raise TypeError('Missing required argument created_at')
        elif not isinstance(created_at, basestring):
            raise TypeError('Expected argument created_at to be a basestring')
        __self__.created_at = created_at
        """
        The Unix epoch time stamp in seconds for when the cluster was created.
        """
        if not endpoint:
            raise TypeError('Missing required argument endpoint')
        elif not isinstance(endpoint, basestring):
            raise TypeError('Expected argument endpoint to be a basestring')
        __self__.endpoint = endpoint
        """
        The endpoint for your Kubernetes API server.
        """
        if not role_arn:
            raise TypeError('Missing required argument role_arn')
        elif not isinstance(role_arn, basestring):
            raise TypeError('Expected argument role_arn to be a basestring')
        __self__.role_arn = role_arn
        """
        The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf.
        """
        if not version:
            raise TypeError('Missing required argument version')
        elif not isinstance(version, basestring):
            raise TypeError('Expected argument version to be a basestring')
        __self__.version = version
        """
        The Kubernetes server version for the cluster.
        """
        if not vpc_config:
            raise TypeError('Missing required argument vpc_config')
        elif not isinstance(vpc_config, dict):
            raise TypeError('Expected argument vpc_config to be a dict')
        __self__.vpc_config = vpc_config
        """
        Nested attribute containing VPC configuration for the cluster.
        """

def get_cluster(name=None):
    """
    Retrieve information about an EKS Cluster.
    """
    __args__ = dict()

    __args__['name'] = name
    __ret__ = pulumi.runtime.invoke('aws:eks/getCluster:getCluster', __args__)

    return GetClusterResult(
        certificate_authority=__ret__['certificateAuthority'],
        created_at=__ret__['createdAt'],
        endpoint=__ret__['endpoint'],
        role_arn=__ret__['roleArn'],
        version=__ret__['version'],
        vpc_config=__ret__['vpcConfig'])
