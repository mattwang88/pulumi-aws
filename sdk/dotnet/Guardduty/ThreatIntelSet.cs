// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GuardDuty
{
    /// <summary>
    /// Provides a resource to manage a GuardDuty ThreatIntelSet.
    /// 
    /// &gt; **Note:** Currently in GuardDuty, users from member accounts cannot upload and further manage ThreatIntelSets. ThreatIntelSets that are uploaded by the master account are imposed on GuardDuty functionality in its member accounts. See the [GuardDuty API Documentation](https://docs.aws.amazon.com/guardduty/latest/ug/create-threat-intel-set.html)
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/guardduty_threatintelset.html.markdown.
    /// </summary>
    public partial class ThreatIntelSet : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies whether GuardDuty is to start using the uploaded ThreatIntelSet.
        /// </summary>
        [Output("activate")]
        public Output<bool> Activate { get; private set; } = null!;

        /// <summary>
        /// The detector ID of the GuardDuty.
        /// </summary>
        [Output("detectorId")]
        public Output<string> DetectorId { get; private set; } = null!;

        /// <summary>
        /// The format of the file that contains the ThreatIntelSet. Valid values: `TXT` | `STIX` | `OTX_CSV` | `ALIEN_VAULT` | `PROOF_POINT` | `FIRE_EYE`
        /// </summary>
        [Output("format")]
        public Output<string> Format { get; private set; } = null!;

        /// <summary>
        /// The URI of the file that contains the ThreatIntelSet.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The friendly name to identify the ThreatIntelSet.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a ThreatIntelSet resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ThreatIntelSet(string name, ThreatIntelSetArgs args, CustomResourceOptions? options = null)
            : base("aws:guardduty/threatIntelSet:ThreatIntelSet", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ThreatIntelSet(string name, Input<string> id, ThreatIntelSetState? state = null, CustomResourceOptions? options = null)
            : base("aws:guardduty/threatIntelSet:ThreatIntelSet", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ThreatIntelSet resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ThreatIntelSet Get(string name, Input<string> id, ThreatIntelSetState? state = null, CustomResourceOptions? options = null)
        {
            return new ThreatIntelSet(name, id, state, options);
        }
    }

    public sealed class ThreatIntelSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether GuardDuty is to start using the uploaded ThreatIntelSet.
        /// </summary>
        [Input("activate", required: true)]
        public Input<bool> Activate { get; set; } = null!;

        /// <summary>
        /// The detector ID of the GuardDuty.
        /// </summary>
        [Input("detectorId", required: true)]
        public Input<string> DetectorId { get; set; } = null!;

        /// <summary>
        /// The format of the file that contains the ThreatIntelSet. Valid values: `TXT` | `STIX` | `OTX_CSV` | `ALIEN_VAULT` | `PROOF_POINT` | `FIRE_EYE`
        /// </summary>
        [Input("format", required: true)]
        public Input<string> Format { get; set; } = null!;

        /// <summary>
        /// The URI of the file that contains the ThreatIntelSet.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// The friendly name to identify the ThreatIntelSet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ThreatIntelSetArgs()
        {
        }
    }

    public sealed class ThreatIntelSetState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies whether GuardDuty is to start using the uploaded ThreatIntelSet.
        /// </summary>
        [Input("activate")]
        public Input<bool>? Activate { get; set; }

        /// <summary>
        /// The detector ID of the GuardDuty.
        /// </summary>
        [Input("detectorId")]
        public Input<string>? DetectorId { get; set; }

        /// <summary>
        /// The format of the file that contains the ThreatIntelSet. Valid values: `TXT` | `STIX` | `OTX_CSV` | `ALIEN_VAULT` | `PROOF_POINT` | `FIRE_EYE`
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The URI of the file that contains the ThreatIntelSet.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The friendly name to identify the ThreatIntelSet.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public ThreatIntelSetState()
        {
        }
    }
}
