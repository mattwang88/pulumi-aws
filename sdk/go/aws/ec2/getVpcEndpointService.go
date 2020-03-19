// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ec2

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// The VPC Endpoint Service data source details about a specific service that
// can be specified when creating a VPC endpoint within the region configured in the provider.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/vpc_endpoint_service.html.markdown.
func LookupVpcEndpointService(ctx *pulumi.Context, args *LookupVpcEndpointServiceArgs, opts ...pulumi.InvokeOption) (*LookupVpcEndpointServiceResult, error) {
	var rv LookupVpcEndpointServiceResult
	err := ctx.Invoke("aws:ec2/getVpcEndpointService:getVpcEndpointService", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcEndpointService.
type LookupVpcEndpointServiceArgs struct {
	// The common name of an AWS service (e.g. `s3`).
	Service *string `pulumi:"service"`
	// The service name that can be specified when creating a VPC endpoint.
	ServiceName *string                `pulumi:"serviceName"`
	Tags        map[string]interface{} `pulumi:"tags"`
}

// A collection of values returned by getVpcEndpointService.
type LookupVpcEndpointServiceResult struct {
	// Whether or not VPC endpoint connection requests to the service must be accepted by the service owner - `true` or `false`.
	AcceptanceRequired bool `pulumi:"acceptanceRequired"`
	// The Availability Zones in which the service is available.
	AvailabilityZones []string `pulumi:"availabilityZones"`
	// The DNS names for the service.
	BaseEndpointDnsNames []string `pulumi:"baseEndpointDnsNames"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Whether or not the service manages its VPC endpoints - `true` or `false`.
	ManagesVpcEndpoints bool `pulumi:"managesVpcEndpoints"`
	// The AWS account ID of the service owner or `amazon`.
	Owner string `pulumi:"owner"`
	// The private DNS name for the service.
	PrivateDnsName string  `pulumi:"privateDnsName"`
	Service        *string `pulumi:"service"`
	// The ID of the endpoint service.
	ServiceId   string `pulumi:"serviceId"`
	ServiceName string `pulumi:"serviceName"`
	// The service type, `Gateway` or `Interface`.
	ServiceType string `pulumi:"serviceType"`
	// A mapping of tags assigned to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
	// Whether or not the service supports endpoint policies - `true` or `false`.
	VpcEndpointPolicySupported bool `pulumi:"vpcEndpointPolicySupported"`
}
