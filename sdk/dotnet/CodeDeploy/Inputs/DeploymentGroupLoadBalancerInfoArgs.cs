// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.CodeDeploy.Inputs
{

    public sealed class DeploymentGroupLoadBalancerInfoArgs : Pulumi.ResourceArgs
    {
        [Input("elbInfos")]
        private InputList<Inputs.DeploymentGroupLoadBalancerInfoElbInfoArgs>? _elbInfos;

        /// <summary>
        /// The Classic Elastic Load Balancer to use in a deployment. Conflicts with `target_group_info` and `target_group_pair_info`.
        /// </summary>
        public InputList<Inputs.DeploymentGroupLoadBalancerInfoElbInfoArgs> ElbInfos
        {
            get => _elbInfos ?? (_elbInfos = new InputList<Inputs.DeploymentGroupLoadBalancerInfoElbInfoArgs>());
            set => _elbInfos = value;
        }

        [Input("targetGroupInfos")]
        private InputList<Inputs.DeploymentGroupLoadBalancerInfoTargetGroupInfoArgs>? _targetGroupInfos;

        /// <summary>
        /// The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with `elb_info` and `target_group_pair_info`.
        /// </summary>
        public InputList<Inputs.DeploymentGroupLoadBalancerInfoTargetGroupInfoArgs> TargetGroupInfos
        {
            get => _targetGroupInfos ?? (_targetGroupInfos = new InputList<Inputs.DeploymentGroupLoadBalancerInfoTargetGroupInfoArgs>());
            set => _targetGroupInfos = value;
        }

        /// <summary>
        /// The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with `elb_info` and `target_group_info`.
        /// </summary>
        [Input("targetGroupPairInfo")]
        public Input<Inputs.DeploymentGroupLoadBalancerInfoTargetGroupPairInfoArgs>? TargetGroupPairInfo { get; set; }

        public DeploymentGroupLoadBalancerInfoArgs()
        {
        }
    }
}