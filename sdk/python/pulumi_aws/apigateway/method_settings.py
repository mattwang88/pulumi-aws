# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class MethodSettings(pulumi.CustomResource):
    """
    Provides an API Gateway Method Settings, e.g. logging or monitoring.
    """
    def __init__(__self__, __name__, __opts__=None, method_path=None, rest_api=None, settings=None, stage_name=None):
        """Create a MethodSettings resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not method_path:
            raise TypeError('Missing required property method_path')
        elif not isinstance(method_path, basestring):
            raise TypeError('Expected property method_path to be a basestring')
        __self__.method_path = method_path
        """
        Method path defined as `{resource_path}/{http_method}` for an individual method override, or `*/*` for overriding all methods in the stage.
        """
        __props__['methodPath'] = method_path

        if not rest_api:
            raise TypeError('Missing required property rest_api')
        elif not isinstance(rest_api, basestring):
            raise TypeError('Expected property rest_api to be a basestring')
        __self__.rest_api = rest_api
        """
        The ID of the REST API
        """
        __props__['restApi'] = rest_api

        if not settings:
            raise TypeError('Missing required property settings')
        elif not isinstance(settings, dict):
            raise TypeError('Expected property settings to be a dict')
        __self__.settings = settings
        """
        The settings block, see below.
        """
        __props__['settings'] = settings

        if not stage_name:
            raise TypeError('Missing required property stage_name')
        elif not isinstance(stage_name, basestring):
            raise TypeError('Expected property stage_name to be a basestring')
        __self__.stage_name = stage_name
        """
        The name of the stage
        """
        __props__['stageName'] = stage_name

        super(MethodSettings, __self__).__init__(
            'aws:apigateway/methodSettings:MethodSettings',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'methodPath' in outs:
            self.method_path = outs['methodPath']
        if 'restApi' in outs:
            self.rest_api = outs['restApi']
        if 'settings' in outs:
            self.settings = outs['settings']
        if 'stageName' in outs:
            self.stage_name = outs['stageName']
