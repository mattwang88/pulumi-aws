// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package route53

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// `route53.Zone` provides details about a specific Route 53 Hosted Zone.
//
// This data source allows to find a Hosted Zone ID given Hosted Zone name and certain search criteria.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/route53_zone.html.markdown.
func LookupZone(ctx *pulumi.Context, args *LookupZoneArgs, opts ...pulumi.InvokeOption) (*LookupZoneResult, error) {
	var rv LookupZoneResult
	err := ctx.Invoke("aws:route53/getZone:getZone", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getZone.
type LookupZoneArgs struct {
	// The Hosted Zone name of the desired Hosted Zone.
	Name *string `pulumi:"name"`
	// Used with `name` field to get a private Hosted Zone.
	PrivateZone *bool `pulumi:"privateZone"`
	// The number of Record Set in the Hosted Zone.
	ResourceRecordSetCount *int `pulumi:"resourceRecordSetCount"`
	// Used with `name` field. A mapping of tags, each pair of which must exactly match a pair on the desired Hosted Zone.
	Tags map[string]interface{} `pulumi:"tags"`
	// Used with `name` field to get a private Hosted Zone associated with the vpcId (in this case, privateZone is not mandatory).
	VpcId *string `pulumi:"vpcId"`
	// The Hosted Zone id of the desired Hosted Zone.
	ZoneId *string `pulumi:"zoneId"`
}

// A collection of values returned by getZone.
type LookupZoneResult struct {
	// Caller Reference of the Hosted Zone.
	CallerReference string `pulumi:"callerReference"`
	// The comment field of the Hosted Zone.
	Comment string `pulumi:"comment"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The description provided by the service that created the Hosted Zone (e.g. `arn:aws:servicediscovery:us-east-1:1234567890:namespace/ns-xxxxxxxxxxxxxxxx`).
	LinkedServiceDescription string `pulumi:"linkedServiceDescription"`
	// The service that created the Hosted Zone (e.g. `servicediscovery.amazonaws.com`).
	LinkedServicePrincipal string `pulumi:"linkedServicePrincipal"`
	Name                   string `pulumi:"name"`
	// The list of DNS name servers for the Hosted Zone.
	NameServers []string `pulumi:"nameServers"`
	PrivateZone *bool    `pulumi:"privateZone"`
	// The number of Record Set in the Hosted Zone.
	ResourceRecordSetCount int                    `pulumi:"resourceRecordSetCount"`
	Tags                   map[string]interface{} `pulumi:"tags"`
	VpcId                  string                 `pulumi:"vpcId"`
	ZoneId                 string                 `pulumi:"zoneId"`
}
