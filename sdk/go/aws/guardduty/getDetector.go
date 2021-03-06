// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package guardduty

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Retrieve information about a GuardDuty detector.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/guardduty_detector.html.markdown.
func LookupDetector(ctx *pulumi.Context, args *LookupDetectorArgs, opts ...pulumi.InvokeOption) (*LookupDetectorResult, error) {
	var rv LookupDetectorResult
	err := ctx.Invoke("aws:guardduty/getDetector:getDetector", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDetector.
type LookupDetectorArgs struct {
	// The ID of the detector.
	Id *string `pulumi:"id"`
}

// A collection of values returned by getDetector.
type LookupDetectorResult struct {
	// The frequency of notifications sent about subsequent finding occurrences.
	FindingPublishingFrequency string  `pulumi:"findingPublishingFrequency"`
	Id                         *string `pulumi:"id"`
	// The service-linked role that grants GuardDuty access to the resources in the AWS account.
	ServiceRoleArn string `pulumi:"serviceRoleArn"`
	// The current status of the detector.
	Status string `pulumi:"status"`
}
