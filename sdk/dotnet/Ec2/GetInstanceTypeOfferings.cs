// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2
{
    public static partial class Invokes
    {
        /// <summary>
        /// Information about EC2 Instance Type Offerings.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ec2_instance_type_offerings.html.markdown.
        /// </summary>
        [Obsolete("Use GetInstanceTypeOfferings.InvokeAsync() instead")]
        public static Task<GetInstanceTypeOfferingsResult> GetInstanceTypeOfferings(GetInstanceTypeOfferingsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstanceTypeOfferingsResult>("aws:ec2/getInstanceTypeOfferings:getInstanceTypeOfferings", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetInstanceTypeOfferings
    {
        /// <summary>
        /// Information about EC2 Instance Type Offerings.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ec2_instance_type_offerings.html.markdown.
        /// </summary>
        public static Task<GetInstanceTypeOfferingsResult> InvokeAsync(GetInstanceTypeOfferingsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstanceTypeOfferingsResult>("aws:ec2/getInstanceTypeOfferings:getInstanceTypeOfferings", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetInstanceTypeOfferingsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInstanceTypeOfferingsFiltersArgs>? _filters;

        /// <summary>
        /// One or more configuration blocks containing name-values filters. See the [EC2 API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstanceTypeOfferings.html) for supported filters. Detailed below.
        /// </summary>
        public List<Inputs.GetInstanceTypeOfferingsFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInstanceTypeOfferingsFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Location type. Defaults to `region`. Valid values: `availability-zone`, `availability-zone-id`, and `region`.
        /// </summary>
        [Input("locationType")]
        public string? LocationType { get; set; }

        public GetInstanceTypeOfferingsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetInstanceTypeOfferingsResult
    {
        public readonly ImmutableArray<Outputs.GetInstanceTypeOfferingsFiltersResult> Filters;
        /// <summary>
        /// Set of EC2 Instance Types.
        /// </summary>
        public readonly ImmutableArray<string> InstanceTypes;
        public readonly string? LocationType;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetInstanceTypeOfferingsResult(
            ImmutableArray<Outputs.GetInstanceTypeOfferingsFiltersResult> filters,
            ImmutableArray<string> instanceTypes,
            string? locationType,
            string id)
        {
            Filters = filters;
            InstanceTypes = instanceTypes;
            LocationType = locationType;
            Id = id;
        }
    }

    namespace Inputs
    {

    public sealed class GetInstanceTypeOfferingsFiltersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Name of the filter. The `location` filter depends on the top-level `location_type` argument and if not specified, defaults to the current region.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("values", required: true)]
        private List<string>? _values;

        /// <summary>
        /// List of one or more values for the filter.
        /// </summary>
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetInstanceTypeOfferingsFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetInstanceTypeOfferingsFiltersResult
    {
        /// <summary>
        /// Name of the filter. The `location` filter depends on the top-level `location_type` argument and if not specified, defaults to the current region.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of one or more values for the filter.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetInstanceTypeOfferingsFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
