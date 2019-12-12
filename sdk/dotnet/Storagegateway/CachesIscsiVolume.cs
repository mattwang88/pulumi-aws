// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.StorageGateway
{
    /// <summary>
    /// Manages an AWS Storage Gateway cached iSCSI volume.
    /// 
    /// &gt; **NOTE:** The gateway must have cache added (e.g. via the [`aws.storagegateway.Cache`](https://www.terraform.io/docs/providers/aws/r/storagegateway_cache.html) resource) before creating volumes otherwise the Storage Gateway API will return an error.
    /// 
    /// &gt; **NOTE:** The gateway must have an upload buffer added (e.g. via the [`aws.storagegateway.UploadBuffer`](https://www.terraform.io/docs/providers/aws/r/storagegateway_upload_buffer.html) resource) before the volume is operational to clients, however the Storage Gateway API will allow volume creation without error in that case and return volume status as `UPLOAD BUFFER NOT CONFIGURED`.
    /// 
    /// ## Example Usage
    /// 
    /// &gt; **NOTE:** These examples are referencing the [`aws.storagegateway.Cache`](https://www.terraform.io/docs/providers/aws/r/storagegateway_cache.html) resource `gateway_arn` attribute to ensure this provider properly adds cache before creating the volume. If you are not using this method, you may need to declare an expicit dependency (e.g. via `depends_on = ["aws_storagegateway_cache.example"]`) to ensure proper ordering.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/storagegateway_cached_iscsi_volume.html.markdown.
    /// </summary>
    public partial class CachesIscsiVolume : Pulumi.CustomResource
    {
        /// <summary>
        /// Volume Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/volume/vol-12345678`.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Whether mutual CHAP is enabled for the iSCSI target.
        /// </summary>
        [Output("chapEnabled")]
        public Output<bool> ChapEnabled { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [Output("gatewayArn")]
        public Output<string> GatewayArn { get; private set; } = null!;

        /// <summary>
        /// Logical disk number.
        /// </summary>
        [Output("lunNumber")]
        public Output<int> LunNumber { get; private set; } = null!;

        /// <summary>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4 addresses are accepted.
        /// </summary>
        [Output("networkInterfaceId")]
        public Output<string> NetworkInterfaceId { get; private set; } = null!;

        /// <summary>
        /// The port used to communicate with iSCSI targets.
        /// </summary>
        [Output("networkInterfacePort")]
        public Output<int> NetworkInterfacePort { get; private set; } = null!;

        /// <summary>
        /// The snapshot ID of the snapshot to restore as the new cached volume. e.g. `snap-1122aabb`.
        /// </summary>
        [Output("snapshotId")]
        public Output<string?> SnapshotId { get; private set; } = null!;

        /// <summary>
        /// The ARN for an existing volume. Specifying this ARN makes the new volume into an exact copy of the specified existing volume's latest recovery point. The `volume_size_in_bytes` value for this new volume must be equal to or larger than the size of the existing volume, in bytes.
        /// </summary>
        [Output("sourceVolumeArn")]
        public Output<string?> SourceVolumeArn { get; private set; } = null!;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// Target Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/target/iqn.1997-05.com.amazon:TargetName`.
        /// </summary>
        [Output("targetArn")]
        public Output<string> TargetArn { get; private set; } = null!;

        /// <summary>
        /// The name of the iSCSI target used by initiators to connect to the target and as a suffix for the target ARN. The target name must be unique across all volumes of a gateway.
        /// </summary>
        [Output("targetName")]
        public Output<string> TargetName { get; private set; } = null!;

        /// <summary>
        /// Volume Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/volume/vol-12345678`.
        /// </summary>
        [Output("volumeArn")]
        public Output<string> VolumeArn { get; private set; } = null!;

        /// <summary>
        /// Volume ID, e.g. `vol-12345678`.
        /// </summary>
        [Output("volumeId")]
        public Output<string> VolumeId { get; private set; } = null!;

        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        [Output("volumeSizeInBytes")]
        public Output<int> VolumeSizeInBytes { get; private set; } = null!;


        /// <summary>
        /// Create a CachesIscsiVolume resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CachesIscsiVolume(string name, CachesIscsiVolumeArgs args, CustomResourceOptions? options = null)
            : base("aws:storagegateway/cachesIscsiVolume:CachesIscsiVolume", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private CachesIscsiVolume(string name, Input<string> id, CachesIscsiVolumeState? state = null, CustomResourceOptions? options = null)
            : base("aws:storagegateway/cachesIscsiVolume:CachesIscsiVolume", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CachesIscsiVolume resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CachesIscsiVolume Get(string name, Input<string> id, CachesIscsiVolumeState? state = null, CustomResourceOptions? options = null)
        {
            return new CachesIscsiVolume(name, id, state, options);
        }
    }

    public sealed class CachesIscsiVolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [Input("gatewayArn", required: true)]
        public Input<string> GatewayArn { get; set; } = null!;

        /// <summary>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4 addresses are accepted.
        /// </summary>
        [Input("networkInterfaceId", required: true)]
        public Input<string> NetworkInterfaceId { get; set; } = null!;

        /// <summary>
        /// The snapshot ID of the snapshot to restore as the new cached volume. e.g. `snap-1122aabb`.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// The ARN for an existing volume. Specifying this ARN makes the new volume into an exact copy of the specified existing volume's latest recovery point. The `volume_size_in_bytes` value for this new volume must be equal to or larger than the size of the existing volume, in bytes.
        /// </summary>
        [Input("sourceVolumeArn")]
        public Input<string>? SourceVolumeArn { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The name of the iSCSI target used by initiators to connect to the target and as a suffix for the target ARN. The target name must be unique across all volumes of a gateway.
        /// </summary>
        [Input("targetName", required: true)]
        public Input<string> TargetName { get; set; } = null!;

        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        [Input("volumeSizeInBytes", required: true)]
        public Input<int> VolumeSizeInBytes { get; set; } = null!;

        public CachesIscsiVolumeArgs()
        {
        }
    }

    public sealed class CachesIscsiVolumeState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Volume Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/volume/vol-12345678`.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Whether mutual CHAP is enabled for the iSCSI target.
        /// </summary>
        [Input("chapEnabled")]
        public Input<bool>? ChapEnabled { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [Input("gatewayArn")]
        public Input<string>? GatewayArn { get; set; }

        /// <summary>
        /// Logical disk number.
        /// </summary>
        [Input("lunNumber")]
        public Input<int>? LunNumber { get; set; }

        /// <summary>
        /// The network interface of the gateway on which to expose the iSCSI target. Only IPv4 addresses are accepted.
        /// </summary>
        [Input("networkInterfaceId")]
        public Input<string>? NetworkInterfaceId { get; set; }

        /// <summary>
        /// The port used to communicate with iSCSI targets.
        /// </summary>
        [Input("networkInterfacePort")]
        public Input<int>? NetworkInterfacePort { get; set; }

        /// <summary>
        /// The snapshot ID of the snapshot to restore as the new cached volume. e.g. `snap-1122aabb`.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// The ARN for an existing volume. Specifying this ARN makes the new volume into an exact copy of the specified existing volume's latest recovery point. The `volume_size_in_bytes` value for this new volume must be equal to or larger than the size of the existing volume, in bytes.
        /// </summary>
        [Input("sourceVolumeArn")]
        public Input<string>? SourceVolumeArn { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Key-value mapping of resource tags
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Target Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/target/iqn.1997-05.com.amazon:TargetName`.
        /// </summary>
        [Input("targetArn")]
        public Input<string>? TargetArn { get; set; }

        /// <summary>
        /// The name of the iSCSI target used by initiators to connect to the target and as a suffix for the target ARN. The target name must be unique across all volumes of a gateway.
        /// </summary>
        [Input("targetName")]
        public Input<string>? TargetName { get; set; }

        /// <summary>
        /// Volume Amazon Resource Name (ARN), e.g. `arn:aws:storagegateway:us-east-1:123456789012:gateway/sgw-12345678/volume/vol-12345678`.
        /// </summary>
        [Input("volumeArn")]
        public Input<string>? VolumeArn { get; set; }

        /// <summary>
        /// Volume ID, e.g. `vol-12345678`.
        /// </summary>
        [Input("volumeId")]
        public Input<string>? VolumeId { get; set; }

        /// <summary>
        /// The size of the volume in bytes.
        /// </summary>
        [Input("volumeSizeInBytes")]
        public Input<int>? VolumeSizeInBytes { get; set; }

        public CachesIscsiVolumeState()
        {
        }
    }
}
