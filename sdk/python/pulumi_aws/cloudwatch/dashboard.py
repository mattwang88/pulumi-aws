# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Dashboard(pulumi.CustomResource):
    """
    Provides a CloudWatch Dashboard resource.
    """
    def __init__(__self__, __name__, __opts__=None, dashboard_body=None, dashboard_name=None):
        """Create a Dashboard resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not dashboard_body:
            raise TypeError('Missing required property dashboard_body')
        elif not isinstance(dashboard_body, basestring):
            raise TypeError('Expected property dashboard_body to be a basestring')
        __self__.dashboard_body = dashboard_body
        """
        The detailed information about the dashboard, including what widgets are included and their location on the dashboard. You can read more about the body structure in the [documentation](https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/CloudWatch-Dashboard-Body-Structure.html).
        """
        __props__['dashboardBody'] = dashboard_body

        if not dashboard_name:
            raise TypeError('Missing required property dashboard_name')
        elif not isinstance(dashboard_name, basestring):
            raise TypeError('Expected property dashboard_name to be a basestring')
        __self__.dashboard_name = dashboard_name
        """
        The name of the dashboard.
        """
        __props__['dashboardName'] = dashboard_name

        __self__.dashboard_arn = pulumi.runtime.UNKNOWN
        """
        The Amazon Resource Name (ARN) of the dashboard.
        """

        super(Dashboard, __self__).__init__(
            'aws:cloudwatch/dashboard:Dashboard',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'dashboardArn' in outs:
            self.dashboard_arn = outs['dashboardArn']
        if 'dashboardBody' in outs:
            self.dashboard_body = outs['dashboardBody']
        if 'dashboardName' in outs:
            self.dashboard_name = outs['dashboardName']
