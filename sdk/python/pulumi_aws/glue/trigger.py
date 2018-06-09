# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Trigger(pulumi.CustomResource):
    """
    Manages a Glue Trigger resource.
    """
    def __init__(__self__, __name__, __opts__=None, actions=None, description=None, enabled=None, name=None, predicate=None, schedule=None, type=None):
        """Create a Trigger resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not actions:
            raise TypeError('Missing required property actions')
        elif not isinstance(actions, list):
            raise TypeError('Expected property actions to be a list')
        __self__.actions = actions
        """
        List of actions initiated by this trigger when it fires. Defined below.
        """
        __props__['actions'] = actions

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        A description of the new trigger.
        """
        __props__['description'] = description

        if enabled and not isinstance(enabled, bool):
            raise TypeError('Expected property enabled to be a bool')
        __self__.enabled = enabled
        """
        Start the trigger. Defaults to `true`. Not valid to disable for `ON_DEMAND` type.
        """
        __props__['enabled'] = enabled

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the trigger.
        """
        __props__['name'] = name

        if predicate and not isinstance(predicate, dict):
            raise TypeError('Expected property predicate to be a dict')
        __self__.predicate = predicate
        """
        A predicate to specify when the new trigger should fire. Required when trigger type is `CONDITIONAL`. Defined below.
        """
        __props__['predicate'] = predicate

        if schedule and not isinstance(schedule, basestring):
            raise TypeError('Expected property schedule to be a basestring')
        __self__.schedule = schedule
        """
        A cron expression used to specify the schedule. [Time-Based Schedules for Jobs and Crawlers](https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html)
        """
        __props__['schedule'] = schedule

        if not type:
            raise TypeError('Missing required property type')
        elif not isinstance(type, basestring):
            raise TypeError('Expected property type to be a basestring')
        __self__.type = type
        """
        The type of trigger. Valid values are `CONDITIONAL`, `ON_DEMAND`, and `SCHEDULED`.
        """
        __props__['type'] = type

        super(Trigger, __self__).__init__(
            'aws:glue/trigger:Trigger',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'actions' in outs:
            self.actions = outs['actions']
        if 'description' in outs:
            self.description = outs['description']
        if 'enabled' in outs:
            self.enabled = outs['enabled']
        if 'name' in outs:
            self.name = outs['name']
        if 'predicate' in outs:
            self.predicate = outs['predicate']
        if 'schedule' in outs:
            self.schedule = outs['schedule']
        if 'type' in outs:
            self.type = outs['type']
