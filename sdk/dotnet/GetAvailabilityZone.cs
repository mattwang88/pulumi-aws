// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws
{
    public static partial class Invokes
    {
        /// <summary>
        /// `aws..getAvailabilityZone` provides details about a specific availability zone (AZ)
        /// in the current region.
        /// 
        /// This can be used both to validate an availability zone given in a variable
        /// and to split the AZ name into its component parts of an AWS region and an
        /// AZ identifier letter. The latter may be useful e.g. for implementing a
        /// consistent subnet numbering scheme across several regions by mapping both
        /// the region and the subnet letter to network numbers.
        /// 
        /// This is different from the `aws..getAvailabilityZones` (plural) data source,
        /// which provides a list of the available zones.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/availability_zone.html.markdown.
        /// </summary>
        public static Task<GetAvailabilityZoneResult> GetAvailabilityZone(GetAvailabilityZoneArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAvailabilityZoneResult>("aws:index/getAvailabilityZone:getAvailabilityZone", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetAvailabilityZoneArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The full name of the availability zone to select.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A specific availability zone state to require. May
        /// be any of `"available"`, `"information"` or `"impaired"`.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        /// <summary>
        /// The zone ID of the availability zone to select.
        /// </summary>
        [Input("zoneId")]
        public string? ZoneId { get; set; }

        public GetAvailabilityZoneArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetAvailabilityZoneResult
    {
        /// <summary>
        /// The name of the selected availability zone.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The part of the AZ name that appears after the region name,
        /// uniquely identifying the AZ within its region.
        /// </summary>
        public readonly string NameSuffix;
        /// <summary>
        /// The region where the selected availability zone resides.
        /// This is always the region selected on the provider, since this data source
        /// searches only within that region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// The current state of the AZ.
        /// </summary>
        public readonly string State;
        /// <summary>
        /// (Optional) The zone ID of the selected availability zone.
        /// </summary>
        public readonly string ZoneId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetAvailabilityZoneResult(
            string name,
            string nameSuffix,
            string region,
            string state,
            string zoneId,
            string id)
        {
            Name = name;
            NameSuffix = nameSuffix;
            Region = region;
            State = state;
            ZoneId = zoneId;
            Id = id;
        }
    }
}
