# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class SecurityConfiguration(pulumi.CustomResource):
    """
    Provides a resource to manage AWS EMR Security Configurations
    """
    def __init__(__self__, __name__, __opts__=None, configuration=None, name=None, name_prefix=None):
        """Create a SecurityConfiguration resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not configuration:
            raise TypeError('Missing required property configuration')
        elif not isinstance(configuration, basestring):
            raise TypeError('Expected property configuration to be a basestring')
        __self__.configuration = configuration
        """
        A JSON formatted Security Configuration
        """
        __props__['configuration'] = configuration

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the EMR Security Configuration. By default generated by Terraform.
        """
        __props__['name'] = name

        if name_prefix and not isinstance(name_prefix, basestring):
            raise TypeError('Expected property name_prefix to be a basestring')
        __self__.name_prefix = name_prefix
        """
        Creates a unique name beginning with the specified
        prefix. Conflicts with `name`.
        """
        __props__['namePrefix'] = name_prefix

        __self__.creation_date = pulumi.runtime.UNKNOWN
        """
        Date the Security Configuration was created
        """

        super(SecurityConfiguration, __self__).__init__(
            'aws:emr/securityConfiguration:SecurityConfiguration',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'configuration' in outs:
            self.configuration = outs['configuration']
        if 'creationDate' in outs:
            self.creation_date = outs['creationDate']
        if 'name' in outs:
            self.name = outs['name']
        if 'namePrefix' in outs:
            self.name_prefix = outs['namePrefix']
