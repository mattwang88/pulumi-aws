# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LicenseConfiguration(pulumi.CustomResource):
    description: pulumi.Output[str]
    """
    Description of the license configuration.
    """
    license_count: pulumi.Output[float]
    """
    Number of licenses managed by the license configuration.
    """
    license_count_hard_limit: pulumi.Output[bool]
    """
    Sets the number of available licenses as a hard limit.
    """
    license_counting_type: pulumi.Output[str]
    """
    Dimension to use to track license inventory. Specify either `vCPU`, `Instance`, `Core` or `Socket`.
    """
    license_rules: pulumi.Output[list]
    """
    Array of configured License Manager rules.
    """
    name: pulumi.Output[str]
    """
    Name of the license configuration.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, description=None, license_count=None, license_count_hard_limit=None, license_counting_type=None, license_rules=None, name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a License Manager license configuration resource.

        > **Note:** Removing the `license_count` attribute is not supported by the License Manager API - recreate the resource instead.

        ## Rules

        License rules should be in the format of `#RuleType=RuleValue`. Supported rule types:

        * `minimumVcpus` - Resource must have minimum vCPU count in order to use the license. Default: 1
        * `maximumVcpus` - Resource must have maximum vCPU count in order to use the license. Default: unbounded, limit: 10000
        * `minimumCores` - Resource must have minimum core count in order to use the license. Default: 1
        * `maximumCores` - Resource must have maximum core count in order to use the license. Default: unbounded, limit: 10000
        * `minimumSockets` - Resource must have minimum socket count in order to use the license. Default: 1
        * `maximumSockets` - Resource must have maximum socket count in order to use the license. Default: unbounded, limit: 10000
        * `allowedTenancy` - Defines where the license can be used. If set, restricts license usage to selected tenancies. Specify a comma delimited list of `EC2-Default`, `EC2-DedicatedHost`, `EC2-DedicatedInstance`

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/licensemanager_license_configuration.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the license configuration.
        :param pulumi.Input[float] license_count: Number of licenses managed by the license configuration.
        :param pulumi.Input[bool] license_count_hard_limit: Sets the number of available licenses as a hard limit.
        :param pulumi.Input[str] license_counting_type: Dimension to use to track license inventory. Specify either `vCPU`, `Instance`, `Core` or `Socket`.
        :param pulumi.Input[list] license_rules: Array of configured License Manager rules.
        :param pulumi.Input[str] name: Name of the license configuration.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['description'] = description
            __props__['license_count'] = license_count
            __props__['license_count_hard_limit'] = license_count_hard_limit
            if license_counting_type is None:
                raise TypeError("Missing required property 'license_counting_type'")
            __props__['license_counting_type'] = license_counting_type
            __props__['license_rules'] = license_rules
            __props__['name'] = name
            __props__['tags'] = tags
        super(LicenseConfiguration, __self__).__init__(
            'aws:licensemanager/licenseConfiguration:LicenseConfiguration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, description=None, license_count=None, license_count_hard_limit=None, license_counting_type=None, license_rules=None, name=None, tags=None):
        """
        Get an existing LicenseConfiguration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of the license configuration.
        :param pulumi.Input[float] license_count: Number of licenses managed by the license configuration.
        :param pulumi.Input[bool] license_count_hard_limit: Sets the number of available licenses as a hard limit.
        :param pulumi.Input[str] license_counting_type: Dimension to use to track license inventory. Specify either `vCPU`, `Instance`, `Core` or `Socket`.
        :param pulumi.Input[list] license_rules: Array of configured License Manager rules.
        :param pulumi.Input[str] name: Name of the license configuration.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["description"] = description
        __props__["license_count"] = license_count
        __props__["license_count_hard_limit"] = license_count_hard_limit
        __props__["license_counting_type"] = license_counting_type
        __props__["license_rules"] = license_rules
        __props__["name"] = name
        __props__["tags"] = tags
        return LicenseConfiguration(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

