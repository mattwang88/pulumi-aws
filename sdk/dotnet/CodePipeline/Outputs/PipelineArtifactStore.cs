// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodePipeline.Outputs
{

    [OutputType]
    public sealed class PipelineArtifactStore
    {
        public readonly Outputs.PipelineArtifactStoreEncryptionKey? EncryptionKey;
        public readonly string Location;
        public readonly string Type;

        [OutputConstructor]
        private PipelineArtifactStore(
            Outputs.PipelineArtifactStoreEncryptionKey? encryptionKey,

            string location,

            string type)
        {
            EncryptionKey = encryptionKey;
            Location = location;
            Type = type;
        }
    }
}