// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticTranscoder
{
    /// <summary>
    /// Provides an Elastic Transcoder pipeline resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elastictranscoder_pipeline.html.markdown.
    /// </summary>
    public partial class Pipeline : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The AWS Key Management Service (AWS KMS) key that you want to use with this pipeline.
        /// </summary>
        [Output("awsKmsKeyArn")]
        public Output<string?> AwsKmsKeyArn { get; private set; } = null!;

        /// <summary>
        /// The ContentConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists. (documented below)
        /// </summary>
        [Output("contentConfig")]
        public Output<Outputs.PipelineContentConfig> ContentConfig { get; private set; } = null!;

        /// <summary>
        /// The permissions for the `content_config` object. (documented below)
        /// </summary>
        [Output("contentConfigPermissions")]
        public Output<ImmutableArray<Outputs.PipelineContentConfigPermissions>> ContentConfigPermissions { get; private set; } = null!;

        /// <summary>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode and the graphics that you want to use as watermarks.
        /// </summary>
        [Output("inputBucket")]
        public Output<string> InputBucket { get; private set; } = null!;

        /// <summary>
        /// The name of the pipeline. Maximum 40 characters
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. (documented below)
        /// </summary>
        [Output("notifications")]
        public Output<Outputs.PipelineNotifications?> Notifications { get; private set; } = null!;

        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files.
        /// </summary>
        [Output("outputBucket")]
        public Output<string> OutputBucket { get; private set; } = null!;

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to use to transcode jobs for this pipeline.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;

        /// <summary>
        /// The ThumbnailConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files. (documented below)
        /// </summary>
        [Output("thumbnailConfig")]
        public Output<Outputs.PipelineThumbnailConfig> ThumbnailConfig { get; private set; } = null!;

        /// <summary>
        /// The permissions for the `thumbnail_config` object. (documented below)
        /// </summary>
        [Output("thumbnailConfigPermissions")]
        public Output<ImmutableArray<Outputs.PipelineThumbnailConfigPermissions>> ThumbnailConfigPermissions { get; private set; } = null!;


        /// <summary>
        /// Create a Pipeline resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Pipeline(string name, PipelineArgs args, CustomResourceOptions? options = null)
            : base("aws:elastictranscoder/pipeline:Pipeline", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Pipeline(string name, Input<string> id, PipelineState? state = null, CustomResourceOptions? options = null)
            : base("aws:elastictranscoder/pipeline:Pipeline", name, state, MakeResourceOptions(options, id))
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
        /// The AWS Key Management Service (AWS KMS) key that you want to use with this pipeline.
        /// </summary>
        [Input("awsKmsKeyArn")]
        public Input<string>? AwsKmsKeyArn { get; set; }

        /// <summary>
        /// The ContentConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists. (documented below)
        /// </summary>
        [Input("contentConfig")]
        public Input<Inputs.PipelineContentConfigArgs>? ContentConfig { get; set; }

        [Input("contentConfigPermissions")]
        private InputList<Inputs.PipelineContentConfigPermissionsArgs>? _contentConfigPermissions;

        /// <summary>
        /// The permissions for the `content_config` object. (documented below)
        /// </summary>
        public InputList<Inputs.PipelineContentConfigPermissionsArgs> ContentConfigPermissions
        {
            get => _contentConfigPermissions ?? (_contentConfigPermissions = new InputList<Inputs.PipelineContentConfigPermissionsArgs>());
            set => _contentConfigPermissions = value;
        }

        /// <summary>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode and the graphics that you want to use as watermarks.
        /// </summary>
        [Input("inputBucket", required: true)]
        public Input<string> InputBucket { get; set; } = null!;

        /// <summary>
        /// The name of the pipeline. Maximum 40 characters
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. (documented below)
        /// </summary>
        [Input("notifications")]
        public Input<Inputs.PipelineNotificationsArgs>? Notifications { get; set; }

        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files.
        /// </summary>
        [Input("outputBucket")]
        public Input<string>? OutputBucket { get; set; }

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to use to transcode jobs for this pipeline.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        /// <summary>
        /// The ThumbnailConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files. (documented below)
        /// </summary>
        [Input("thumbnailConfig")]
        public Input<Inputs.PipelineThumbnailConfigArgs>? ThumbnailConfig { get; set; }

        [Input("thumbnailConfigPermissions")]
        private InputList<Inputs.PipelineThumbnailConfigPermissionsArgs>? _thumbnailConfigPermissions;

        /// <summary>
        /// The permissions for the `thumbnail_config` object. (documented below)
        /// </summary>
        public InputList<Inputs.PipelineThumbnailConfigPermissionsArgs> ThumbnailConfigPermissions
        {
            get => _thumbnailConfigPermissions ?? (_thumbnailConfigPermissions = new InputList<Inputs.PipelineThumbnailConfigPermissionsArgs>());
            set => _thumbnailConfigPermissions = value;
        }

        public PipelineArgs()
        {
        }
    }

    public sealed class PipelineState : Pulumi.ResourceArgs
    {
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The AWS Key Management Service (AWS KMS) key that you want to use with this pipeline.
        /// </summary>
        [Input("awsKmsKeyArn")]
        public Input<string>? AwsKmsKeyArn { get; set; }

        /// <summary>
        /// The ContentConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save transcoded files and playlists. (documented below)
        /// </summary>
        [Input("contentConfig")]
        public Input<Inputs.PipelineContentConfigGetArgs>? ContentConfig { get; set; }

        [Input("contentConfigPermissions")]
        private InputList<Inputs.PipelineContentConfigPermissionsGetArgs>? _contentConfigPermissions;

        /// <summary>
        /// The permissions for the `content_config` object. (documented below)
        /// </summary>
        public InputList<Inputs.PipelineContentConfigPermissionsGetArgs> ContentConfigPermissions
        {
            get => _contentConfigPermissions ?? (_contentConfigPermissions = new InputList<Inputs.PipelineContentConfigPermissionsGetArgs>());
            set => _contentConfigPermissions = value;
        }

        /// <summary>
        /// The Amazon S3 bucket in which you saved the media files that you want to transcode and the graphics that you want to use as watermarks.
        /// </summary>
        [Input("inputBucket")]
        public Input<string>? InputBucket { get; set; }

        /// <summary>
        /// The name of the pipeline. Maximum 40 characters
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. (documented below)
        /// </summary>
        [Input("notifications")]
        public Input<Inputs.PipelineNotificationsGetArgs>? Notifications { get; set; }

        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save the transcoded files.
        /// </summary>
        [Input("outputBucket")]
        public Input<string>? OutputBucket { get; set; }

        /// <summary>
        /// The IAM Amazon Resource Name (ARN) for the role that you want Elastic Transcoder to use to transcode jobs for this pipeline.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        /// <summary>
        /// The ThumbnailConfig object specifies information about the Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files. (documented below)
        /// </summary>
        [Input("thumbnailConfig")]
        public Input<Inputs.PipelineThumbnailConfigGetArgs>? ThumbnailConfig { get; set; }

        [Input("thumbnailConfigPermissions")]
        private InputList<Inputs.PipelineThumbnailConfigPermissionsGetArgs>? _thumbnailConfigPermissions;

        /// <summary>
        /// The permissions for the `thumbnail_config` object. (documented below)
        /// </summary>
        public InputList<Inputs.PipelineThumbnailConfigPermissionsGetArgs> ThumbnailConfigPermissions
        {
            get => _thumbnailConfigPermissions ?? (_thumbnailConfigPermissions = new InputList<Inputs.PipelineThumbnailConfigPermissionsGetArgs>());
            set => _thumbnailConfigPermissions = value;
        }

        public PipelineState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class PipelineContentConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public PipelineContentConfigArgs()
        {
        }
    }

    public sealed class PipelineContentConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public PipelineContentConfigGetArgs()
        {
        }
    }

    public sealed class PipelineContentConfigPermissionsArgs : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<string>? _accesses;

        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public InputList<string> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<string>());
            set => _accesses = value;
        }

        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        [Input("grantee")]
        public Input<string>? Grantee { get; set; }

        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        [Input("granteeType")]
        public Input<string>? GranteeType { get; set; }

        public PipelineContentConfigPermissionsArgs()
        {
        }
    }

    public sealed class PipelineContentConfigPermissionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<string>? _accesses;

        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public InputList<string> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<string>());
            set => _accesses = value;
        }

        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        [Input("grantee")]
        public Input<string>? Grantee { get; set; }

        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        [Input("granteeType")]
        public Input<string>? GranteeType { get; set; }

        public PipelineContentConfigPermissionsGetArgs()
        {
        }
    }

    public sealed class PipelineNotificationsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing a job in this pipeline.
        /// </summary>
        [Input("completed")]
        public Input<string>? Completed { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition while processing a job in this pipeline.
        /// </summary>
        [Input("error")]
        public Input<string>? Error { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process a job in this pipeline.
        /// </summary>
        [Input("progressing")]
        public Input<string>? Progressing { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition while processing a job in this pipeline.
        /// </summary>
        [Input("warning")]
        public Input<string>? Warning { get; set; }

        public PipelineNotificationsArgs()
        {
        }
    }

    public sealed class PipelineNotificationsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing a job in this pipeline.
        /// </summary>
        [Input("completed")]
        public Input<string>? Completed { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition while processing a job in this pipeline.
        /// </summary>
        [Input("error")]
        public Input<string>? Error { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process a job in this pipeline.
        /// </summary>
        [Input("progressing")]
        public Input<string>? Progressing { get; set; }

        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition while processing a job in this pipeline.
        /// </summary>
        [Input("warning")]
        public Input<string>? Warning { get; set; }

        public PipelineNotificationsGetArgs()
        {
        }
    }

    public sealed class PipelineThumbnailConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public PipelineThumbnailConfigArgs()
        {
        }
    }

    public sealed class PipelineThumbnailConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        public PipelineThumbnailConfigGetArgs()
        {
        }
    }

    public sealed class PipelineThumbnailConfigPermissionsArgs : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<string>? _accesses;

        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public InputList<string> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<string>());
            set => _accesses = value;
        }

        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        [Input("grantee")]
        public Input<string>? Grantee { get; set; }

        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        [Input("granteeType")]
        public Input<string>? GranteeType { get; set; }

        public PipelineThumbnailConfigPermissionsArgs()
        {
        }
    }

    public sealed class PipelineThumbnailConfigPermissionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("accesses")]
        private InputList<string>? _accesses;

        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public InputList<string> Accesses
        {
            get => _accesses ?? (_accesses = new InputList<string>());
            set => _accesses = value;
        }

        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        [Input("grantee")]
        public Input<string>? Grantee { get; set; }

        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        [Input("granteeType")]
        public Input<string>? GranteeType { get; set; }

        public PipelineThumbnailConfigPermissionsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class PipelineContentConfig
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        public readonly string? StorageClass;

        [OutputConstructor]
        private PipelineContentConfig(
            string bucket,
            string? storageClass)
        {
            Bucket = bucket;
            StorageClass = storageClass;
        }
    }

    [OutputType]
    public sealed class PipelineContentConfigPermissions
    {
        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public readonly ImmutableArray<string> Accesses;
        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        public readonly string? Grantee;
        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        public readonly string? GranteeType;

        [OutputConstructor]
        private PipelineContentConfigPermissions(
            ImmutableArray<string> accesses,
            string? grantee,
            string? granteeType)
        {
            Accesses = accesses;
            Grantee = grantee;
            GranteeType = granteeType;
        }
    }

    [OutputType]
    public sealed class PipelineNotifications
    {
        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing a job in this pipeline.
        /// </summary>
        public readonly string? Completed;
        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error condition while processing a job in this pipeline.
        /// </summary>
        public readonly string? Error;
        /// <summary>
        /// The topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process a job in this pipeline.
        /// </summary>
        public readonly string? Progressing;
        /// <summary>
        /// The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters a warning condition while processing a job in this pipeline.
        /// </summary>
        public readonly string? Warning;

        [OutputConstructor]
        private PipelineNotifications(
            string? completed,
            string? error,
            string? progressing,
            string? warning)
        {
            Completed = completed;
            Error = error;
            Progressing = progressing;
            Warning = warning;
        }
    }

    [OutputType]
    public sealed class PipelineThumbnailConfig
    {
        /// <summary>
        /// The Amazon S3 bucket in which you want Elastic Transcoder to save thumbnail files.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// The Amazon S3 storage class, Standard or ReducedRedundancy, that you want Elastic Transcoder to assign to the thumbnails that it stores in your Amazon S3 bucket.
        /// </summary>
        public readonly string? StorageClass;

        [OutputConstructor]
        private PipelineThumbnailConfig(
            string bucket,
            string? storageClass)
        {
            Bucket = bucket;
            StorageClass = storageClass;
        }
    }

    [OutputType]
    public sealed class PipelineThumbnailConfigPermissions
    {
        /// <summary>
        /// The permission that you want to give to the AWS user that you specified in `thumbnail_config_permissions.grantee`.
        /// </summary>
        public readonly ImmutableArray<string> Accesses;
        /// <summary>
        /// The AWS user or group that you want to have access to thumbnail files.
        /// </summary>
        public readonly string? Grantee;
        /// <summary>
        /// Specify the type of value that appears in the `thumbnail_config_permissions.grantee` object.
        /// </summary>
        public readonly string? GranteeType;

        [OutputConstructor]
        private PipelineThumbnailConfigPermissions(
            ImmutableArray<string> accesses,
            string? grantee,
            string? granteeType)
        {
            Accesses = accesses;
            Grantee = grantee;
            GranteeType = granteeType;
        }
    }
    }
}
