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
        /// Information about single EC2 Instance Type Offering.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ec2_instance_type_offering.html.markdown.
        /// </summary>
        [Obsolete("Use GetInstanceTypeOffering.InvokeAsync() instead")]
        public static Task<GetInstanceTypeOfferingResult> GetInstanceTypeOffering(GetInstanceTypeOfferingArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstanceTypeOfferingResult>("aws:ec2/getInstanceTypeOffering:getInstanceTypeOffering", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetInstanceTypeOffering
    {
        /// <summary>
        /// Information about single EC2 Instance Type Offering.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ec2_instance_type_offering.html.markdown.
        /// </summary>
        public static Task<GetInstanceTypeOfferingResult> InvokeAsync(GetInstanceTypeOfferingArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstanceTypeOfferingResult>("aws:ec2/getInstanceTypeOffering:getInstanceTypeOffering", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetInstanceTypeOfferingArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInstanceTypeOfferingFiltersArgs>? _filters;

        /// <summary>
        /// One or more configuration blocks containing name-values filters. See the [EC2 API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstanceTypeOfferings.html) for supported filters. Detailed below.
        /// </summary>
        public List<Inputs.GetInstanceTypeOfferingFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInstanceTypeOfferingFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Location type. Defaults to `region`. Valid values: `availability-zone`, `availability-zone-id`, and `region`.
        /// </summary>
        [Input("locationType")]
        public string? LocationType { get; set; }

        [Input("preferredInstanceTypes")]
        private List<string>? _preferredInstanceTypes;

        /// <summary>
        /// Ordered list of preferred EC2 Instance Types. The first match in this list will be returned. If no preferred matches are found and the original search returned more than one result, an error is returned.
        /// </summary>
        public List<string> PreferredInstanceTypes
        {
            get => _preferredInstanceTypes ?? (_preferredInstanceTypes = new List<string>());
            set => _preferredInstanceTypes = value;
        }

        public GetInstanceTypeOfferingArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetInstanceTypeOfferingResult
    {
        public readonly ImmutableArray<Outputs.GetInstanceTypeOfferingFiltersResult> Filters;
        /// <summary>
        /// EC2 Instance Type.
        /// </summary>
        public readonly string InstanceType;
        public readonly string? LocationType;
        public readonly ImmutableArray<string> PreferredInstanceTypes;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetInstanceTypeOfferingResult(
            ImmutableArray<Outputs.GetInstanceTypeOfferingFiltersResult> filters,
            string instanceType,
            string? locationType,
            ImmutableArray<string> preferredInstanceTypes,
            string id)
        {
            Filters = filters;
            InstanceType = instanceType;
            LocationType = locationType;
            PreferredInstanceTypes = preferredInstanceTypes;
            Id = id;
        }
    }

    namespace Inputs
    {

    public sealed class GetInstanceTypeOfferingFiltersArgs : Pulumi.InvokeArgs
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

        public GetInstanceTypeOfferingFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetInstanceTypeOfferingFiltersResult
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
        private GetInstanceTypeOfferingFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
