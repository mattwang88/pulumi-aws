# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class CatalogTable(pulumi.CustomResource):
    """
    Provides a Glue Catalog Table Resource. You can refer to the [Glue Developer Guide](http://docs.aws.amazon.com/glue/latest/dg/populate-data-catalog.html) for a full explanation of the Glue Data Catalog functionality.
    """
    def __init__(__self__, __name__, __opts__=None, catalog_id=None, database_name=None, description=None, name=None, owner=None, parameters=None, partition_keys=None, retention=None, storage_descriptor=None, table_type=None, view_expanded_text=None, view_original_text=None):
        """Create a CatalogTable resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if catalog_id and not isinstance(catalog_id, basestring):
            raise TypeError('Expected property catalog_id to be a basestring')
        __self__.catalog_id = catalog_id
        """
        ID of the Glue Catalog and database to create the table in. If omitted, this defaults to the AWS Account ID plus the database name.
        """
        __props__['catalogId'] = catalog_id

        if not database_name:
            raise TypeError('Missing required property database_name')
        elif not isinstance(database_name, basestring):
            raise TypeError('Expected property database_name to be a basestring')
        __self__.database_name = database_name
        """
        Name of the metadata database where the table metadata resides. For Hive compatibility, this must be all lowercase.
        """
        __props__['databaseName'] = database_name

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Description of the table.
        """
        __props__['description'] = description

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        Name of the SerDe.
        """
        __props__['name'] = name

        if owner and not isinstance(owner, basestring):
            raise TypeError('Expected property owner to be a basestring')
        __self__.owner = owner
        """
        Owner of the table.
        """
        __props__['owner'] = owner

        if parameters and not isinstance(parameters, dict):
            raise TypeError('Expected property parameters to be a dict')
        __self__.parameters = parameters
        """
        Usually the class that implements the SerDe. An example is: org.apache.hadoop.hive.serde2.columnar.ColumnarSerDe.
        """
        __props__['parameters'] = parameters

        if partition_keys and not isinstance(partition_keys, list):
            raise TypeError('Expected property partition_keys to be a list')
        __self__.partition_keys = partition_keys
        """
        A list of columns by which the table is partitioned. Only primitive types are supported as partition keys.
        """
        __props__['partitionKeys'] = partition_keys

        if retention and not isinstance(retention, int):
            raise TypeError('Expected property retention to be a int')
        __self__.retention = retention
        """
        Retention time for this table.
        """
        __props__['retention'] = retention

        if storage_descriptor and not isinstance(storage_descriptor, dict):
            raise TypeError('Expected property storage_descriptor to be a dict')
        __self__.storage_descriptor = storage_descriptor
        """
        A [storage descriptor](#storage_descriptor) object containing information about the physical storage of this table. You can refer to the [Glue Developer Guide](https://docs.aws.amazon.com/glue/latest/dg/aws-glue-api-catalog-tables.html#aws-glue-api-catalog-tables-StorageDescriptor) for a full explanation of this object.
        """
        __props__['storageDescriptor'] = storage_descriptor

        if table_type and not isinstance(table_type, basestring):
            raise TypeError('Expected property table_type to be a basestring')
        __self__.table_type = table_type
        """
        The type of this table (EXTERNAL_TABLE, VIRTUAL_VIEW, etc.).
        """
        __props__['tableType'] = table_type

        if view_expanded_text and not isinstance(view_expanded_text, basestring):
            raise TypeError('Expected property view_expanded_text to be a basestring')
        __self__.view_expanded_text = view_expanded_text
        """
        If the table is a view, the expanded text of the view; otherwise null.
        """
        __props__['viewExpandedText'] = view_expanded_text

        if view_original_text and not isinstance(view_original_text, basestring):
            raise TypeError('Expected property view_original_text to be a basestring')
        __self__.view_original_text = view_original_text
        """
        If the table is a view, the original text of the view; otherwise null.
        """
        __props__['viewOriginalText'] = view_original_text

        super(CatalogTable, __self__).__init__(
            'aws:glue/catalogTable:CatalogTable',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'catalogId' in outs:
            self.catalog_id = outs['catalogId']
        if 'databaseName' in outs:
            self.database_name = outs['databaseName']
        if 'description' in outs:
            self.description = outs['description']
        if 'name' in outs:
            self.name = outs['name']
        if 'owner' in outs:
            self.owner = outs['owner']
        if 'parameters' in outs:
            self.parameters = outs['parameters']
        if 'partitionKeys' in outs:
            self.partition_keys = outs['partitionKeys']
        if 'retention' in outs:
            self.retention = outs['retention']
        if 'storageDescriptor' in outs:
            self.storage_descriptor = outs['storageDescriptor']
        if 'tableType' in outs:
            self.table_type = outs['tableType']
        if 'viewExpandedText' in outs:
            self.view_expanded_text = outs['viewExpandedText']
        if 'viewOriginalText' in outs:
            self.view_original_text = outs['viewOriginalText']
