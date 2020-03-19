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
        /// Use this data source to get the access to the effective Account ID, User ID, and ARN in
        /// which this provider is authorized.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/caller_identity.html.markdown.
        /// </summary>
        public static Task<GetCallerIdentityResult> GetCallerIdentity(InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCallerIdentityResult>("aws:index/getCallerIdentity:getCallerIdentity", InvokeArgs.Empty, options.WithVersion());
    }

    [OutputType]
    public sealed class GetCallerIdentityResult
    {
        /// <summary>
        /// The AWS Account ID number of the account that owns or contains the calling entity.
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// The AWS ARN associated with the calling entity.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The unique identifier of the calling entity.
        /// </summary>
        public readonly string UserId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetCallerIdentityResult(
            string accountId,
            string arn,
            string userId,
            string id)
        {
            AccountId = accountId;
            Arn = arn;
            UserId = userId;
            Id = id;
        }
    }
}
