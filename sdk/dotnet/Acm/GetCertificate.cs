// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Acm
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to get the ARN of a certificate in AWS Certificate
        /// Manager (ACM), you can reference
        /// it by domain without having to hard code the ARNs as input.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/acm_certificate.html.markdown.
        /// </summary>
        [Obsolete("Use GetCertificate.InvokeAsync() instead")]
        public static Task<GetCertificateResult> GetCertificate(GetCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCertificateResult>("aws:acm/getCertificate:getCertificate", args ?? InvokeArgs.Empty, options.WithVersion());
    }
    public static class GetCertificate
    {
        /// <summary>
        /// Use this data source to get the ARN of a certificate in AWS Certificate
        /// Manager (ACM), you can reference
        /// it by domain without having to hard code the ARNs as input.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/acm_certificate.html.markdown.
        /// </summary>
        public static Task<GetCertificateResult> InvokeAsync(GetCertificateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCertificateResult>("aws:acm/getCertificate:getCertificate", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetCertificateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The domain of the certificate to look up. If no certificate is found with this name, an error will be returned.
        /// </summary>
        [Input("domain", required: true)]
        public string Domain { get; set; } = null!;

        [Input("keyTypes")]
        private List<string>? _keyTypes;

        /// <summary>
        /// A list of key algorithms to filter certificates. By default, ACM does not return all certificate types when searching. Valid values are `RSA_1024`, `RSA_2048`, `RSA_4096`, `EC_prime256v1`, `EC_secp384r1`, and `EC_secp521r1`.
        /// </summary>
        public List<string> KeyTypes
        {
            get => _keyTypes ?? (_keyTypes = new List<string>());
            set => _keyTypes = value;
        }

        /// <summary>
        /// If set to true, it sorts the certificates matched by previous criteria by the NotBefore field, returning only the most recent one. If set to false, it returns an error if more than one certificate is found. Defaults to false.
        /// </summary>
        [Input("mostRecent")]
        public bool? MostRecent { get; set; }

        [Input("statuses")]
        private List<string>? _statuses;

        /// <summary>
        /// A list of statuses on which to filter the returned list. Valid values are `PENDING_VALIDATION`, `ISSUED`,
        /// `INACTIVE`, `EXPIRED`, `VALIDATION_TIMED_OUT`, `REVOKED` and `FAILED`. If no value is specified, only certificates in the `ISSUED` state
        /// are returned.
        /// </summary>
        public List<string> Statuses
        {
            get => _statuses ?? (_statuses = new List<string>());
            set => _statuses = value;
        }

        [Input("types")]
        private List<string>? _types;

        /// <summary>
        /// A list of types on which to filter the returned list. Valid values are `AMAZON_ISSUED` and `IMPORTED`.
        /// </summary>
        public List<string> Types
        {
            get => _types ?? (_types = new List<string>());
            set => _types = value;
        }

        public GetCertificateArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetCertificateResult
    {
        /// <summary>
        /// Set to the ARN of the found certificate, suitable for referencing in other resources that support ACM certificates.
        /// </summary>
        public readonly string Arn;
        public readonly string Domain;
        public readonly ImmutableArray<string> KeyTypes;
        public readonly bool? MostRecent;
        public readonly ImmutableArray<string> Statuses;
        public readonly ImmutableArray<string> Types;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetCertificateResult(
            string arn,
            string domain,
            ImmutableArray<string> keyTypes,
            bool? mostRecent,
            ImmutableArray<string> statuses,
            ImmutableArray<string> types,
            string id)
        {
            Arn = arn;
            Domain = domain;
            KeyTypes = keyTypes;
            MostRecent = mostRecent;
            Statuses = statuses;
            Types = types;
            Id = id;
        }
    }
}
