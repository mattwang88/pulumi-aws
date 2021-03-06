// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws
{
    public static partial class Invokes
    {
        /// <summary>
        /// `aws..getPrefixList` provides details about a specific prefix list (PL)
        /// in the current region.
        /// 
        /// This can be used both to validate a prefix list given in a variable
        /// and to obtain the CIDR blocks (IP address ranges) for the associated
        /// AWS service. The latter may be useful e.g. for adding network ACL
        /// rules.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/prefix_list.html.markdown.
        /// </summary>
        [Obsolete("Use GetPrefixList.InvokeAsync() instead")]
        public static Task<GetPrefixListResult> GetPrefixList(GetPrefixListArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrefixListResult>("aws:index/getPrefixList:getPrefixList", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetPrefixList
    {
        /// <summary>
        /// `aws..getPrefixList` provides details about a specific prefix list (PL)
        /// in the current region.
        /// 
        /// This can be used both to validate a prefix list given in a variable
        /// and to obtain the CIDR blocks (IP address ranges) for the associated
        /// AWS service. The latter may be useful e.g. for adding network ACL
        /// rules.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/prefix_list.html.markdown.
        /// </summary>
        public static Task<GetPrefixListResult> InvokeAsync(GetPrefixListArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPrefixListResult>("aws:index/getPrefixList:getPrefixList", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetPrefixListArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetPrefixListFiltersArgs>? _filters;

        /// <summary>
        /// Configuration block(s) for filtering. Detailed below.
        /// </summary>
        public List<Inputs.GetPrefixListFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetPrefixListFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// The name of the filter field. Valid values can be found in the [EC2 DescribePrefixLists API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribePrefixLists.html).
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The ID of the prefix list to select.
        /// </summary>
        [Input("prefixListId")]
        public string? PrefixListId { get; set; }

        public GetPrefixListArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetPrefixListResult
    {
        /// <summary>
        /// The list of CIDR blocks for the AWS service associated with the prefix list.
        /// </summary>
        public readonly ImmutableArray<string> CidrBlocks;
        public readonly ImmutableArray<Outputs.GetPrefixListFiltersResult> Filters;
        /// <summary>
        /// The name of the selected prefix list.
        /// </summary>
        public readonly string Name;
        public readonly string? PrefixListId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetPrefixListResult(
            ImmutableArray<string> cidrBlocks,
            ImmutableArray<Outputs.GetPrefixListFiltersResult> filters,
            string name,
            string? prefixListId,
            string id)
        {
            CidrBlocks = cidrBlocks;
            Filters = filters;
            Name = name;
            PrefixListId = prefixListId;
            Id = id;
        }
    }

    namespace Inputs
    {

    public sealed class GetPrefixListFiltersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the filter field. Valid values can be found in the [EC2 DescribePrefixLists API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribePrefixLists.html).
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("values", required: true)]
        private List<string>? _values;

        /// <summary>
        /// Set of values that are accepted for the given filter field. Results will be selected if any given value matches.
        /// </summary>
        public List<string> Values
        {
            get => _values ?? (_values = new List<string>());
            set => _values = value;
        }

        public GetPrefixListFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetPrefixListFiltersResult
    {
        /// <summary>
        /// The name of the filter field. Valid values can be found in the [EC2 DescribePrefixLists API Reference](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribePrefixLists.html).
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Set of values that are accepted for the given filter field. Results will be selected if any given value matches.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetPrefixListFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
