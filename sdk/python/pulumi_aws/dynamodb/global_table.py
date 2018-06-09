# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GlobalTable(pulumi.CustomResource):
    """
    Provides a resource to manage a DynamoDB Global Table. These are layered on top of existing DynamoDB Tables.
    
    ~> Note: There are many restrictions before you can properly create DynamoDB Global Tables in multiple regions. See the [AWS DynamoDB Global Table Requirements](http://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables_reqs_bestpractices.html) for more information.
    """
    def __init__(__self__, __name__, __opts__=None, name=None, replicas=None):
        """Create a GlobalTable resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        The name of the global table. Must match underlying DynamoDB Table names in all regions.
        """
        __props__['name'] = name

        if not replicas:
            raise TypeError('Missing required property replicas')
        elif not isinstance(replicas, list):
            raise TypeError('Expected property replicas to be a list')
        __self__.replicas = replicas
        """
        Underlying DynamoDB Table. At least 1 replica must be defined. See below.
        """
        __props__['replicas'] = replicas

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The ARN of the DynamoDB Global Table
        """

        super(GlobalTable, __self__).__init__(
            'aws:dynamodb/globalTable:GlobalTable',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'name' in outs:
            self.name = outs['name']
        if 'replicas' in outs:
            self.replicas = outs['replicas']
