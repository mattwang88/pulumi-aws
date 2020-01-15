// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2.Outputs
{

    [OutputType]
    public sealed class LaunchTemplateCapacityReservationSpecification
    {
        public readonly string? CapacityReservationPreference;
        public readonly Outputs.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget? CapacityReservationTarget;

        [OutputConstructor]
        private LaunchTemplateCapacityReservationSpecification(
            string? capacityReservationPreference,

            Outputs.LaunchTemplateCapacityReservationSpecificationCapacityReservationTarget? capacityReservationTarget)
        {
            CapacityReservationPreference = capacityReservationPreference;
            CapacityReservationTarget = capacityReservationTarget;
        }
    }
}