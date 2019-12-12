// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.SecretsManager
{
    public static partial class Invokes
    {
        /// <summary>
        /// Retrieve information about a Secrets Manager secret version, including its secret value. To retrieve secret metadata, see the [`aws.secretsmanager.Secret` data source](https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret.html).
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/secretsmanager_secret_version.html.markdown.
        /// </summary>
        public static Task<GetSecretVersionResult> GetSecretVersion(GetSecretVersionArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSecretVersionResult>("aws:secretsmanager/getSecretVersion:getSecretVersion", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetSecretVersionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the secret containing the version that you want to retrieve. You can specify either the Amazon Resource Name (ARN) or the friendly name of the secret.
        /// </summary>
        [Input("secretId", required: true)]
        public string SecretId { get; set; } = null!;

        /// <summary>
        /// Specifies the unique identifier of the version of the secret that you want to retrieve. Overrides `version_stage`.
        /// </summary>
        [Input("versionId")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Specifies the secret version that you want to retrieve by the staging label attached to the version. Defaults to `AWSCURRENT`.
        /// </summary>
        [Input("versionStage")]
        public string? VersionStage { get; set; }

        public GetSecretVersionArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetSecretVersionResult
    {
        /// <summary>
        /// The ARN of the secret.
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// The decrypted part of the protected secret information that was originally provided as a binary. Base64 encoded.
        /// </summary>
        public readonly string SecretBinary;
        public readonly string SecretId;
        /// <summary>
        /// The decrypted part of the protected secret information that was originally provided as a string.
        /// </summary>
        public readonly string SecretString;
        /// <summary>
        /// The unique identifier of this version of the secret.
        /// </summary>
        public readonly string VersionId;
        public readonly string? VersionStage;
        public readonly ImmutableArray<string> VersionStages;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetSecretVersionResult(
            string arn,
            string secretBinary,
            string secretId,
            string secretString,
            string versionId,
            string? versionStage,
            ImmutableArray<string> versionStages,
            string id)
        {
            Arn = arn;
            SecretBinary = secretBinary;
            SecretId = secretId;
            SecretString = secretString;
            VersionId = versionId;
            VersionStage = versionStage;
            VersionStages = versionStages;
            Id = id;
        }
    }
}
