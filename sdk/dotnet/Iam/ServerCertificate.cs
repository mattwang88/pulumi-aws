// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iam
{
    /// <summary>
    /// Provides an IAM Server Certificate resource to upload Server Certificates.
    /// Certs uploaded to IAM can easily work with other AWS services such as:
    /// 
    /// - AWS Elastic Beanstalk
    /// - Elastic Load Balancing
    /// - CloudFront
    /// - AWS OpsWorks
    /// 
    /// For information about server certificates in IAM, see [Managing Server
    /// Certificates][2] in AWS Documentation.
    /// 
    /// &gt; **Note:** All arguments including the private key will be stored in the raw state as plain-text.
    /// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/iam_server_certificate.html.markdown.
    /// </summary>
    public partial class ServerCertificate : Pulumi.CustomResource
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the server certificate.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The contents of the public key certificate in
        /// PEM-encoded format.
        /// </summary>
        [Output("certificateBody")]
        public Output<string> CertificateBody { get; private set; } = null!;

        /// <summary>
        /// The contents of the certificate chain.
        /// This is typically a concatenation of the PEM-encoded public key certificates
        /// of the chain.
        /// </summary>
        [Output("certificateChain")]
        public Output<string?> CertificateChain { get; private set; } = null!;

        /// <summary>
        /// The name of the Server Certificate. Do not include the
        /// path in this value. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Output("namePrefix")]
        public Output<string?> NamePrefix { get; private set; } = null!;

        /// <summary>
        /// The IAM path for the server certificate.  If it is not
        /// included, it defaults to a slash (/). If this certificate is for use with
        /// AWS CloudFront, the path must be in format `/cloudfront/your_path_here`.
        /// See [IAM Identifiers][1] for more details on IAM Paths.
        /// </summary>
        [Output("path")]
        public Output<string?> Path { get; private set; } = null!;

        /// <summary>
        /// The contents of the private key in PEM-encoded format.
        /// </summary>
        [Output("privateKey")]
        public Output<string> PrivateKey { get; private set; } = null!;


        /// <summary>
        /// Create a ServerCertificate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ServerCertificate(string name, ServerCertificateArgs args, CustomResourceOptions? options = null)
            : base("aws:iam/serverCertificate:ServerCertificate", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private ServerCertificate(string name, Input<string> id, ServerCertificateState? state = null, CustomResourceOptions? options = null)
            : base("aws:iam/serverCertificate:ServerCertificate", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ServerCertificate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ServerCertificate Get(string name, Input<string> id, ServerCertificateState? state = null, CustomResourceOptions? options = null)
        {
            return new ServerCertificate(name, id, state, options);
        }
    }

    public sealed class ServerCertificateArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the server certificate.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The contents of the public key certificate in
        /// PEM-encoded format.
        /// </summary>
        [Input("certificateBody", required: true)]
        public Input<string> CertificateBody { get; set; } = null!;

        /// <summary>
        /// The contents of the certificate chain.
        /// This is typically a concatenation of the PEM-encoded public key certificates
        /// of the chain.
        /// </summary>
        [Input("certificateChain")]
        public Input<string>? CertificateChain { get; set; }

        /// <summary>
        /// The name of the Server Certificate. Do not include the
        /// path in this value. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The IAM path for the server certificate.  If it is not
        /// included, it defaults to a slash (/). If this certificate is for use with
        /// AWS CloudFront, the path must be in format `/cloudfront/your_path_here`.
        /// See [IAM Identifiers][1] for more details on IAM Paths.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The contents of the private key in PEM-encoded format.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        public ServerCertificateArgs()
        {
        }
    }

    public sealed class ServerCertificateState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) specifying the server certificate.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// The contents of the public key certificate in
        /// PEM-encoded format.
        /// </summary>
        [Input("certificateBody")]
        public Input<string>? CertificateBody { get; set; }

        /// <summary>
        /// The contents of the certificate chain.
        /// This is typically a concatenation of the PEM-encoded public key certificates
        /// of the chain.
        /// </summary>
        [Input("certificateChain")]
        public Input<string>? CertificateChain { get; set; }

        /// <summary>
        /// The name of the Server Certificate. Do not include the
        /// path in this value. If omitted, this provider will assign a random, unique name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Creates a unique name beginning with the specified
        /// prefix. Conflicts with `name`.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// The IAM path for the server certificate.  If it is not
        /// included, it defaults to a slash (/). If this certificate is for use with
        /// AWS CloudFront, the path must be in format `/cloudfront/your_path_here`.
        /// See [IAM Identifiers][1] for more details on IAM Paths.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The contents of the private key in PEM-encoded format.
        /// </summary>
        [Input("privateKey")]
        public Input<string>? PrivateKey { get; set; }

        public ServerCertificateState()
        {
        }
    }
}
