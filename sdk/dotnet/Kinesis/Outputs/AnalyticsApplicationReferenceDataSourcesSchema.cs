// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Kinesis.Outputs
{

    [OutputType]
    public sealed class AnalyticsApplicationReferenceDataSourcesSchema
    {
        public readonly ImmutableArray<Outputs.AnalyticsApplicationReferenceDataSourcesSchemaRecordColumn> RecordColumns;
        public readonly string? RecordEncoding;
        public readonly Outputs.AnalyticsApplicationReferenceDataSourcesSchemaRecordFormat RecordFormat;

        [OutputConstructor]
        private AnalyticsApplicationReferenceDataSourcesSchema(
            ImmutableArray<Outputs.AnalyticsApplicationReferenceDataSourcesSchemaRecordColumn> recordColumns,

            string? recordEncoding,

            Outputs.AnalyticsApplicationReferenceDataSourcesSchemaRecordFormat recordFormat)
        {
            RecordColumns = recordColumns;
            RecordEncoding = recordEncoding;
            RecordFormat = recordFormat;
        }
    }
}