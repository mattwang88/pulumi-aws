# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class Environment(pulumi.CustomResource):
    """
    Provides an Elastic Beanstalk Environment Resource. Elastic Beanstalk allows
    you to deploy and manage applications in the AWS cloud without worrying about
    the infrastructure that runs those applications.
    
    Environments are often things such as `development`, `integration`, or
    `production`.
    """
    def __init__(__self__, __name__, __opts__=None, application=None, cname_prefix=None, description=None, name=None, poll_interval=None, settings=None, solution_stack_name=None, tags=None, template_name=None, tier=None, version=None, wait_for_ready_timeout=None):
        """Create a Environment resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not application:
            raise TypeError('Missing required property application')
        elif not isinstance(application, basestring):
            raise TypeError('Expected property application to be a basestring')
        __self__.application = application
        """
        Name of the application that contains the version
        to be deployed
        """
        __props__['application'] = application

        if cname_prefix and not isinstance(cname_prefix, basestring):
            raise TypeError('Expected property cname_prefix to be a basestring')
        __self__.cname_prefix = cname_prefix
        """
        Prefix to use for the fully qualified DNS name of
        the Environment.
        """
        __props__['cnamePrefix'] = cname_prefix

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Short description of the Environment
        """
        __props__['description'] = description

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        A unique name for this Environment. This name is used
        in the application URL
        """
        __props__['name'] = name

        if poll_interval and not isinstance(poll_interval, basestring):
            raise TypeError('Expected property poll_interval to be a basestring')
        __self__.poll_interval = poll_interval
        """
        The time between polling the AWS API to
        check if changes have been applied. Use this to adjust the rate of API calls
        for any `create` or `update` action. Minimum `10s`, maximum `180s`. Omit this to
        use the default behavior, which is an exponential backoff
        """
        __props__['pollInterval'] = poll_interval

        if settings and not isinstance(settings, list):
            raise TypeError('Expected property settings to be a list')
        __self__.settings = settings
        """
        Option settings to configure the new Environment. These
        override specific values that are set as defaults. The format is detailed
        below in [Option Settings](#option-settings)
        """
        __props__['settings'] = settings

        if solution_stack_name and not isinstance(solution_stack_name, basestring):
            raise TypeError('Expected property solution_stack_name to be a basestring')
        __self__.solution_stack_name = solution_stack_name
        """
        A solution stack to base your environment
        off of. Example stacks can be found in the [Amazon API documentation][1]
        """
        __props__['solutionStackName'] = solution_stack_name

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A set of tags to apply to the Environment.
        """
        __props__['tags'] = tags

        if template_name and not isinstance(template_name, basestring):
            raise TypeError('Expected property template_name to be a basestring')
        __self__.template_name = template_name
        """
        The name of the Elastic Beanstalk Configuration
        template to use in deployment
        """
        __props__['templateName'] = template_name

        if tier and not isinstance(tier, basestring):
            raise TypeError('Expected property tier to be a basestring')
        __self__.tier = tier
        """
        Elastic Beanstalk Environment tier. Valid values are `Worker`
        or `WebServer`. If tier is left blank `WebServer` will be used.
        """
        __props__['tier'] = tier

        if version and not isinstance(version, basestring):
            raise TypeError('Expected property version to be a basestring')
        __self__.version = version
        """
        The name of the Elastic Beanstalk Application Version
        to use in deployment.
        """
        __props__['version'] = version

        if wait_for_ready_timeout and not isinstance(wait_for_ready_timeout, basestring):
            raise TypeError('Expected property wait_for_ready_timeout to be a basestring')
        __self__.wait_for_ready_timeout = wait_for_ready_timeout
        """
        The maximum
        [duration](https://golang.org/pkg/time/#ParseDuration) that Terraform should
        wait for an Elastic Beanstalk Environment to be in a ready state before timing
        out.
        """
        __props__['waitForReadyTimeout'] = wait_for_ready_timeout

        __self__.all_settings = pulumi.runtime.UNKNOWN
        """
        List of all option settings configured in the Environment. These
        are a combination of default settings and their overrides from `setting` in
        the configuration.
        """
        __self__.arn = pulumi.runtime.UNKNOWN
        __self__.autoscaling_groups = pulumi.runtime.UNKNOWN
        """
        The autoscaling groups used by this environment.
        """
        __self__.cname = pulumi.runtime.UNKNOWN
        """
        Fully qualified DNS name for the Environment.
        """
        __self__.instances = pulumi.runtime.UNKNOWN
        """
        Instances used by this environment.
        """
        __self__.launch_configurations = pulumi.runtime.UNKNOWN
        """
        Launch configurations in use by this environment.
        """
        __self__.load_balancers = pulumi.runtime.UNKNOWN
        """
        Elastic load balancers in use by this environment.
        """
        __self__.queues = pulumi.runtime.UNKNOWN
        """
        SQS queues in use by this environment.
        """
        __self__.triggers = pulumi.runtime.UNKNOWN
        """
        Autoscaling triggers in use by this environment.
        """

        super(Environment, __self__).__init__(
            'aws:elasticbeanstalk/environment:Environment',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'allSettings' in outs:
            self.all_settings = outs['allSettings']
        if 'application' in outs:
            self.application = outs['application']
        if 'arn' in outs:
            self.arn = outs['arn']
        if 'autoscalingGroups' in outs:
            self.autoscaling_groups = outs['autoscalingGroups']
        if 'cname' in outs:
            self.cname = outs['cname']
        if 'cnamePrefix' in outs:
            self.cname_prefix = outs['cnamePrefix']
        if 'description' in outs:
            self.description = outs['description']
        if 'instances' in outs:
            self.instances = outs['instances']
        if 'launchConfigurations' in outs:
            self.launch_configurations = outs['launchConfigurations']
        if 'loadBalancers' in outs:
            self.load_balancers = outs['loadBalancers']
        if 'name' in outs:
            self.name = outs['name']
        if 'pollInterval' in outs:
            self.poll_interval = outs['pollInterval']
        if 'queues' in outs:
            self.queues = outs['queues']
        if 'settings' in outs:
            self.settings = outs['settings']
        if 'solutionStackName' in outs:
            self.solution_stack_name = outs['solutionStackName']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'templateName' in outs:
            self.template_name = outs['templateName']
        if 'tier' in outs:
            self.tier = outs['tier']
        if 'triggers' in outs:
            self.triggers = outs['triggers']
        if 'version' in outs:
            self.version = outs['version']
        if 'waitForReadyTimeout' in outs:
            self.wait_for_ready_timeout = outs['waitForReadyTimeout']
