# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class UsagePlan(pulumi.CustomResource):
    """
    Provides an API Gateway Usage Plan.
    """
    def __init__(__self__, __name__, __opts__=None, api_stages=None, description=None, name=None, product_code=None, quota_settings=None, throttle_settings=None):
        """Create a UsagePlan resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if api_stages and not isinstance(api_stages, list):
            raise TypeError('Expected property api_stages to be a list')
        __self__.api_stages = api_stages
        """
        The associated [API stages](#api-stages-arguments) of the usage plan.
        """
        __props__['apiStages'] = api_stages

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        The description of a usage plan.
        """
        __props__['description'] = description

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the usage plan.
        """
        __props__['name'] = name

        if product_code and not isinstance(product_code, basestring):
            raise TypeError('Expected property product_code to be a basestring')
        __self__.product_code = product_code
        """
        The AWS Markeplace product identifier to associate with the usage plan as a SaaS product on AWS Marketplace.
        """
        __props__['productCode'] = product_code

        if quota_settings and not isinstance(quota_settings, dict):
            raise TypeError('Expected property quota_settings to be a dict')
        __self__.quota_settings = quota_settings
        """
        The [quota settings](#quota-settings-arguments) of the usage plan.
        """
        __props__['quotaSettings'] = quota_settings

        if throttle_settings and not isinstance(throttle_settings, dict):
            raise TypeError('Expected property throttle_settings to be a dict')
        __self__.throttle_settings = throttle_settings
        """
        The [throttling limits](#throttling-settings-arguments) of the usage plan.
        """
        __props__['throttleSettings'] = throttle_settings

        super(UsagePlan, __self__).__init__(
            'aws:apigateway/usagePlan:UsagePlan',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'apiStages' in outs:
            self.api_stages = outs['apiStages']
        if 'description' in outs:
            self.description = outs['description']
        if 'name' in outs:
            self.name = outs['name']
        if 'productCode' in outs:
            self.product_code = outs['productCode']
        if 'quotaSettings' in outs:
            self.quota_settings = outs['quotaSettings']
        if 'throttleSettings' in outs:
            self.throttle_settings = outs['throttleSettings']
