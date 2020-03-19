// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package cognito

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to get a list of cognito user pools.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/cognito_user_pools.markdown.
func GetUserPools(ctx *pulumi.Context, args *GetUserPoolsArgs, opts ...pulumi.InvokeOption) (*GetUserPoolsResult, error) {
	var rv GetUserPoolsResult
	err := ctx.Invoke("aws:cognito/getUserPools:getUserPools", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getUserPools.
type GetUserPoolsArgs struct {
	// Name of the cognito user pools. Name is not a unique attribute for cognito user pool, so multiple pools might be returned with given name.
	Name string `pulumi:"name"`
}

// A collection of values returned by getUserPools.
type GetUserPoolsResult struct {
	Arns []string `pulumi:"arns"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The list of cognito user pool ids.
	Ids  []string `pulumi:"ids"`
	Name string   `pulumi:"name"`
}
