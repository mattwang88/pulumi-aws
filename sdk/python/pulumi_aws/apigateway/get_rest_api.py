# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetRestApiResult(object):
    """
    A collection of values returned by getRestApi.
    """
    def __init__(__self__, root_resource_id=None):
        if not root_resource_id:
            raise TypeError('Missing required argument root_resource_id')
        elif not isinstance(root_resource_id, basestring):
            raise TypeError('Expected argument root_resource_id to be a basestring')
        __self__.root_resource_id = root_resource_id
        """
        Set to the ID of the API Gateway Resource on the found REST API where the route matches '/'.
        """

def get_rest_api(name=None):
    """
    Use this data source to get the id and root_resource_id of a REST API in
    API Gateway. To fetch the REST API you must provide a name to match against. 
    As there is no unique name constraint on REST APIs this data source will 
    error if there is more than one match.
    """
    __args__ = dict()

    __args__['name'] = name
    __ret__ = pulumi.runtime.invoke('aws:apigateway/getRestApi:getRestApi', __args__)

    return GetRestApiResult(
        root_resource_id=__ret__['rootResourceId'])
