# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Application(pulumi.CustomResource):
    """
    Provides a CodeDeploy application to be used as a basis for deployments
    """
    def __init__(__self__, __name__, __opts__=None, name=None, unique_id=None):
        """Create a Application resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the application.
        """
        __props__['name'] = name

        if unique_id and not isinstance(unique_id, basestring):
            raise TypeError('Expected property unique_id to be a basestring')
        __self__.unique_id = unique_id
        __props__['uniqueId'] = unique_id

        super(Application, __self__).__init__(
            'aws:codedeploy/application:Application',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'name' in outs:
            self.name = outs['name']
        if 'uniqueId' in outs:
            self.unique_id = outs['uniqueId']
