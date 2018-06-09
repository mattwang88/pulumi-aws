# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class BucketNotification(pulumi.CustomResource):
    """
    Provides a S3 bucket notification resource.
    """
    def __init__(__self__, __name__, __opts__=None, bucket=None, lambda_functions=None, queues=None, topics=None):
        """Create a BucketNotification resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not bucket:
            raise TypeError('Missing required property bucket')
        elif not isinstance(bucket, basestring):
            raise TypeError('Expected property bucket to be a basestring')
        __self__.bucket = bucket
        """
        The name of the bucket to put notification configuration.
        """
        __props__['bucket'] = bucket

        if lambda_functions and not isinstance(lambda_functions, list):
            raise TypeError('Expected property lambda_functions to be a list')
        __self__.lambda_functions = lambda_functions
        """
        Used to configure notifications to a Lambda Function (documented below).
        """
        __props__['lambdaFunctions'] = lambda_functions

        if queues and not isinstance(queues, list):
            raise TypeError('Expected property queues to be a list')
        __self__.queues = queues
        """
        The notification configuration to SQS Queue (documented below).
        """
        __props__['queues'] = queues

        if topics and not isinstance(topics, list):
            raise TypeError('Expected property topics to be a list')
        __self__.topics = topics
        """
        The notification configuration to SNS Topic (documented below).
        """
        __props__['topics'] = topics

        super(BucketNotification, __self__).__init__(
            'aws:s3/bucketNotification:BucketNotification',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'bucket' in outs:
            self.bucket = outs['bucket']
        if 'lambdaFunctions' in outs:
            self.lambda_functions = outs['lambdaFunctions']
        if 'queues' in outs:
            self.queues = outs['queues']
        if 'topics' in outs:
            self.topics = outs['topics']
