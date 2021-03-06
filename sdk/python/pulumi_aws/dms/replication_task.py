# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class ReplicationTask(pulumi.CustomResource):
    cdc_start_time: pulumi.Output[str]
    """
    The Unix timestamp integer for the start of the Change Data Capture (CDC) operation.
    """
    migration_type: pulumi.Output[str]
    """
    The migration type. Can be one of `full-load | cdc | full-load-and-cdc`.
    """
    replication_instance_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) of the replication instance.
    """
    replication_task_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) for the replication task.
    """
    replication_task_id: pulumi.Output[str]
    """
    The replication task identifier.
    """
    replication_task_settings: pulumi.Output[str]
    """
    An escaped JSON string that contains the task settings. For a complete list of task settings, see [Task Settings for AWS Database Migration Service Tasks](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.html).
    """
    source_endpoint_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) string that uniquely identifies the source endpoint.
    """
    table_mappings: pulumi.Output[str]
    """
    An escaped JSON string that contains the table mappings. For information on table mapping see [Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.html)
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    target_endpoint_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) string that uniquely identifies the target endpoint.
    """
    def __init__(__self__, resource_name, opts=None, cdc_start_time=None, migration_type=None, replication_instance_arn=None, replication_task_id=None, replication_task_settings=None, source_endpoint_arn=None, table_mappings=None, tags=None, target_endpoint_arn=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a DMS (Data Migration Service) replication task resource. DMS replication tasks can be created, updated, deleted, and imported.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/dms_replication_task.html.markdown.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cdc_start_time: The Unix timestamp integer for the start of the Change Data Capture (CDC) operation.
        :param pulumi.Input[str] migration_type: The migration type. Can be one of `full-load | cdc | full-load-and-cdc`.
        :param pulumi.Input[str] replication_instance_arn: The Amazon Resource Name (ARN) of the replication instance.
        :param pulumi.Input[str] replication_task_id: The replication task identifier.
        :param pulumi.Input[str] replication_task_settings: An escaped JSON string that contains the task settings. For a complete list of task settings, see [Task Settings for AWS Database Migration Service Tasks](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.html).
        :param pulumi.Input[str] source_endpoint_arn: The Amazon Resource Name (ARN) string that uniquely identifies the source endpoint.
        :param pulumi.Input[str] table_mappings: An escaped JSON string that contains the table mappings. For information on table mapping see [Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.html)
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] target_endpoint_arn: The Amazon Resource Name (ARN) string that uniquely identifies the target endpoint.
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

            __props__['cdc_start_time'] = cdc_start_time
            if migration_type is None:
                raise TypeError("Missing required property 'migration_type'")
            __props__['migration_type'] = migration_type
            if replication_instance_arn is None:
                raise TypeError("Missing required property 'replication_instance_arn'")
            __props__['replication_instance_arn'] = replication_instance_arn
            if replication_task_id is None:
                raise TypeError("Missing required property 'replication_task_id'")
            __props__['replication_task_id'] = replication_task_id
            __props__['replication_task_settings'] = replication_task_settings
            if source_endpoint_arn is None:
                raise TypeError("Missing required property 'source_endpoint_arn'")
            __props__['source_endpoint_arn'] = source_endpoint_arn
            if table_mappings is None:
                raise TypeError("Missing required property 'table_mappings'")
            __props__['table_mappings'] = table_mappings
            __props__['tags'] = tags
            if target_endpoint_arn is None:
                raise TypeError("Missing required property 'target_endpoint_arn'")
            __props__['target_endpoint_arn'] = target_endpoint_arn
            __props__['replication_task_arn'] = None
        super(ReplicationTask, __self__).__init__(
            'aws:dms/replicationTask:ReplicationTask',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, cdc_start_time=None, migration_type=None, replication_instance_arn=None, replication_task_arn=None, replication_task_id=None, replication_task_settings=None, source_endpoint_arn=None, table_mappings=None, tags=None, target_endpoint_arn=None):
        """
        Get an existing ReplicationTask resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cdc_start_time: The Unix timestamp integer for the start of the Change Data Capture (CDC) operation.
        :param pulumi.Input[str] migration_type: The migration type. Can be one of `full-load | cdc | full-load-and-cdc`.
        :param pulumi.Input[str] replication_instance_arn: The Amazon Resource Name (ARN) of the replication instance.
        :param pulumi.Input[str] replication_task_arn: The Amazon Resource Name (ARN) for the replication task.
        :param pulumi.Input[str] replication_task_id: The replication task identifier.
        :param pulumi.Input[str] replication_task_settings: An escaped JSON string that contains the task settings. For a complete list of task settings, see [Task Settings for AWS Database Migration Service Tasks](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TaskSettings.html).
        :param pulumi.Input[str] source_endpoint_arn: The Amazon Resource Name (ARN) string that uniquely identifies the source endpoint.
        :param pulumi.Input[str] table_mappings: An escaped JSON string that contains the table mappings. For information on table mapping see [Using Table Mapping with an AWS Database Migration Service Task to Select and Filter Data](http://docs.aws.amazon.com/dms/latest/userguide/CHAP_Tasks.CustomizingTasks.TableMapping.html)
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] target_endpoint_arn: The Amazon Resource Name (ARN) string that uniquely identifies the target endpoint.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["cdc_start_time"] = cdc_start_time
        __props__["migration_type"] = migration_type
        __props__["replication_instance_arn"] = replication_instance_arn
        __props__["replication_task_arn"] = replication_task_arn
        __props__["replication_task_id"] = replication_task_id
        __props__["replication_task_settings"] = replication_task_settings
        __props__["source_endpoint_arn"] = source_endpoint_arn
        __props__["table_mappings"] = table_mappings
        __props__["tags"] = tags
        __props__["target_endpoint_arn"] = target_endpoint_arn
        return ReplicationTask(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

