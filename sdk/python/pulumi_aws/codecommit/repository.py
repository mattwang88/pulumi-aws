# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Repository(pulumi.CustomResource):
    """
    Provides a CodeCommit Repository Resource.
    
    ~> **NOTE on CodeCommit Availability**: The CodeCommit is not yet rolled out
    in all regions - available regions are listed
    [the AWS Docs](https://docs.aws.amazon.com/general/latest/gr/rande.html#codecommit_region).
    """
    def __init__(__self__, __name__, __opts__=None, default_branch=None, description=None, repository_name=None):
        """Create a Repository resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if default_branch and not isinstance(default_branch, basestring):
            raise TypeError('Expected property default_branch to be a basestring')
        __self__.default_branch = default_branch
        """
        The default branch of the repository. The branch specified here needs to exist.
        """
        __props__['defaultBranch'] = default_branch

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        The description of the repository. This needs to be less than 1000 characters
        """
        __props__['description'] = description

        if not repository_name:
            raise TypeError('Missing required property repository_name')
        elif not isinstance(repository_name, basestring):
            raise TypeError('Expected property repository_name to be a basestring')
        __self__.repository_name = repository_name
        """
        The name for the repository. This needs to be less than 100 characters.
        """
        __props__['repositoryName'] = repository_name

        __self__.arn = pulumi.runtime.UNKNOWN
        """
        The ARN of the repository
        """
        __self__.clone_url_http = pulumi.runtime.UNKNOWN
        """
        The URL to use for cloning the repository over HTTPS.
        """
        __self__.clone_url_ssh = pulumi.runtime.UNKNOWN
        """
        The URL to use for cloning the repository over SSH.
        """
        __self__.repository_id = pulumi.runtime.UNKNOWN
        """
        The ID of the repository
        """

        super(Repository, __self__).__init__(
            'aws:codecommit/repository:Repository',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'cloneUrlHttp' in outs:
            self.clone_url_http = outs['cloneUrlHttp']
        if 'cloneUrlSsh' in outs:
            self.clone_url_ssh = outs['cloneUrlSsh']
        if 'defaultBranch' in outs:
            self.default_branch = outs['defaultBranch']
        if 'description' in outs:
            self.description = outs['description']
        if 'repositoryId' in outs:
            self.repository_id = outs['repositoryId']
        if 'repositoryName' in outs:
            self.repository_name = outs['repositoryName']
