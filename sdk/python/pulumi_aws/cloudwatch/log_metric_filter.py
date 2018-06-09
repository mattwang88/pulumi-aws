# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class LogMetricFilter(pulumi.CustomResource):
    """
    Provides a CloudWatch Log Metric Filter resource.
    """
    def __init__(__self__, __name__, __opts__=None, log_group_name=None, metric_transformation=None, name=None, pattern=None):
        """Create a LogMetricFilter resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not log_group_name:
            raise TypeError('Missing required property log_group_name')
        elif not isinstance(log_group_name, basestring):
            raise TypeError('Expected property log_group_name to be a basestring')
        __self__.log_group_name = log_group_name
        """
        The name of the log group to associate the metric filter with.
        """
        __props__['logGroupName'] = log_group_name

        if not metric_transformation:
            raise TypeError('Missing required property metric_transformation')
        elif not isinstance(metric_transformation, dict):
            raise TypeError('Expected property metric_transformation to be a dict')
        __self__.metric_transformation = metric_transformation
        """
        A block defining collection of information
        needed to define how metric data gets emitted. See below.
        """
        __props__['metricTransformation'] = metric_transformation

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the CloudWatch metric to which the monitored log information should be published (e.g. `ErrorCount`)
        """
        __props__['name'] = name

        if not pattern:
            raise TypeError('Missing required property pattern')
        elif not isinstance(pattern, basestring):
            raise TypeError('Expected property pattern to be a basestring')
        __self__.pattern = pattern
        """
        A valid [CloudWatch Logs filter pattern](https://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/FilterAndPatternSyntax.html)
        for extracting metric data out of ingested log events.
        """
        __props__['pattern'] = pattern

        super(LogMetricFilter, __self__).__init__(
            'aws:cloudwatch/logMetricFilter:LogMetricFilter',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'logGroupName' in outs:
            self.log_group_name = outs['logGroupName']
        if 'metricTransformation' in outs:
            self.metric_transformation = outs['metricTransformation']
        if 'name' in outs:
            self.name = outs['name']
        if 'pattern' in outs:
            self.pattern = outs['pattern']
