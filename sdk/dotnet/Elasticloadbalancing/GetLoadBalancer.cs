// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Elasticloadbalancing
{
    public static partial class Invokes
    {
        /// <summary>
        /// Provides information about a "classic" Elastic Load Balancer (ELB).
        /// See [LB Data Source](https://www.terraform.io/docs/providers/aws/d/lb.html) if you are looking for "v2"
        /// Application Load Balancer (ALB) or Network Load Balancer (NLB).
        /// 
        /// This data source can prove useful when a module accepts an LB as an input
        /// variable and needs to, for example, determine the security groups associated
        /// with it, etc.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/elb_legacy.html.markdown.
        /// </summary>
        public static Task<GetLoadBalancerResult> GetLoadBalancer(GetLoadBalancerArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetLoadBalancerResult>("aws:elasticloadbalancing/getLoadBalancer:getLoadBalancer", args ?? InvokeArgs.Empty, options.WithVersion());
    }

    public sealed class GetLoadBalancerArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique name of the load balancer.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, object>? _tags;
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetLoadBalancerArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetLoadBalancerResult
    {
        public readonly Outputs.GetLoadBalancerAccessLogsResult AccessLogs;
        public readonly ImmutableArray<string> AvailabilityZones;
        public readonly bool ConnectionDraining;
        public readonly int ConnectionDrainingTimeout;
        public readonly bool CrossZoneLoadBalancing;
        public readonly string DnsName;
        public readonly Outputs.GetLoadBalancerHealthCheckResult HealthCheck;
        public readonly int IdleTimeout;
        public readonly ImmutableArray<string> Instances;
        public readonly bool Internal;
        public readonly ImmutableArray<Outputs.GetLoadBalancerListenersResult> Listeners;
        public readonly string Name;
        public readonly ImmutableArray<string> SecurityGroups;
        public readonly string SourceSecurityGroup;
        public readonly string SourceSecurityGroupId;
        public readonly ImmutableArray<string> Subnets;
        public readonly ImmutableDictionary<string, object> Tags;
        public readonly string ZoneId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetLoadBalancerResult(
            Outputs.GetLoadBalancerAccessLogsResult accessLogs,
            ImmutableArray<string> availabilityZones,
            bool connectionDraining,
            int connectionDrainingTimeout,
            bool crossZoneLoadBalancing,
            string dnsName,
            Outputs.GetLoadBalancerHealthCheckResult healthCheck,
            int idleTimeout,
            ImmutableArray<string> instances,
            bool @internal,
            ImmutableArray<Outputs.GetLoadBalancerListenersResult> listeners,
            string name,
            ImmutableArray<string> securityGroups,
            string sourceSecurityGroup,
            string sourceSecurityGroupId,
            ImmutableArray<string> subnets,
            ImmutableDictionary<string, object> tags,
            string zoneId,
            string id)
        {
            AccessLogs = accessLogs;
            AvailabilityZones = availabilityZones;
            ConnectionDraining = connectionDraining;
            ConnectionDrainingTimeout = connectionDrainingTimeout;
            CrossZoneLoadBalancing = crossZoneLoadBalancing;
            DnsName = dnsName;
            HealthCheck = healthCheck;
            IdleTimeout = idleTimeout;
            Instances = instances;
            Internal = @internal;
            Listeners = listeners;
            Name = name;
            SecurityGroups = securityGroups;
            SourceSecurityGroup = sourceSecurityGroup;
            SourceSecurityGroupId = sourceSecurityGroupId;
            Subnets = subnets;
            Tags = tags;
            ZoneId = zoneId;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetLoadBalancerAccessLogsResult
    {
        public readonly string Bucket;
        public readonly string BucketPrefix;
        public readonly bool Enabled;
        public readonly int Interval;

        [OutputConstructor]
        private GetLoadBalancerAccessLogsResult(
            string bucket,
            string bucketPrefix,
            bool enabled,
            int interval)
        {
            Bucket = bucket;
            BucketPrefix = bucketPrefix;
            Enabled = enabled;
            Interval = interval;
        }
    }

    [OutputType]
    public sealed class GetLoadBalancerHealthCheckResult
    {
        public readonly int HealthyThreshold;
        public readonly int Interval;
        public readonly string Target;
        public readonly int Timeout;
        public readonly int UnhealthyThreshold;

        [OutputConstructor]
        private GetLoadBalancerHealthCheckResult(
            int healthyThreshold,
            int interval,
            string target,
            int timeout,
            int unhealthyThreshold)
        {
            HealthyThreshold = healthyThreshold;
            Interval = interval;
            Target = target;
            Timeout = timeout;
            UnhealthyThreshold = unhealthyThreshold;
        }
    }

    [OutputType]
    public sealed class GetLoadBalancerListenersResult
    {
        public readonly int InstancePort;
        public readonly string InstanceProtocol;
        public readonly int LbPort;
        public readonly string LbProtocol;
        public readonly string SslCertificateId;

        [OutputConstructor]
        private GetLoadBalancerListenersResult(
            int instancePort,
            string instanceProtocol,
            int lbPort,
            string lbProtocol,
            string sslCertificateId)
        {
            InstancePort = instancePort;
            InstanceProtocol = instanceProtocol;
            LbPort = lbPort;
            LbProtocol = lbProtocol;
            SslCertificateId = sslCertificateId;
        }
    }
    }
}
