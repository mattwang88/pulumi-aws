// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package pinpoint

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Pinpoint App resource.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/pinpoint_app.markdown.
type App struct {
	pulumi.CustomResourceState

	// The Application ID of the Pinpoint App.
	ApplicationId pulumi.StringOutput `pulumi:"applicationId"`
	// Amazon Resource Name (ARN) of the PinPoint Application
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	CampaignHook AppCampaignHookPtrOutput `pulumi:"campaignHook"`
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	Limits AppLimitsPtrOutput `pulumi:"limits"`
	// The application name. By default generated by this provider
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the Pinpoint application. Conflicts with `name`
	NamePrefix pulumi.StringPtrOutput `pulumi:"namePrefix"`
	// The default quiet time for the app. Each campaign for this app sends no messages during this time unless the campaign overrides the default with a quiet time of its own
	QuietTime AppQuietTimePtrOutput `pulumi:"quietTime"`
	// Key-value mapping of resource tags
	Tags pulumi.MapOutput `pulumi:"tags"`
}

// NewApp registers a new resource with the given unique name, arguments, and options.
func NewApp(ctx *pulumi.Context,
	name string, args *AppArgs, opts ...pulumi.ResourceOption) (*App, error) {
	if args == nil {
		args = &AppArgs{}
	}
	var resource App
	err := ctx.RegisterResource("aws:pinpoint/app:App", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApp gets an existing App resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApp(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AppState, opts ...pulumi.ResourceOption) (*App, error) {
	var resource App
	err := ctx.ReadResource("aws:pinpoint/app:App", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering App resources.
type appState struct {
	// The Application ID of the Pinpoint App.
	ApplicationId *string `pulumi:"applicationId"`
	// Amazon Resource Name (ARN) of the PinPoint Application
	Arn *string `pulumi:"arn"`
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	CampaignHook *AppCampaignHook `pulumi:"campaignHook"`
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	Limits *AppLimits `pulumi:"limits"`
	// The application name. By default generated by this provider
	Name *string `pulumi:"name"`
	// The name of the Pinpoint application. Conflicts with `name`
	NamePrefix *string `pulumi:"namePrefix"`
	// The default quiet time for the app. Each campaign for this app sends no messages during this time unless the campaign overrides the default with a quiet time of its own
	QuietTime *AppQuietTime `pulumi:"quietTime"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
}

type AppState struct {
	// The Application ID of the Pinpoint App.
	ApplicationId pulumi.StringPtrInput
	// Amazon Resource Name (ARN) of the PinPoint Application
	Arn pulumi.StringPtrInput
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	CampaignHook AppCampaignHookPtrInput
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	Limits AppLimitsPtrInput
	// The application name. By default generated by this provider
	Name pulumi.StringPtrInput
	// The name of the Pinpoint application. Conflicts with `name`
	NamePrefix pulumi.StringPtrInput
	// The default quiet time for the app. Each campaign for this app sends no messages during this time unless the campaign overrides the default with a quiet time of its own
	QuietTime AppQuietTimePtrInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
}

func (AppState) ElementType() reflect.Type {
	return reflect.TypeOf((*appState)(nil)).Elem()
}

type appArgs struct {
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	CampaignHook *AppCampaignHook `pulumi:"campaignHook"`
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	Limits *AppLimits `pulumi:"limits"`
	// The application name. By default generated by this provider
	Name *string `pulumi:"name"`
	// The name of the Pinpoint application. Conflicts with `name`
	NamePrefix *string `pulumi:"namePrefix"`
	// The default quiet time for the app. Each campaign for this app sends no messages during this time unless the campaign overrides the default with a quiet time of its own
	QuietTime *AppQuietTime `pulumi:"quietTime"`
	// Key-value mapping of resource tags
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a App resource.
type AppArgs struct {
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	CampaignHook AppCampaignHookPtrInput
	// The default campaign limits for the app. These limits apply to each campaign for the app, unless the campaign overrides the default with limits of its own
	Limits AppLimitsPtrInput
	// The application name. By default generated by this provider
	Name pulumi.StringPtrInput
	// The name of the Pinpoint application. Conflicts with `name`
	NamePrefix pulumi.StringPtrInput
	// The default quiet time for the app. Each campaign for this app sends no messages during this time unless the campaign overrides the default with a quiet time of its own
	QuietTime AppQuietTimePtrInput
	// Key-value mapping of resource tags
	Tags pulumi.MapInput
}

func (AppArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*appArgs)(nil)).Elem()
}
