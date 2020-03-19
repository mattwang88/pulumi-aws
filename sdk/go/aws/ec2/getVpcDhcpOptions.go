// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package ec2

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Retrieve information about an EC2 DHCP Options configuration.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/vpc_dhcp_options.html.markdown.
func LookupVpcDhcpOptions(ctx *pulumi.Context, args *LookupVpcDhcpOptionsArgs, opts ...pulumi.InvokeOption) (*LookupVpcDhcpOptionsResult, error) {
	var rv LookupVpcDhcpOptionsResult
	err := ctx.Invoke("aws:ec2/getVpcDhcpOptions:getVpcDhcpOptions", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getVpcDhcpOptions.
type LookupVpcDhcpOptionsArgs struct {
	// The EC2 DHCP Options ID.
	DhcpOptionsId *string `pulumi:"dhcpOptionsId"`
	// List of custom filters as described below.
	Filters []GetVpcDhcpOptionsFilter `pulumi:"filters"`
	Tags    map[string]interface{}    `pulumi:"tags"`
}

// A collection of values returned by getVpcDhcpOptions.
type LookupVpcDhcpOptionsResult struct {
	// EC2 DHCP Options ID
	DhcpOptionsId string `pulumi:"dhcpOptionsId"`
	// The suffix domain name to used when resolving non Fully Qualified Domain Names. e.g. the `search` value in the `/etc/resolv.conf` file.
	DomainName string `pulumi:"domainName"`
	// List of name servers.
	DomainNameServers []string                  `pulumi:"domainNameServers"`
	Filters           []GetVpcDhcpOptionsFilter `pulumi:"filters"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// List of NETBIOS name servers.
	NetbiosNameServers []string `pulumi:"netbiosNameServers"`
	// The NetBIOS node type (1, 2, 4, or 8). For more information about these node types, see [RFC 2132](http://www.ietf.org/rfc/rfc2132.txt).
	NetbiosNodeType string `pulumi:"netbiosNodeType"`
	// List of NTP servers.
	NtpServers []string `pulumi:"ntpServers"`
	// The ID of the AWS account that owns the DHCP options set.
	OwnerId string `pulumi:"ownerId"`
	// A mapping of tags assigned to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
}
