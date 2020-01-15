// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.S3.Outputs
{

    [OutputType]
    public sealed class BucketLifecycleRuleNoncurrentVersionTransition
    {
        /// <summary>
        /// The number of days that you want to specify for the default retention period.
        /// </summary>
        public readonly int? Days;
        /// <summary>
        /// The class of storage used to store the object. Can be `STANDARD`, `REDUCED_REDUNDANCY`, `STANDARD_IA`, `ONEZONE_IA`, `INTELLIGENT_TIERING`, `GLACIER`, or `DEEP_ARCHIVE`.
        /// </summary>
        public readonly string StorageClass;

        [OutputConstructor]
        private BucketLifecycleRuleNoncurrentVersionTransition(
            int? days,

            string storageClass)
        {
            Days = days;
            StorageClass = storageClass;
        }
    }
}