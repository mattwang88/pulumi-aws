// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Outputs
{

    [OutputType]
    public sealed class AnalyticsApplicationReferenceDataSources
    {
        /// <summary>
        /// The ARN of the Kinesis Analytics Application.
        /// </summary>
        public readonly string? Id;
        public readonly Outputs.AnalyticsApplicationReferenceDataSourcesS3 S3;
        public readonly Outputs.AnalyticsApplicationReferenceDataSourcesSchema Schema;
        public readonly string TableName;

        [OutputConstructor]
        private AnalyticsApplicationReferenceDataSources(
            string? id,

            Outputs.AnalyticsApplicationReferenceDataSourcesS3 s3,

            Outputs.AnalyticsApplicationReferenceDataSourcesSchema schema,

            string tableName)
        {
            Id = id;
            S3 = s3;
            Schema = schema;
            TableName = tableName;
        }
    }
}