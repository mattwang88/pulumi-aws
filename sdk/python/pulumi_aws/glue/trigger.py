# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Trigger(pulumi.CustomResource):
    actions: pulumi.Output[list]
    """
    List of actions initiated by this trigger when it fires. Defined below.

      * `arguments` (`dict`) - Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.
      * `crawlerName` (`str`) - The name of the crawler to be executed. Conflicts with `job_name`.
      * `jobName` (`str`) - The name of a job to be executed. Conflicts with `crawler_name`.
      * `timeout` (`float`) - The job run timeout in minutes. It overrides the timeout value of the job.
    """
    arn: pulumi.Output[str]
    """
    Amazon Resource Name (ARN) of Glue Trigger
    """
    description: pulumi.Output[str]
    """
    A description of the new trigger.
    """
    enabled: pulumi.Output[bool]
    """
    Start the trigger. Defaults to `true`. Not valid to disable for `ON_DEMAND` type.
    """
    name: pulumi.Output[str]
    """
    The name of the trigger.
    """
    predicate: pulumi.Output[dict]
    """
    A predicate to specify when the new trigger should fire. Required when trigger type is `CONDITIONAL`. Defined below.

      * `conditions` (`list`) - A list of the conditions that determine when the trigger will fire. Defined below.
        * `crawlState` (`str`) - The condition crawl state. Currently, the values supported are `RUNNING`, `SUCCEEDED`, `CANCELLED`, and `FAILED`. If this is specified, `crawler_name` must also be specified. Conflicts with `state`.
        * `crawlerName` (`str`) - The name of the crawler to watch. If this is specified, `crawl_state` must also be specified. Conflicts with `job_name`.
        * `jobName` (`str`) - The name of the job to watch. If this is specified, `state` must also be specified. Conflicts with `crawler_name`.
        * `logicalOperator` (`str`) - A logical operator. Defaults to `EQUALS`.
        * `state` (`str`) - The condition job state. Currently, the values supported are `SUCCEEDED`, `STOPPED`, `TIMEOUT` and `FAILED`. If this is specified, `job_name` must also be specified. Conflicts with `crawler_state`.

      * `logical` (`str`) - How to handle multiple conditions. Defaults to `AND`. Valid values are `AND` or `ANY`.
    """
    schedule: pulumi.Output[str]
    """
    A cron expression used to specify the schedule. [Time-Based Schedules for Jobs and Crawlers](https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html)
    """
    tags: pulumi.Output[dict]
    """
    Key-value mapping of resource tags
    """
    type: pulumi.Output[str]
    """
    The type of trigger. Valid values are `CONDITIONAL`, `ON_DEMAND`, and `SCHEDULED`.
    """
    workflow_name: pulumi.Output[str]
    """
    A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (`ON_DEMAND` or `SCHEDULED` type) and can contain multiple additional `CONDITIONAL` triggers.
    """
    def __init__(__self__, resource_name, opts=None, actions=None, description=None, enabled=None, name=None, predicate=None, schedule=None, tags=None, type=None, workflow_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Glue Trigger resource.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/glue_trigger.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] actions: List of actions initiated by this trigger when it fires. Defined below.
        :param pulumi.Input[str] description: A description of the new trigger.
        :param pulumi.Input[bool] enabled: Start the trigger. Defaults to `true`. Not valid to disable for `ON_DEMAND` type.
        :param pulumi.Input[str] name: The name of the trigger.
        :param pulumi.Input[dict] predicate: A predicate to specify when the new trigger should fire. Required when trigger type is `CONDITIONAL`. Defined below.
        :param pulumi.Input[str] schedule: A cron expression used to specify the schedule. [Time-Based Schedules for Jobs and Crawlers](https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html)
        :param pulumi.Input[dict] tags: Key-value mapping of resource tags
        :param pulumi.Input[str] type: The type of trigger. Valid values are `CONDITIONAL`, `ON_DEMAND`, and `SCHEDULED`.
        :param pulumi.Input[str] workflow_name: A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (`ON_DEMAND` or `SCHEDULED` type) and can contain multiple additional `CONDITIONAL` triggers.

        The **actions** object supports the following:

          * `arguments` (`pulumi.Input[dict]`) - Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.
          * `crawlerName` (`pulumi.Input[str]`) - The name of the crawler to be executed. Conflicts with `job_name`.
          * `jobName` (`pulumi.Input[str]`) - The name of a job to be executed. Conflicts with `crawler_name`.
          * `timeout` (`pulumi.Input[float]`) - The job run timeout in minutes. It overrides the timeout value of the job.

        The **predicate** object supports the following:

          * `conditions` (`pulumi.Input[list]`) - A list of the conditions that determine when the trigger will fire. Defined below.
            * `crawlState` (`pulumi.Input[str]`) - The condition crawl state. Currently, the values supported are `RUNNING`, `SUCCEEDED`, `CANCELLED`, and `FAILED`. If this is specified, `crawler_name` must also be specified. Conflicts with `state`.
            * `crawlerName` (`pulumi.Input[str]`) - The name of the crawler to watch. If this is specified, `crawl_state` must also be specified. Conflicts with `job_name`.
            * `jobName` (`pulumi.Input[str]`) - The name of the job to watch. If this is specified, `state` must also be specified. Conflicts with `crawler_name`.
            * `logicalOperator` (`pulumi.Input[str]`) - A logical operator. Defaults to `EQUALS`.
            * `state` (`pulumi.Input[str]`) - The condition job state. Currently, the values supported are `SUCCEEDED`, `STOPPED`, `TIMEOUT` and `FAILED`. If this is specified, `job_name` must also be specified. Conflicts with `crawler_state`.

          * `logical` (`pulumi.Input[str]`) - How to handle multiple conditions. Defaults to `AND`. Valid values are `AND` or `ANY`.
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

            if actions is None:
                raise TypeError("Missing required property 'actions'")
            __props__['actions'] = actions
            __props__['description'] = description
            __props__['enabled'] = enabled
            __props__['name'] = name
            __props__['predicate'] = predicate
            __props__['schedule'] = schedule
            __props__['tags'] = tags
            if type is None:
                raise TypeError("Missing required property 'type'")
            __props__['type'] = type
            __props__['workflow_name'] = workflow_name
            __props__['arn'] = None
        super(Trigger, __self__).__init__(
            'aws:glue/trigger:Trigger',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, actions=None, arn=None, description=None, enabled=None, name=None, predicate=None, schedule=None, tags=None, type=None, workflow_name=None):
        """
        Get an existing Trigger resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] actions: List of actions initiated by this trigger when it fires. Defined below.
        :param pulumi.Input[str] arn: Amazon Resource Name (ARN) of Glue Trigger
        :param pulumi.Input[str] description: A description of the new trigger.
        :param pulumi.Input[bool] enabled: Start the trigger. Defaults to `true`. Not valid to disable for `ON_DEMAND` type.
        :param pulumi.Input[str] name: The name of the trigger.
        :param pulumi.Input[dict] predicate: A predicate to specify when the new trigger should fire. Required when trigger type is `CONDITIONAL`. Defined below.
        :param pulumi.Input[str] schedule: A cron expression used to specify the schedule. [Time-Based Schedules for Jobs and Crawlers](https://docs.aws.amazon.com/glue/latest/dg/monitor-data-warehouse-schedule.html)
        :param pulumi.Input[dict] tags: Key-value mapping of resource tags
        :param pulumi.Input[str] type: The type of trigger. Valid values are `CONDITIONAL`, `ON_DEMAND`, and `SCHEDULED`.
        :param pulumi.Input[str] workflow_name: A workflow to which the trigger should be associated to. Every workflow graph (DAG) needs a starting trigger (`ON_DEMAND` or `SCHEDULED` type) and can contain multiple additional `CONDITIONAL` triggers.

        The **actions** object supports the following:

          * `arguments` (`pulumi.Input[dict]`) - Arguments to be passed to the job. You can specify arguments here that your own job-execution script consumes, as well as arguments that AWS Glue itself consumes.
          * `crawlerName` (`pulumi.Input[str]`) - The name of the crawler to be executed. Conflicts with `job_name`.
          * `jobName` (`pulumi.Input[str]`) - The name of a job to be executed. Conflicts with `crawler_name`.
          * `timeout` (`pulumi.Input[float]`) - The job run timeout in minutes. It overrides the timeout value of the job.

        The **predicate** object supports the following:

          * `conditions` (`pulumi.Input[list]`) - A list of the conditions that determine when the trigger will fire. Defined below.
            * `crawlState` (`pulumi.Input[str]`) - The condition crawl state. Currently, the values supported are `RUNNING`, `SUCCEEDED`, `CANCELLED`, and `FAILED`. If this is specified, `crawler_name` must also be specified. Conflicts with `state`.
            * `crawlerName` (`pulumi.Input[str]`) - The name of the crawler to watch. If this is specified, `crawl_state` must also be specified. Conflicts with `job_name`.
            * `jobName` (`pulumi.Input[str]`) - The name of the job to watch. If this is specified, `state` must also be specified. Conflicts with `crawler_name`.
            * `logicalOperator` (`pulumi.Input[str]`) - A logical operator. Defaults to `EQUALS`.
            * `state` (`pulumi.Input[str]`) - The condition job state. Currently, the values supported are `SUCCEEDED`, `STOPPED`, `TIMEOUT` and `FAILED`. If this is specified, `job_name` must also be specified. Conflicts with `crawler_state`.

          * `logical` (`pulumi.Input[str]`) - How to handle multiple conditions. Defaults to `AND`. Valid values are `AND` or `ANY`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["actions"] = actions
        __props__["arn"] = arn
        __props__["description"] = description
        __props__["enabled"] = enabled
        __props__["name"] = name
        __props__["predicate"] = predicate
        __props__["schedule"] = schedule
        __props__["tags"] = tags
        __props__["type"] = type
        __props__["workflow_name"] = workflow_name
        return Trigger(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

