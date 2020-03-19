// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Iam
{
    /// <summary>
    /// Manages an IAM User Login Profile with limited support for password creation during this provider resource creation. Uses PGP to encrypt the password for safe transport to the user. PGP keys can be obtained from Keybase.
    /// 
    /// &gt; To reset an IAM User login password via this provider, you can use delete and recreate this resource or change any of the arguments.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/iam_user_login_profile.html.markdown.
    /// </summary>
    public partial class UserLoginProfile : Pulumi.CustomResource
    {
        /// <summary>
        /// The encrypted password, base64 encoded. Only available if password was handled on this provider resource creation, not import.
        /// </summary>
        [Output("encryptedPassword")]
        public Output<string> EncryptedPassword { get; private set; } = null!;

        /// <summary>
        /// The fingerprint of the PGP key used to encrypt the password. Only available if password was handled on this provider resource creation, not import.
        /// </summary>
        [Output("keyFingerprint")]
        public Output<string> KeyFingerprint { get; private set; } = null!;

        /// <summary>
        /// The length of the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Output("passwordLength")]
        public Output<int?> PasswordLength { get; private set; } = null!;

        /// <summary>
        /// Whether the user should be forced to reset the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Output("passwordResetRequired")]
        public Output<bool?> PasswordResetRequired { get; private set; } = null!;

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:username`. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Output("pgpKey")]
        public Output<string> PgpKey { get; private set; } = null!;

        /// <summary>
        /// The IAM user's name.
        /// </summary>
        [Output("user")]
        public Output<string> User { get; private set; } = null!;


        /// <summary>
        /// Create a UserLoginProfile resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserLoginProfile(string name, UserLoginProfileArgs args, CustomResourceOptions? options = null)
            : base("aws:iam/userLoginProfile:UserLoginProfile", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private UserLoginProfile(string name, Input<string> id, UserLoginProfileState? state = null, CustomResourceOptions? options = null)
            : base("aws:iam/userLoginProfile:UserLoginProfile", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UserLoginProfile resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserLoginProfile Get(string name, Input<string> id, UserLoginProfileState? state = null, CustomResourceOptions? options = null)
        {
            return new UserLoginProfile(name, id, state, options);
        }
    }

    public sealed class UserLoginProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The length of the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("passwordLength")]
        public Input<int>? PasswordLength { get; set; }

        /// <summary>
        /// Whether the user should be forced to reset the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("passwordResetRequired")]
        public Input<bool>? PasswordResetRequired { get; set; }

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:username`. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("pgpKey", required: true)]
        public Input<string> PgpKey { get; set; } = null!;

        /// <summary>
        /// The IAM user's name.
        /// </summary>
        [Input("user", required: true)]
        public Input<string> User { get; set; } = null!;

        public UserLoginProfileArgs()
        {
        }
    }

    public sealed class UserLoginProfileState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The encrypted password, base64 encoded. Only available if password was handled on this provider resource creation, not import.
        /// </summary>
        [Input("encryptedPassword")]
        public Input<string>? EncryptedPassword { get; set; }

        /// <summary>
        /// The fingerprint of the PGP key used to encrypt the password. Only available if password was handled on this provider resource creation, not import.
        /// </summary>
        [Input("keyFingerprint")]
        public Input<string>? KeyFingerprint { get; set; }

        /// <summary>
        /// The length of the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("passwordLength")]
        public Input<int>? PasswordLength { get; set; }

        /// <summary>
        /// Whether the user should be forced to reset the generated password on resource creation. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("passwordResetRequired")]
        public Input<bool>? PasswordResetRequired { get; set; }

        /// <summary>
        /// Either a base-64 encoded PGP public key, or a keybase username in the form `keybase:username`. Only applies on resource creation. Drift detection is not possible with this argument.
        /// </summary>
        [Input("pgpKey")]
        public Input<string>? PgpKey { get; set; }

        /// <summary>
        /// The IAM user's name.
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public UserLoginProfileState()
        {
        }
    }
}
