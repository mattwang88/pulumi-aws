// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway
{
    /// <summary>
    /// Provides a settings of an API Gateway Account. Settings is applied region-wide per `provider` block.
    /// 
    /// &gt; **Note:** As there is no API method for deleting account settings or resetting it to defaults, destroying this resource will keep your account settings intact
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/api_gateway_account.html.markdown.
    /// </summary>
    public partial class Account : Pulumi.CustomResource
    {
        /// <summary>
        /// The ARN of an IAM role for CloudWatch (to allow logging &amp; monitoring).
        /// See more [in AWS Docs](https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-stage-settings.html#how-to-stage-settings-console).
        /// Logging &amp; monitoring can be enabled/disabled and otherwise tuned on the API Gateway Stage level.
        /// </summary>
        [Output("cloudwatchRoleArn")]
        public Output<string?> CloudwatchRoleArn { get; private set; } = null!;

        /// <summary>
        /// Account-Level throttle settings. See exported fields below.
        /// </summary>
        [Output("throttleSettings")]
        public Output<Outputs.AccountThrottleSettings> ThrottleSettings { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:apigateway/account:Account", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
            : base("aws:apigateway/account:Account", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
        {
            return new Account(name, id, state, options);
        }
    }

    public sealed class AccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of an IAM role for CloudWatch (to allow logging &amp; monitoring).
        /// See more [in AWS Docs](https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-stage-settings.html#how-to-stage-settings-console).
        /// Logging &amp; monitoring can be enabled/disabled and otherwise tuned on the API Gateway Stage level.
        /// </summary>
        [Input("cloudwatchRoleArn")]
        public Input<string>? CloudwatchRoleArn { get; set; }

        public AccountArgs()
        {
        }
    }

    public sealed class AccountState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ARN of an IAM role for CloudWatch (to allow logging &amp; monitoring).
        /// See more [in AWS Docs](https://docs.aws.amazon.com/apigateway/latest/developerguide/how-to-stage-settings.html#how-to-stage-settings-console).
        /// Logging &amp; monitoring can be enabled/disabled and otherwise tuned on the API Gateway Stage level.
        /// </summary>
        [Input("cloudwatchRoleArn")]
        public Input<string>? CloudwatchRoleArn { get; set; }

        /// <summary>
        /// Account-Level throttle settings. See exported fields below.
        /// </summary>
        [Input("throttleSettings")]
        public Input<Inputs.AccountThrottleSettingsGetArgs>? ThrottleSettings { get; set; }

        public AccountState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class AccountThrottleSettingsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The absolute maximum number of times API Gateway allows the API to be called per second (RPS).
        /// </summary>
        [Input("burstLimit")]
        public Input<int>? BurstLimit { get; set; }

        /// <summary>
        /// The number of times API Gateway allows the API to be called per second on average (RPS).
        /// </summary>
        [Input("rateLimit")]
        public Input<double>? RateLimit { get; set; }

        public AccountThrottleSettingsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class AccountThrottleSettings
    {
        /// <summary>
        /// The absolute maximum number of times API Gateway allows the API to be called per second (RPS).
        /// </summary>
        public readonly int BurstLimit;
        /// <summary>
        /// The number of times API Gateway allows the API to be called per second on average (RPS).
        /// </summary>
        public readonly double RateLimit;

        [OutputConstructor]
        private AccountThrottleSettings(
            int burstLimit,
            double rateLimit)
        {
            BurstLimit = burstLimit;
            RateLimit = rateLimit;
        }
    }
    }
}
