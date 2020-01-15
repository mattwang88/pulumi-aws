// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ElasticTranscoder.Inputs
{

    public sealed class PresetThumbnailsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The display aspect ratio of the video in the output file. Valid values are: `auto`, `1:1`, `4:3`, `3:2`, `16:9`. (Note; to better control resolution and aspect ratio of output videos, we recommend that you use the values `max_width`, `max_height`, `sizing_policy`, `padding_policy`, and `display_aspect_ratio` instead of `resolution` and `aspect_ratio`.)
        /// </summary>
        [Input("aspectRatio")]
        public Input<string>? AspectRatio { get; set; }

        /// <summary>
        /// The format of thumbnails, if any. Valid formats are jpg and png.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// The approximate number of seconds between thumbnails. The value must be an integer. The actual interval can vary by several seconds from one thumbnail to the next.
        /// </summary>
        [Input("interval")]
        public Input<string>? Interval { get; set; }

        /// <summary>
        /// The maximum height of the watermark.
        /// </summary>
        [Input("maxHeight")]
        public Input<string>? MaxHeight { get; set; }

        /// <summary>
        /// The maximum width of the watermark.
        /// </summary>
        [Input("maxWidth")]
        public Input<string>? MaxWidth { get; set; }

        /// <summary>
        /// When you set PaddingPolicy to Pad, Elastic Transcoder might add black bars to the top and bottom and/or left and right sides of the output video to make the total size of the output video match the values that you specified for `max_width` and `max_height`.
        /// </summary>
        [Input("paddingPolicy")]
        public Input<string>? PaddingPolicy { get; set; }

        /// <summary>
        /// The width and height of the video in the output file, in pixels. Valid values are `auto` and `widthxheight`. (see note for `aspect_ratio`)
        /// </summary>
        [Input("resolution")]
        public Input<string>? Resolution { get; set; }

        /// <summary>
        /// A value that controls scaling of the watermark. Valid values are: `Fit`, `Stretch`, `ShrinkToFit`
        /// </summary>
        [Input("sizingPolicy")]
        public Input<string>? SizingPolicy { get; set; }

        public PresetThumbnailsArgs()
        {
        }
    }
}