// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.WafRegional.Outputs
{

    [OutputType]
    public sealed class WebAclRule
    {
        /// <summary>
        /// Configuration block of the action that CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Not used if `type` is `GROUP`. Detailed below.
        /// </summary>
        public readonly Outputs.WebAclRuleAction? Action;
        /// <summary>
        /// Configuration block of the override the action that a group requests CloudFront or AWS WAF takes when a web request matches the conditions in the rule.  Only used if `type` is `GROUP`. Detailed below.
        /// </summary>
        public readonly Outputs.WebAclRuleOverrideAction? OverrideAction;
        /// <summary>
        /// Specifies the order in which the rules in a WebACL are evaluated.
        /// Rules with a lower value are evaluated before rules with a higher value.
        /// </summary>
        public readonly int Priority;
        /// <summary>
        /// ID of the associated WAF (Regional) rule (e.g. [`aws.wafregional.Rule`](https://www.terraform.io/docs/providers/aws/r/wafregional_rule.html)). WAF (Global) rules cannot be used.
        /// </summary>
        public readonly string RuleId;
        /// <summary>
        /// Specifies how you want AWS WAF Regional to respond to requests that match the settings in a rule. e.g. `ALLOW`, `BLOCK` or `COUNT`
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private WebAclRule(
            Outputs.WebAclRuleAction? action,

            Outputs.WebAclRuleOverrideAction? overrideAction,

            int priority,

            string ruleId,

            string? type)
        {
            Action = action;
            OverrideAction = overrideAction;
            Priority = priority;
            RuleId = ruleId;
            Type = type;
        }
    }
}