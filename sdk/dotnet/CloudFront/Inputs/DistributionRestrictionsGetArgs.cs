// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CloudFront.Inputs
{

    public sealed class DistributionRestrictionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("geoRestriction", required: true)]
        public Input<Inputs.DistributionRestrictionsGeoRestrictionGetArgs> GeoRestriction { get; set; } = null!;

        public DistributionRestrictionsGetArgs()
        {
        }
    }
}