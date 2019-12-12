// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GameLift
{
    /// <summary>
    /// Provides a Gamelift Fleet resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/gamelift_fleet.html.markdown.
    /// </summary>
    public partial class Fleet : Pulumi.CustomResource
    {
        /// <summary>
        /// Fleet ARN.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// ID of the Gamelift Build to be deployed on the fleet.
        /// </summary>
        [Output("buildId")]
        public Output<string> BuildId { get; private set; } = null!;

        /// <summary>
        /// Human-readable description of the fleet.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.
        /// </summary>
        [Output("ec2InboundPermissions")]
        public Output<ImmutableArray<Outputs.FleetEc2InboundPermissions>> Ec2InboundPermissions { get; private set; } = null!;

        /// <summary>
        /// Name of an EC2 instance type. e.g. `t2.micro`
        /// </summary>
        [Output("ec2InstanceType")]
        public Output<string> Ec2InstanceType { get; private set; } = null!;

        [Output("logPaths")]
        public Output<ImmutableArray<string>> LogPaths { get; private set; } = null!;

        /// <summary>
        /// List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to `default`.
        /// </summary>
        [Output("metricGroups")]
        public Output<ImmutableArray<string>> MetricGroups { get; private set; } = null!;

        /// <summary>
        /// The name of the fleet.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Game session protection policy to apply to all instances in this fleet. e.g. `FullProtection`. Defaults to `NoProtection`.
        /// </summary>
        [Output("newGameSessionProtectionPolicy")]
        public Output<string?> NewGameSessionProtectionPolicy { get; private set; } = null!;

        /// <summary>
        /// Operating system of the fleet's computing resources.
        /// </summary>
        [Output("operatingSystem")]
        public Output<string> OperatingSystem { get; private set; } = null!;

        /// <summary>
        /// Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.
        /// </summary>
        [Output("resourceCreationLimitPolicy")]
        public Output<Outputs.FleetResourceCreationLimitPolicy?> ResourceCreationLimitPolicy { get; private set; } = null!;

        /// <summary>
        /// Instructions for launching server processes on each instance in the fleet. See below.
        /// </summary>
        [Output("runtimeConfiguration")]
        public Output<Outputs.FleetRuntimeConfiguration?> RuntimeConfiguration { get; private set; } = null!;


        /// <summary>
        /// Create a Fleet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Fleet(string name, FleetArgs args, CustomResourceOptions? options = null)
            : base("aws:gamelift/fleet:Fleet", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Fleet(string name, Input<string> id, FleetState? state = null, CustomResourceOptions? options = null)
            : base("aws:gamelift/fleet:Fleet", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Fleet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Fleet Get(string name, Input<string> id, FleetState? state = null, CustomResourceOptions? options = null)
        {
            return new Fleet(name, id, state, options);
        }
    }

    public sealed class FleetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the Gamelift Build to be deployed on the fleet.
        /// </summary>
        [Input("buildId", required: true)]
        public Input<string> BuildId { get; set; } = null!;

        /// <summary>
        /// Human-readable description of the fleet.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("ec2InboundPermissions")]
        private InputList<Inputs.FleetEc2InboundPermissionsArgs>? _ec2InboundPermissions;

        /// <summary>
        /// Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.
        /// </summary>
        public InputList<Inputs.FleetEc2InboundPermissionsArgs> Ec2InboundPermissions
        {
            get => _ec2InboundPermissions ?? (_ec2InboundPermissions = new InputList<Inputs.FleetEc2InboundPermissionsArgs>());
            set => _ec2InboundPermissions = value;
        }

        /// <summary>
        /// Name of an EC2 instance type. e.g. `t2.micro`
        /// </summary>
        [Input("ec2InstanceType", required: true)]
        public Input<string> Ec2InstanceType { get; set; } = null!;

        [Input("metricGroups")]
        private InputList<string>? _metricGroups;

        /// <summary>
        /// List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to `default`.
        /// </summary>
        public InputList<string> MetricGroups
        {
            get => _metricGroups ?? (_metricGroups = new InputList<string>());
            set => _metricGroups = value;
        }

        /// <summary>
        /// The name of the fleet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Game session protection policy to apply to all instances in this fleet. e.g. `FullProtection`. Defaults to `NoProtection`.
        /// </summary>
        [Input("newGameSessionProtectionPolicy")]
        public Input<string>? NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.
        /// </summary>
        [Input("resourceCreationLimitPolicy")]
        public Input<Inputs.FleetResourceCreationLimitPolicyArgs>? ResourceCreationLimitPolicy { get; set; }

        /// <summary>
        /// Instructions for launching server processes on each instance in the fleet. See below.
        /// </summary>
        [Input("runtimeConfiguration")]
        public Input<Inputs.FleetRuntimeConfigurationArgs>? RuntimeConfiguration { get; set; }

        public FleetArgs()
        {
        }
    }

    public sealed class FleetState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fleet ARN.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// ID of the Gamelift Build to be deployed on the fleet.
        /// </summary>
        [Input("buildId")]
        public Input<string>? BuildId { get; set; }

        /// <summary>
        /// Human-readable description of the fleet.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("ec2InboundPermissions")]
        private InputList<Inputs.FleetEc2InboundPermissionsGetArgs>? _ec2InboundPermissions;

        /// <summary>
        /// Range of IP addresses and port settings that permit inbound traffic to access server processes running on the fleet. See below.
        /// </summary>
        public InputList<Inputs.FleetEc2InboundPermissionsGetArgs> Ec2InboundPermissions
        {
            get => _ec2InboundPermissions ?? (_ec2InboundPermissions = new InputList<Inputs.FleetEc2InboundPermissionsGetArgs>());
            set => _ec2InboundPermissions = value;
        }

        /// <summary>
        /// Name of an EC2 instance type. e.g. `t2.micro`
        /// </summary>
        [Input("ec2InstanceType")]
        public Input<string>? Ec2InstanceType { get; set; }

        [Input("logPaths")]
        private InputList<string>? _logPaths;
        public InputList<string> LogPaths
        {
            get => _logPaths ?? (_logPaths = new InputList<string>());
            set => _logPaths = value;
        }

        [Input("metricGroups")]
        private InputList<string>? _metricGroups;

        /// <summary>
        /// List of names of metric groups to add this fleet to. A metric group tracks metrics across all fleets in the group. Defaults to `default`.
        /// </summary>
        public InputList<string> MetricGroups
        {
            get => _metricGroups ?? (_metricGroups = new InputList<string>());
            set => _metricGroups = value;
        }

        /// <summary>
        /// The name of the fleet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Game session protection policy to apply to all instances in this fleet. e.g. `FullProtection`. Defaults to `NoProtection`.
        /// </summary>
        [Input("newGameSessionProtectionPolicy")]
        public Input<string>? NewGameSessionProtectionPolicy { get; set; }

        /// <summary>
        /// Operating system of the fleet's computing resources.
        /// </summary>
        [Input("operatingSystem")]
        public Input<string>? OperatingSystem { get; set; }

        /// <summary>
        /// Policy that limits the number of game sessions an individual player can create over a span of time for this fleet. See below.
        /// </summary>
        [Input("resourceCreationLimitPolicy")]
        public Input<Inputs.FleetResourceCreationLimitPolicyGetArgs>? ResourceCreationLimitPolicy { get; set; }

        /// <summary>
        /// Instructions for launching server processes on each instance in the fleet. See below.
        /// </summary>
        [Input("runtimeConfiguration")]
        public Input<Inputs.FleetRuntimeConfigurationGetArgs>? RuntimeConfiguration { get; set; }

        public FleetState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class FleetEc2InboundPermissionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Starting value for a range of allowed port numbers.
        /// </summary>
        [Input("fromPort", required: true)]
        public Input<int> FromPort { get; set; } = null!;

        /// <summary>
        /// Range of allowed IP addresses expressed in CIDR notation. e.g. `000.000.000.000/[subnet mask]` or `0.0.0.0/[subnet mask]`.
        /// </summary>
        [Input("ipRange", required: true)]
        public Input<string> IpRange { get; set; } = null!;

        /// <summary>
        /// Network communication protocol used by the fleet. e.g. `TCP` or `UDP`
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than `from_port`.
        /// </summary>
        [Input("toPort", required: true)]
        public Input<int> ToPort { get; set; } = null!;

        public FleetEc2InboundPermissionsArgs()
        {
        }
    }

    public sealed class FleetEc2InboundPermissionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Starting value for a range of allowed port numbers.
        /// </summary>
        [Input("fromPort", required: true)]
        public Input<int> FromPort { get; set; } = null!;

        /// <summary>
        /// Range of allowed IP addresses expressed in CIDR notation. e.g. `000.000.000.000/[subnet mask]` or `0.0.0.0/[subnet mask]`.
        /// </summary>
        [Input("ipRange", required: true)]
        public Input<string> IpRange { get; set; } = null!;

        /// <summary>
        /// Network communication protocol used by the fleet. e.g. `TCP` or `UDP`
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than `from_port`.
        /// </summary>
        [Input("toPort", required: true)]
        public Input<int> ToPort { get; set; } = null!;

        public FleetEc2InboundPermissionsGetArgs()
        {
        }
    }

    public sealed class FleetResourceCreationLimitPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum number of game sessions that an individual can create during the policy period.
        /// </summary>
        [Input("newGameSessionsPerCreator")]
        public Input<int>? NewGameSessionsPerCreator { get; set; }

        /// <summary>
        /// Time span used in evaluating the resource creation limit policy.
        /// </summary>
        [Input("policyPeriodInMinutes")]
        public Input<int>? PolicyPeriodInMinutes { get; set; }

        public FleetResourceCreationLimitPolicyArgs()
        {
        }
    }

    public sealed class FleetResourceCreationLimitPolicyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum number of game sessions that an individual can create during the policy period.
        /// </summary>
        [Input("newGameSessionsPerCreator")]
        public Input<int>? NewGameSessionsPerCreator { get; set; }

        /// <summary>
        /// Time span used in evaluating the resource creation limit policy.
        /// </summary>
        [Input("policyPeriodInMinutes")]
        public Input<int>? PolicyPeriodInMinutes { get; set; }

        public FleetResourceCreationLimitPolicyGetArgs()
        {
        }
    }

    public sealed class FleetRuntimeConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum amount of time (in seconds) that a game session can remain in status `ACTIVATING`.
        /// </summary>
        [Input("gameSessionActivationTimeoutSeconds")]
        public Input<int>? GameSessionActivationTimeoutSeconds { get; set; }

        /// <summary>
        /// Maximum number of game sessions with status `ACTIVATING` to allow on an instance simultaneously. 
        /// </summary>
        [Input("maxConcurrentGameSessionActivations")]
        public Input<int>? MaxConcurrentGameSessionActivations { get; set; }

        [Input("serverProcesses")]
        private InputList<FleetRuntimeConfigurationServerProcessesArgs>? _serverProcesses;

        /// <summary>
        /// Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.
        /// </summary>
        public InputList<FleetRuntimeConfigurationServerProcessesArgs> ServerProcesses
        {
            get => _serverProcesses ?? (_serverProcesses = new InputList<FleetRuntimeConfigurationServerProcessesArgs>());
            set => _serverProcesses = value;
        }

        public FleetRuntimeConfigurationArgs()
        {
        }
    }

    public sealed class FleetRuntimeConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Maximum amount of time (in seconds) that a game session can remain in status `ACTIVATING`.
        /// </summary>
        [Input("gameSessionActivationTimeoutSeconds")]
        public Input<int>? GameSessionActivationTimeoutSeconds { get; set; }

        /// <summary>
        /// Maximum number of game sessions with status `ACTIVATING` to allow on an instance simultaneously. 
        /// </summary>
        [Input("maxConcurrentGameSessionActivations")]
        public Input<int>? MaxConcurrentGameSessionActivations { get; set; }

        [Input("serverProcesses")]
        private InputList<FleetRuntimeConfigurationServerProcessesGetArgs>? _serverProcesses;

        /// <summary>
        /// Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.
        /// </summary>
        public InputList<FleetRuntimeConfigurationServerProcessesGetArgs> ServerProcesses
        {
            get => _serverProcesses ?? (_serverProcesses = new InputList<FleetRuntimeConfigurationServerProcessesGetArgs>());
            set => _serverProcesses = value;
        }

        public FleetRuntimeConfigurationGetArgs()
        {
        }
    }

    public sealed class FleetRuntimeConfigurationServerProcessesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of server processes using this configuration to run concurrently on an instance.
        /// </summary>
        [Input("concurrentExecutions", required: true)]
        public Input<int> ConcurrentExecutions { get; set; } = null!;

        /// <summary>
        /// Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances `C:\game`, and for Linux instances `/local/game`.
        /// </summary>
        [Input("launchPath", required: true)]
        public Input<string> LaunchPath { get; set; } = null!;

        /// <summary>
        /// Optional list of parameters to pass to the server executable on launch.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        public FleetRuntimeConfigurationServerProcessesArgs()
        {
        }
    }

    public sealed class FleetRuntimeConfigurationServerProcessesGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of server processes using this configuration to run concurrently on an instance.
        /// </summary>
        [Input("concurrentExecutions", required: true)]
        public Input<int> ConcurrentExecutions { get; set; } = null!;

        /// <summary>
        /// Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances `C:\game`, and for Linux instances `/local/game`.
        /// </summary>
        [Input("launchPath", required: true)]
        public Input<string> LaunchPath { get; set; } = null!;

        /// <summary>
        /// Optional list of parameters to pass to the server executable on launch.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        public FleetRuntimeConfigurationServerProcessesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class FleetEc2InboundPermissions
    {
        /// <summary>
        /// Starting value for a range of allowed port numbers.
        /// </summary>
        public readonly int FromPort;
        /// <summary>
        /// Range of allowed IP addresses expressed in CIDR notation. e.g. `000.000.000.000/[subnet mask]` or `0.0.0.0/[subnet mask]`.
        /// </summary>
        public readonly string IpRange;
        /// <summary>
        /// Network communication protocol used by the fleet. e.g. `TCP` or `UDP`
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than `from_port`.
        /// </summary>
        public readonly int ToPort;

        [OutputConstructor]
        private FleetEc2InboundPermissions(
            int fromPort,
            string ipRange,
            string protocol,
            int toPort)
        {
            FromPort = fromPort;
            IpRange = ipRange;
            Protocol = protocol;
            ToPort = toPort;
        }
    }

    [OutputType]
    public sealed class FleetResourceCreationLimitPolicy
    {
        /// <summary>
        /// Maximum number of game sessions that an individual can create during the policy period.
        /// </summary>
        public readonly int? NewGameSessionsPerCreator;
        /// <summary>
        /// Time span used in evaluating the resource creation limit policy.
        /// </summary>
        public readonly int? PolicyPeriodInMinutes;

        [OutputConstructor]
        private FleetResourceCreationLimitPolicy(
            int? newGameSessionsPerCreator,
            int? policyPeriodInMinutes)
        {
            NewGameSessionsPerCreator = newGameSessionsPerCreator;
            PolicyPeriodInMinutes = policyPeriodInMinutes;
        }
    }

    [OutputType]
    public sealed class FleetRuntimeConfiguration
    {
        /// <summary>
        /// Maximum amount of time (in seconds) that a game session can remain in status `ACTIVATING`.
        /// </summary>
        public readonly int? GameSessionActivationTimeoutSeconds;
        /// <summary>
        /// Maximum number of game sessions with status `ACTIVATING` to allow on an instance simultaneously. 
        /// </summary>
        public readonly int? MaxConcurrentGameSessionActivations;
        /// <summary>
        /// Collection of server process configurations that describe which server processes to run on each instance in a fleet. See below.
        /// </summary>
        public readonly ImmutableArray<FleetRuntimeConfigurationServerProcesses> ServerProcesses;

        [OutputConstructor]
        private FleetRuntimeConfiguration(
            int? gameSessionActivationTimeoutSeconds,
            int? maxConcurrentGameSessionActivations,
            ImmutableArray<FleetRuntimeConfigurationServerProcesses> serverProcesses)
        {
            GameSessionActivationTimeoutSeconds = gameSessionActivationTimeoutSeconds;
            MaxConcurrentGameSessionActivations = maxConcurrentGameSessionActivations;
            ServerProcesses = serverProcesses;
        }
    }

    [OutputType]
    public sealed class FleetRuntimeConfigurationServerProcesses
    {
        /// <summary>
        /// Number of server processes using this configuration to run concurrently on an instance.
        /// </summary>
        public readonly int ConcurrentExecutions;
        /// <summary>
        /// Location of the server executable in a game build. All game builds are installed on instances at the root : for Windows instances `C:\game`, and for Linux instances `/local/game`.
        /// </summary>
        public readonly string LaunchPath;
        /// <summary>
        /// Optional list of parameters to pass to the server executable on launch.
        /// </summary>
        public readonly string? Parameters;

        [OutputConstructor]
        private FleetRuntimeConfigurationServerProcesses(
            int concurrentExecutions,
            string launchPath,
            string? parameters)
        {
            ConcurrentExecutions = concurrentExecutions;
            LaunchPath = launchPath;
            Parameters = parameters;
        }
    }
    }
}
