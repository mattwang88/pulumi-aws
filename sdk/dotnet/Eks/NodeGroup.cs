// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Eks
{
    /// <summary>
    /// Manages an EKS Node Group, which can provision and optionally update an Auto Scaling Group of Kubernetes worker nodes compatible with EKS. Additional documentation about this functionality can be found in the [EKS User Guide](https://docs.aws.amazon.com/eks/latest/userguide/managed-node-groups.html).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/eks_node_group.html.markdown.
    /// </summary>
    public partial class NodeGroup : Pulumi.CustomResource
    {
        [Output("amiType")]
        public Output<string> AmiType { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the EKS Node Group.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Name of the EKS Cluster.
        /// </summary>
        [Output("clusterName")]
        public Output<string> ClusterName { get; private set; } = null!;

        [Output("diskSize")]
        public Output<int> DiskSize { get; private set; } = null!;

        [Output("instanceTypes")]
        public Output<string> InstanceTypes { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of the EKS Node Group.
        /// </summary>
        [Output("nodeGroupName")]
        public Output<string> NodeGroupName { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
        /// </summary>
        [Output("nodeRoleArn")]
        public Output<string> NodeRoleArn { get; private set; } = null!;

        /// <summary>
        /// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
        /// </summary>
        [Output("releaseVersion")]
        public Output<string> ReleaseVersion { get; private set; } = null!;

        /// <summary>
        /// Configuration block with remote access settings. Detailed below.
        /// </summary>
        [Output("remoteAccess")]
        public Output<Outputs.NodeGroupRemoteAccess?> RemoteAccess { get; private set; } = null!;

        /// <summary>
        /// List of objects containing information about underlying resources.
        /// </summary>
        [Output("resources")]
        public Output<ImmutableArray<Outputs.NodeGroupResources>> Resources { get; private set; } = null!;

        /// <summary>
        /// Configuration block with scaling settings. Detailed below.
        /// </summary>
        [Output("scalingConfig")]
        public Output<Outputs.NodeGroupScalingConfig> ScalingConfig { get; private set; } = null!;

        /// <summary>
        /// Status of the EKS Node Group.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
        /// </summary>
        [Output("subnetIds")]
        public Output<ImmutableArray<string>> SubnetIds { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a NodeGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NodeGroup(string name, NodeGroupArgs args, CustomResourceOptions? options = null)
            : base("aws:eks/nodeGroup:NodeGroup", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private NodeGroup(string name, Input<string> id, NodeGroupState? state = null, CustomResourceOptions? options = null)
            : base("aws:eks/nodeGroup:NodeGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NodeGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NodeGroup Get(string name, Input<string> id, NodeGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new NodeGroup(name, id, state, options);
        }
    }

    public sealed class NodeGroupArgs : Pulumi.ResourceArgs
    {
        [Input("amiType")]
        public Input<string>? AmiType { get; set; }

        /// <summary>
        /// Name of the EKS Cluster.
        /// </summary>
        [Input("clusterName", required: true)]
        public Input<string> ClusterName { get; set; } = null!;

        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("instanceTypes")]
        public Input<string>? InstanceTypes { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Key-value mapping of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the EKS Node Group.
        /// </summary>
        [Input("nodeGroupName")]
        public Input<string>? NodeGroupName { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
        /// </summary>
        [Input("nodeRoleArn", required: true)]
        public Input<string> NodeRoleArn { get; set; } = null!;

        /// <summary>
        /// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
        /// </summary>
        [Input("releaseVersion")]
        public Input<string>? ReleaseVersion { get; set; }

        /// <summary>
        /// Configuration block with remote access settings. Detailed below.
        /// </summary>
        [Input("remoteAccess")]
        public Input<Inputs.NodeGroupRemoteAccessArgs>? RemoteAccess { get; set; }

        /// <summary>
        /// Configuration block with scaling settings. Detailed below.
        /// </summary>
        [Input("scalingConfig", required: true)]
        public Input<Inputs.NodeGroupScalingConfigArgs> ScalingConfig { get; set; } = null!;

        [Input("subnetIds", required: true)]
        private InputList<string>? _subnetIds;

        /// <summary>
        /// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public NodeGroupArgs()
        {
        }
    }

    public sealed class NodeGroupState : Pulumi.ResourceArgs
    {
        [Input("amiType")]
        public Input<string>? AmiType { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the EKS Node Group.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Name of the EKS Cluster.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        [Input("instanceTypes")]
        public Input<string>? InstanceTypes { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Key-value mapping of Kubernetes labels. Only labels that are applied with the EKS API are managed by this argument. Other Kubernetes labels applied to the EKS Node Group will not be managed.
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of the EKS Node Group.
        /// </summary>
        [Input("nodeGroupName")]
        public Input<string>? NodeGroupName { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the IAM Role that provides permissions for the EKS Node Group.
        /// </summary>
        [Input("nodeRoleArn")]
        public Input<string>? NodeRoleArn { get; set; }

        /// <summary>
        /// AMI version of the EKS Node Group. Defaults to latest version for Kubernetes version.
        /// </summary>
        [Input("releaseVersion")]
        public Input<string>? ReleaseVersion { get; set; }

        /// <summary>
        /// Configuration block with remote access settings. Detailed below.
        /// </summary>
        [Input("remoteAccess")]
        public Input<Inputs.NodeGroupRemoteAccessGetArgs>? RemoteAccess { get; set; }

        [Input("resources")]
        private InputList<Inputs.NodeGroupResourcesGetArgs>? _resources;

        /// <summary>
        /// List of objects containing information about underlying resources.
        /// </summary>
        public InputList<Inputs.NodeGroupResourcesGetArgs> Resources
        {
            get => _resources ?? (_resources = new InputList<Inputs.NodeGroupResourcesGetArgs>());
            set => _resources = value;
        }

        /// <summary>
        /// Configuration block with scaling settings. Detailed below.
        /// </summary>
        [Input("scalingConfig")]
        public Input<Inputs.NodeGroupScalingConfigGetArgs>? ScalingConfig { get; set; }

        /// <summary>
        /// Status of the EKS Node Group.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;

        /// <summary>
        /// Identifiers of EC2 Subnets to associate with the EKS Node Group. These subnets must have the following resource tag: `kubernetes.io/cluster/CLUSTER_NAME` (where `CLUSTER_NAME` is replaced with the name of the EKS Cluster).
        /// </summary>
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public NodeGroupState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class NodeGroupRemoteAccessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// EC2 Key Pair name that provides access for SSH communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify `source_security_group_ids` when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        [Input("ec2SshKey")]
        public Input<string>? Ec2SshKey { get; set; }

        [Input("sourceSecurityGroupIds")]
        private InputList<string>? _sourceSecurityGroupIds;

        /// <summary>
        /// Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify `ec2_ssh_key`, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        public InputList<string> SourceSecurityGroupIds
        {
            get => _sourceSecurityGroupIds ?? (_sourceSecurityGroupIds = new InputList<string>());
            set => _sourceSecurityGroupIds = value;
        }

        public NodeGroupRemoteAccessArgs()
        {
        }
    }

    public sealed class NodeGroupRemoteAccessGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// EC2 Key Pair name that provides access for SSH communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify `source_security_group_ids` when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        [Input("ec2SshKey")]
        public Input<string>? Ec2SshKey { get; set; }

        [Input("sourceSecurityGroupIds")]
        private InputList<string>? _sourceSecurityGroupIds;

        /// <summary>
        /// Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify `ec2_ssh_key`, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        public InputList<string> SourceSecurityGroupIds
        {
            get => _sourceSecurityGroupIds ?? (_sourceSecurityGroupIds = new InputList<string>());
            set => _sourceSecurityGroupIds = value;
        }

        public NodeGroupRemoteAccessGetArgs()
        {
        }
    }

    public sealed class NodeGroupResourcesAutoscalingGroupsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the AutoScaling Group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public NodeGroupResourcesAutoscalingGroupsGetArgs()
        {
        }
    }

    public sealed class NodeGroupResourcesGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoscalingGroups")]
        private InputList<NodeGroupResourcesAutoscalingGroupsGetArgs>? _autoscalingGroups;

        /// <summary>
        /// List of objects containing information about AutoScaling Groups.
        /// </summary>
        public InputList<NodeGroupResourcesAutoscalingGroupsGetArgs> AutoscalingGroups
        {
            get => _autoscalingGroups ?? (_autoscalingGroups = new InputList<NodeGroupResourcesAutoscalingGroupsGetArgs>());
            set => _autoscalingGroups = value;
        }

        /// <summary>
        /// Identifier of the remote access EC2 Security Group.
        /// </summary>
        [Input("remoteAccessSecurityGroupId")]
        public Input<string>? RemoteAccessSecurityGroupId { get; set; }

        public NodeGroupResourcesGetArgs()
        {
        }
    }

    public sealed class NodeGroupScalingConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Desired number of worker nodes.
        /// </summary>
        [Input("desiredSize", required: true)]
        public Input<int> DesiredSize { get; set; } = null!;

        /// <summary>
        /// Maximum number of worker nodes.
        /// </summary>
        [Input("maxSize", required: true)]
        public Input<int> MaxSize { get; set; } = null!;

        /// <summary>
        /// Minimum number of worker nodes.
        /// </summary>
        [Input("minSize", required: true)]
        public Input<int> MinSize { get; set; } = null!;

        public NodeGroupScalingConfigArgs()
        {
        }
    }

    public sealed class NodeGroupScalingConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Desired number of worker nodes.
        /// </summary>
        [Input("desiredSize", required: true)]
        public Input<int> DesiredSize { get; set; } = null!;

        /// <summary>
        /// Maximum number of worker nodes.
        /// </summary>
        [Input("maxSize", required: true)]
        public Input<int> MaxSize { get; set; } = null!;

        /// <summary>
        /// Minimum number of worker nodes.
        /// </summary>
        [Input("minSize", required: true)]
        public Input<int> MinSize { get; set; } = null!;

        public NodeGroupScalingConfigGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class NodeGroupRemoteAccess
    {
        /// <summary>
        /// EC2 Key Pair name that provides access for SSH communication with the worker nodes in the EKS Node Group. If you specify this configuration, but do not specify `source_security_group_ids` when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        public readonly string? Ec2SshKey;
        /// <summary>
        /// Set of EC2 Security Group IDs to allow SSH access (port 22) from on the worker nodes. If you specify `ec2_ssh_key`, but do not specify this configuration when you create an EKS Node Group, port 22 on the worker nodes is opened to the Internet (0.0.0.0/0).
        /// </summary>
        public readonly ImmutableArray<string> SourceSecurityGroupIds;

        [OutputConstructor]
        private NodeGroupRemoteAccess(
            string? ec2SshKey,
            ImmutableArray<string> sourceSecurityGroupIds)
        {
            Ec2SshKey = ec2SshKey;
            SourceSecurityGroupIds = sourceSecurityGroupIds;
        }
    }

    [OutputType]
    public sealed class NodeGroupResources
    {
        /// <summary>
        /// List of objects containing information about AutoScaling Groups.
        /// </summary>
        public readonly ImmutableArray<NodeGroupResourcesAutoscalingGroups> AutoscalingGroups;
        /// <summary>
        /// Identifier of the remote access EC2 Security Group.
        /// </summary>
        public readonly string RemoteAccessSecurityGroupId;

        [OutputConstructor]
        private NodeGroupResources(
            ImmutableArray<NodeGroupResourcesAutoscalingGroups> autoscalingGroups,
            string remoteAccessSecurityGroupId)
        {
            AutoscalingGroups = autoscalingGroups;
            RemoteAccessSecurityGroupId = remoteAccessSecurityGroupId;
        }
    }

    [OutputType]
    public sealed class NodeGroupResourcesAutoscalingGroups
    {
        /// <summary>
        /// Name of the AutoScaling Group.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private NodeGroupResourcesAutoscalingGroups(string name)
        {
            Name = name;
        }
    }

    [OutputType]
    public sealed class NodeGroupScalingConfig
    {
        /// <summary>
        /// Desired number of worker nodes.
        /// </summary>
        public readonly int DesiredSize;
        /// <summary>
        /// Maximum number of worker nodes.
        /// </summary>
        public readonly int MaxSize;
        /// <summary>
        /// Minimum number of worker nodes.
        /// </summary>
        public readonly int MinSize;

        [OutputConstructor]
        private NodeGroupScalingConfig(
            int desiredSize,
            int maxSize,
            int minSize)
        {
            DesiredSize = desiredSize;
            MaxSize = maxSize;
            MinSize = minSize;
        }
    }
    }
}
