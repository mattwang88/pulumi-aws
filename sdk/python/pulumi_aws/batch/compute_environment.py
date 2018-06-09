# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class ComputeEnvironment(pulumi.CustomResource):
    """
    Creates a AWS Batch compute environment. Compute environments contain the Amazon ECS container instances that are used to run containerized batch jobs.
    
    For information about AWS Batch, see [What is AWS Batch?][1] .
    For information about compute environment, see [Compute Environments][2] .
    
    ~> **Note:** To prevent a race condition during environment deletion, make sure to set `depends_on` to the related `aws_iam_role_policy_attachment`;
       otherwise, the policy may be destroyed too soon and the compute environment will then get stuck in the `DELETING` state, see [Troubleshooting AWS Batch][3] .
    """
    def __init__(__self__, __name__, __opts__=None, compute_environment_name=None, compute_resources=None, service_role=None, state=None, type=None):
        """Create a ComputeEnvironment resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not compute_environment_name:
            raise TypeError('Missing required property compute_environment_name')
        elif not isinstance(compute_environment_name, basestring):
            raise TypeError('Expected property compute_environment_name to be a basestring')
        __self__.compute_environment_name = compute_environment_name
        """
        The name for your compute environment. Up to 128 letters (uppercase and lowercase), numbers, and underscores are allowed.
        """
        __props__['computeEnvironmentName'] = compute_environment_name

        if compute_resources and not isinstance(compute_resources, dict):
            raise TypeError('Expected property compute_resources to be a dict')
        __self__.compute_resources = compute_resources
        """
        Details of the compute resources managed by the compute environment. This parameter is required for managed compute environments. See details below.
        """
        __props__['computeResources'] = compute_resources

        if not service_role:
            raise TypeError('Missing required property service_role')
        elif not isinstance(service_role, basestring):
            raise TypeError('Expected property service_role to be a basestring')
        __self__.service_role = service_role
        """
        The full Amazon Resource Name (ARN) of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.
        """
        __props__['serviceRole'] = service_role

        if state and not isinstance(state, basestring):
            raise TypeError('Expected property state to be a basestring')
        __self__.state = state
        """
        The state of the compute environment. If the state is `ENABLED`, then the compute environment accepts jobs from a queue and can scale out automatically based on queues. Valid items are `ENABLED` or `DISABLED`. Defaults to `ENABLED`.
        """
        __props__['state'] = state

        if not type:
            raise TypeError('Missing required property type')
        elif not isinstance(type, basestring):
            raise TypeError('Expected property type to be a basestring')
        __self__.type = type
        """
        The type of compute environment. Valid items are `EC2` or `SPOT`.
        """
        __props__['type'] = type

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The Amazon Resource Name (ARN) of the compute environment.
        """
        __self__.ecc_cluster_arn = pulumi.runtime.UNKNOWN
        __self__.ecs_cluster_arn = pulumi.runtime.UNKNOWN
        """
        The Amazon Resource Name (ARN) of the underlying Amazon ECS cluster used by the compute environment.
        """
        __self__.status = pulumi.runtime.UNKNOWN
        """
        The current status of the compute environment (for example, CREATING or VALID).
        """
        __self__.status_reason = pulumi.runtime.UNKNOWN
        """
        A short, human-readable string to provide additional details about the current status of the compute environment.
        """

        super(ComputeEnvironment, __self__).__init__(
            'aws:batch/computeEnvironment:ComputeEnvironment',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'computeEnvironmentName' in outs:
            self.compute_environment_name = outs['computeEnvironmentName']
        if 'computeResources' in outs:
            self.compute_resources = outs['computeResources']
        if 'eccClusterArn' in outs:
            self.ecc_cluster_arn = outs['eccClusterArn']
        if 'ecsClusterArn' in outs:
            self.ecs_cluster_arn = outs['ecsClusterArn']
        if 'serviceRole' in outs:
            self.service_role = outs['serviceRole']
        if 'state' in outs:
            self.state = outs['state']
        if 'status' in outs:
            self.status = outs['status']
        if 'statusReason' in outs:
            self.status_reason = outs['statusReason']
        if 'type' in outs:
            self.type = outs['type']
