# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Thing(pulumi.CustomResource):
    """
    Creates and manages an AWS IoT Thing.
    """
    def __init__(__self__, __name__, __opts__=None, attributes=None, name=None, thing_type_name=None):
        """Create a Thing resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if attributes and not isinstance(attributes, dict):
            raise TypeError('Expected property attributes to be a dict')
        __self__.attributes = attributes
        """
        Map of attributes of the thing.
        """
        __props__['attributes'] = attributes

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the thing.
        """
        __props__['name'] = name

        if thing_type_name and not isinstance(thing_type_name, basestring):
            raise TypeError('Expected property thing_type_name to be a basestring')
        __self__.thing_type_name = thing_type_name
        """
        The thing type name.
        """
        __props__['thingTypeName'] = thing_type_name

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The ARN of the thing.
        """
        __self__.default_client_id = pulumi.runtime.UNKNOWN
        """
        The default client ID.
        """
        __self__.version = pulumi.runtime.UNKNOWN
        """
        The current version of the thing record in the registry.
        """

        super(Thing, __self__).__init__(
            'aws:iot/thing:Thing',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'attributes' in outs:
            self.attributes = outs['attributes']
        if 'defaultClientId' in outs:
            self.default_client_id = outs['defaultClientId']
        if 'name' in outs:
            self.name = outs['name']
        if 'thingTypeName' in outs:
            self.thing_type_name = outs['thingTypeName']
        if 'version' in outs:
            self.version = outs['version']
