// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodePipeline
{
    /// <summary>
    /// Provides a CodePipeline.
    /// 
    /// &gt; **NOTE on `aws.codepipeline.Pipeline`:** - the `GITHUB_TOKEN` environment variable must be set if the GitHub provider is specified.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/codepipeline.markdown.
    /// </summary>
    public partial class Pipeline : Pulumi.CustomResource
    {
        /// <summary>
        /// The codepipeline ARN.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// An artifact_store block. Artifact stores are documented below.
        /// * `stage` (Minimum of at least two `stage` blocks is required) A stage block. Stages are documented below.
        /// </summary>
        [Output("artifactStore")]
        public Output<Outputs.PipelineArtifactStore> ArtifactStore { get; private set; } = null!;

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
        /// </summary>
        [Output("roleArn")]
        public Output<string> RoleArn { get; private set; } = null!;

        [Output("stages")]
        public Output<ImmutableArray<Outputs.PipelineStages>> Stages { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Pipeline resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Pipeline(string name, PipelineArgs args, CustomResourceOptions? options = null)
            : base("aws:codepipeline/pipeline:Pipeline", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Pipeline(string name, Input<string> id, PipelineState? state = null, CustomResourceOptions? options = null)
            : base("aws:codepipeline/pipeline:Pipeline", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Pipeline resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Pipeline Get(string name, Input<string> id, PipelineState? state = null, CustomResourceOptions? options = null)
        {
            return new Pipeline(name, id, state, options);
        }
    }

    public sealed class PipelineArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An artifact_store block. Artifact stores are documented below.
        /// * `stage` (Minimum of at least two `stage` blocks is required) A stage block. Stages are documented below.
        /// </summary>
        [Input("artifactStore", required: true)]
        public Input<Inputs.PipelineArtifactStoreArgs> ArtifactStore { get; set; } = null!;

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        [Input("stages", required: true)]
        private InputList<Inputs.PipelineStagesArgs>? _stages;
        public InputList<Inputs.PipelineStagesArgs> Stages
        {
            get => _stages ?? (_stages = new InputList<Inputs.PipelineStagesArgs>());
            set => _stages = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public PipelineArgs()
        {
        }
    }

    public sealed class PipelineState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The codepipeline ARN.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// An artifact_store block. Artifact stores are documented below.
        /// * `stage` (Minimum of at least two `stage` blocks is required) A stage block. Stages are documented below.
        /// </summary>
        [Input("artifactStore")]
        public Input<Inputs.PipelineArtifactStoreGetArgs>? ArtifactStore { get; set; }

        /// <summary>
        /// The name of the pipeline.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A service role Amazon Resource Name (ARN) that grants AWS CodePipeline permission to make calls to AWS services on your behalf.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("stages")]
        private InputList<Inputs.PipelineStagesGetArgs>? _stages;
        public InputList<Inputs.PipelineStagesGetArgs> Stages
        {
            get => _stages ?? (_stages = new InputList<Inputs.PipelineStagesGetArgs>());
            set => _stages = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public PipelineState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class PipelineArtifactStoreArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An `encryption_key` block is documented below.
        /// </summary>
        [Input("encryptionKey")]
        public Input<PipelineArtifactStoreEncryptionKeyArgs>? EncryptionKey { get; set; }

        /// <summary>
        /// The location where AWS CodePipeline stores artifacts for a pipeline, such as an S3 bucket.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The type of the artifact store, such as Amazon S3
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public PipelineArtifactStoreArgs()
        {
        }
    }

    public sealed class PipelineArtifactStoreEncryptionKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The KMS key ARN or ID
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The type of key; currently only `KMS` is supported
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public PipelineArtifactStoreEncryptionKeyArgs()
        {
        }
    }

    public sealed class PipelineArtifactStoreEncryptionKeyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The KMS key ARN or ID
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The type of key; currently only `KMS` is supported
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public PipelineArtifactStoreEncryptionKeyGetArgs()
        {
        }
    }

    public sealed class PipelineArtifactStoreGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An `encryption_key` block is documented below.
        /// </summary>
        [Input("encryptionKey")]
        public Input<PipelineArtifactStoreEncryptionKeyGetArgs>? EncryptionKey { get; set; }

        /// <summary>
        /// The location where AWS CodePipeline stores artifacts for a pipeline, such as an S3 bucket.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The type of the artifact store, such as Amazon S3
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public PipelineArtifactStoreGetArgs()
        {
        }
    }

    public sealed class PipelineStagesActionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are `Approval`, `Build`, `Deploy`, `Invoke`, `Source` and `Test`.
        /// </summary>
        [Input("category", required: true)]
        public Input<string> Category { get; set; } = null!;

        [Input("configuration")]
        private InputMap<object>? _configuration;

        /// <summary>
        /// A Map of the action declaration's configuration. Find out more about configuring action configurations in the [Reference Pipeline Structure documentation](http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements).
        /// </summary>
        public InputMap<object> Configuration
        {
            get => _configuration ?? (_configuration = new InputMap<object>());
            set => _configuration = value;
        }

        [Input("inputArtifacts")]
        private InputList<string>? _inputArtifacts;

        /// <summary>
        /// A list of artifact names to be worked on.
        /// </summary>
        public InputList<string> InputArtifacts
        {
            get => _inputArtifacts ?? (_inputArtifacts = new InputList<string>());
            set => _inputArtifacts = value;
        }

        /// <summary>
        /// The action declaration's name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("outputArtifacts")]
        private InputList<string>? _outputArtifacts;

        /// <summary>
        /// A list of artifact names to output. Output artifact names must be unique within a pipeline.
        /// </summary>
        public InputList<string> OutputArtifacts
        {
            get => _outputArtifacts ?? (_outputArtifacts = new InputList<string>());
            set => _outputArtifacts = value;
        }

        /// <summary>
        /// The creator of the action being called. Possible values are `AWS`, `Custom` and `ThirdParty`.
        /// </summary>
        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        /// <summary>
        /// The provider of the service being called by the action. Valid providers are determined by the action category. For example, an action in the Deploy category type might have a provider of AWS CodeDeploy, which would be specified as CodeDeploy.
        /// </summary>
        [Input("provider", required: true)]
        public Input<string> Provider { get; set; } = null!;

        /// <summary>
        /// The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// The order in which actions are run.
        /// </summary>
        [Input("runOrder")]
        public Input<int>? RunOrder { get; set; }

        /// <summary>
        /// A string that identifies the action type.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public PipelineStagesActionsArgs()
        {
        }
    }

    public sealed class PipelineStagesActionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are `Approval`, `Build`, `Deploy`, `Invoke`, `Source` and `Test`.
        /// </summary>
        [Input("category", required: true)]
        public Input<string> Category { get; set; } = null!;

        [Input("configuration")]
        private InputMap<object>? _configuration;

        /// <summary>
        /// A Map of the action declaration's configuration. Find out more about configuring action configurations in the [Reference Pipeline Structure documentation](http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements).
        /// </summary>
        public InputMap<object> Configuration
        {
            get => _configuration ?? (_configuration = new InputMap<object>());
            set => _configuration = value;
        }

        [Input("inputArtifacts")]
        private InputList<string>? _inputArtifacts;

        /// <summary>
        /// A list of artifact names to be worked on.
        /// </summary>
        public InputList<string> InputArtifacts
        {
            get => _inputArtifacts ?? (_inputArtifacts = new InputList<string>());
            set => _inputArtifacts = value;
        }

        /// <summary>
        /// The action declaration's name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("outputArtifacts")]
        private InputList<string>? _outputArtifacts;

        /// <summary>
        /// A list of artifact names to output. Output artifact names must be unique within a pipeline.
        /// </summary>
        public InputList<string> OutputArtifacts
        {
            get => _outputArtifacts ?? (_outputArtifacts = new InputList<string>());
            set => _outputArtifacts = value;
        }

        /// <summary>
        /// The creator of the action being called. Possible values are `AWS`, `Custom` and `ThirdParty`.
        /// </summary>
        [Input("owner", required: true)]
        public Input<string> Owner { get; set; } = null!;

        /// <summary>
        /// The provider of the service being called by the action. Valid providers are determined by the action category. For example, an action in the Deploy category type might have a provider of AWS CodeDeploy, which would be specified as CodeDeploy.
        /// </summary>
        [Input("provider", required: true)]
        public Input<string> Provider { get; set; } = null!;

        /// <summary>
        /// The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// The order in which actions are run.
        /// </summary>
        [Input("runOrder")]
        public Input<int>? RunOrder { get; set; }

        /// <summary>
        /// A string that identifies the action type.
        /// </summary>
        [Input("version", required: true)]
        public Input<string> Version { get; set; } = null!;

        public PipelineStagesActionsGetArgs()
        {
        }
    }

    public sealed class PipelineStagesArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<PipelineStagesActionsArgs>? _actions;

        /// <summary>
        /// The action(s) to include in the stage. Defined as an `action` block below
        /// </summary>
        public InputList<PipelineStagesActionsArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<PipelineStagesActionsArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// The name of the stage.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public PipelineStagesArgs()
        {
        }
    }

    public sealed class PipelineStagesGetArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<PipelineStagesActionsGetArgs>? _actions;

        /// <summary>
        /// The action(s) to include in the stage. Defined as an `action` block below
        /// </summary>
        public InputList<PipelineStagesActionsGetArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<PipelineStagesActionsGetArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// The name of the stage.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public PipelineStagesGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class PipelineArtifactStore
    {
        /// <summary>
        /// The encryption key block AWS CodePipeline uses to encrypt the data in the artifact store, such as an AWS Key Management Service (AWS KMS) key. If you don't specify a key, AWS CodePipeline uses the default key for Amazon Simple Storage Service (Amazon S3). An `encryption_key` block is documented below.
        /// </summary>
        public readonly PipelineArtifactStoreEncryptionKey? EncryptionKey;
        /// <summary>
        /// The location where AWS CodePipeline stores artifacts for a pipeline, such as an S3 bucket.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The type of the artifact store, such as Amazon S3
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PipelineArtifactStore(
            PipelineArtifactStoreEncryptionKey? encryptionKey,
            string location,
            string type)
        {
            EncryptionKey = encryptionKey;
            Location = location;
            Type = type;
        }
    }

    [OutputType]
    public sealed class PipelineArtifactStoreEncryptionKey
    {
        /// <summary>
        /// The KMS key ARN or ID
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The type of key; currently only `KMS` is supported
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PipelineArtifactStoreEncryptionKey(
            string id,
            string type)
        {
            Id = id;
            Type = type;
        }
    }

    [OutputType]
    public sealed class PipelineStages
    {
        /// <summary>
        /// The action(s) to include in the stage. Defined as an `action` block below
        /// </summary>
        public readonly ImmutableArray<PipelineStagesActions> Actions;
        /// <summary>
        /// The name of the stage.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private PipelineStages(
            ImmutableArray<PipelineStagesActions> actions,
            string name)
        {
            Actions = actions;
            Name = name;
        }
    }

    [OutputType]
    public sealed class PipelineStagesActions
    {
        /// <summary>
        /// A category defines what kind of action can be taken in the stage, and constrains the provider type for the action. Possible values are `Approval`, `Build`, `Deploy`, `Invoke`, `Source` and `Test`.
        /// </summary>
        public readonly string Category;
        /// <summary>
        /// A Map of the action declaration's configuration. Find out more about configuring action configurations in the [Reference Pipeline Structure documentation](http://docs.aws.amazon.com/codepipeline/latest/userguide/reference-pipeline-structure.html#action-requirements).
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Configuration;
        /// <summary>
        /// A list of artifact names to be worked on.
        /// </summary>
        public readonly ImmutableArray<string> InputArtifacts;
        /// <summary>
        /// The action declaration's name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A list of artifact names to output. Output artifact names must be unique within a pipeline.
        /// </summary>
        public readonly ImmutableArray<string> OutputArtifacts;
        /// <summary>
        /// The creator of the action being called. Possible values are `AWS`, `Custom` and `ThirdParty`.
        /// </summary>
        public readonly string Owner;
        /// <summary>
        /// The provider of the service being called by the action. Valid providers are determined by the action category. For example, an action in the Deploy category type might have a provider of AWS CodeDeploy, which would be specified as CodeDeploy.
        /// </summary>
        public readonly string Provider;
        /// <summary>
        /// The ARN of the IAM service role that will perform the declared action. This is assumed through the roleArn for the pipeline.
        /// </summary>
        public readonly string? RoleArn;
        /// <summary>
        /// The order in which actions are run.
        /// </summary>
        public readonly int RunOrder;
        /// <summary>
        /// A string that identifies the action type.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private PipelineStagesActions(
            string category,
            ImmutableDictionary<string, object>? configuration,
            ImmutableArray<string> inputArtifacts,
            string name,
            ImmutableArray<string> outputArtifacts,
            string owner,
            string provider,
            string? roleArn,
            int runOrder,
            string version)
        {
            Category = category;
            Configuration = configuration;
            InputArtifacts = inputArtifacts;
            Name = name;
            OutputArtifacts = outputArtifacts;
            Owner = owner;
            Provider = provider;
            RoleArn = roleArn;
            RunOrder = runOrder;
            Version = version;
        }
    }
    }
}
