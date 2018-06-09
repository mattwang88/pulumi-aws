# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Rule(pulumi.CustomResource):
    """
    Provides an AWS Config Rule.
    
    ~> **Note:** Config Rule requires an existing [Configuration Recorder](/docs/providers/aws/r/config_configuration_recorder.html) to be present. Use of `depends_on` is recommended (as shown below) to avoid race conditions.
    """
    def __init__(__self__, __name__, __opts__=None, description=None, input_parameters=None, maximum_execution_frequency=None, name=None, scope=None, source=None):
        """Create a Rule resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Description of the rule
        """
        __props__['description'] = description

        if input_parameters and not isinstance(input_parameters, basestring):
            raise TypeError('Expected property input_parameters to be a basestring')
        __self__.input_parameters = input_parameters
        """
        A string in JSON format that is passed to the AWS Config rule Lambda function.
        """
        __props__['inputParameters'] = input_parameters

        if maximum_execution_frequency and not isinstance(maximum_execution_frequency, basestring):
            raise TypeError('Expected property maximum_execution_frequency to be a basestring')
        __self__.maximum_execution_frequency = maximum_execution_frequency
        """
        The frequency that you want AWS Config to run evaluations for a rule that
        is triggered periodically. If specified, requires `message_type` to be `ScheduledNotification`.
        """
        __props__['maximumExecutionFrequency'] = maximum_execution_frequency

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the rule
        """
        __props__['name'] = name

        if scope and not isinstance(scope, dict):
            raise TypeError('Expected property scope to be a dict')
        __self__.scope = scope
        """
        Scope defines which resources can trigger an evaluation for the rule as documented below.
        """
        __props__['scope'] = scope

        if not source:
            raise TypeError('Missing required property source')
        elif not isinstance(source, dict):
            raise TypeError('Expected property source to be a dict')
        __self__.source = source
        """
        Source specifies the rule owner, the rule identifier, and the notifications that cause
        the function to evaluate your AWS resources as documented below.
        """
        __props__['source'] = source

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The ARN of the config rule
        """
        __self__.rule_id = pulumi.runtime.UNKNOWN
        """
        The ID of the config rule
        """

        super(Rule, __self__).__init__(
            'aws:cfg/rule:Rule',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'description' in outs:
            self.description = outs['description']
        if 'inputParameters' in outs:
            self.input_parameters = outs['inputParameters']
        if 'maximumExecutionFrequency' in outs:
            self.maximum_execution_frequency = outs['maximumExecutionFrequency']
        if 'name' in outs:
            self.name = outs['name']
        if 'ruleId' in outs:
            self.rule_id = outs['ruleId']
        if 'scope' in outs:
            self.scope = outs['scope']
        if 'source' in outs:
            self.source = outs['source']
