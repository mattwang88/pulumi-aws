// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package sns

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an SNS platform application resource
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/sns_platform_application.html.markdown.
type PlatformApplication struct {
	pulumi.CustomResourceState

	// The ARN of the SNS platform application
	Arn pulumi.StringOutput `pulumi:"arn"`
	// SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.
	EventDeliveryFailureTopicArn pulumi.StringPtrOutput `pulumi:"eventDeliveryFailureTopicArn"`
	// SNS Topic triggered when a new platform endpoint is added to your platform application.
	EventEndpointCreatedTopicArn pulumi.StringPtrOutput `pulumi:"eventEndpointCreatedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is deleted from your platform application.
	EventEndpointDeletedTopicArn pulumi.StringPtrOutput `pulumi:"eventEndpointDeletedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is changed from your platform application.
	EventEndpointUpdatedTopicArn pulumi.StringPtrOutput `pulumi:"eventEndpointUpdatedTopicArn"`
	// The IAM role permitted to receive failure feedback for this application.
	FailureFeedbackRoleArn pulumi.StringPtrOutput `pulumi:"failureFeedbackRoleArn"`
	// The friendly name for the SNS platform application
	Name pulumi.StringOutput `pulumi:"name"`
	// The platform that the app is registered with. See [Platform][1] for supported platforms.
	Platform pulumi.StringOutput `pulumi:"platform"`
	// Application Platform credential. See [Credential][1] for type of credential required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformCredential pulumi.StringOutput `pulumi:"platformCredential"`
	// Application Platform principal. See [Principal][2] for type of principal required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformPrincipal pulumi.StringPtrOutput `pulumi:"platformPrincipal"`
	// The IAM role permitted to receive success feedback for this application.
	SuccessFeedbackRoleArn pulumi.StringPtrOutput `pulumi:"successFeedbackRoleArn"`
	// The percentage of success to sample (0-100)
	SuccessFeedbackSampleRate pulumi.StringPtrOutput `pulumi:"successFeedbackSampleRate"`
}

// NewPlatformApplication registers a new resource with the given unique name, arguments, and options.
func NewPlatformApplication(ctx *pulumi.Context,
	name string, args *PlatformApplicationArgs, opts ...pulumi.ResourceOption) (*PlatformApplication, error) {
	if args == nil || args.Platform == nil {
		return nil, errors.New("missing required argument 'Platform'")
	}
	if args == nil || args.PlatformCredential == nil {
		return nil, errors.New("missing required argument 'PlatformCredential'")
	}
	if args == nil {
		args = &PlatformApplicationArgs{}
	}
	var resource PlatformApplication
	err := ctx.RegisterResource("aws:sns/platformApplication:PlatformApplication", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPlatformApplication gets an existing PlatformApplication resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPlatformApplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PlatformApplicationState, opts ...pulumi.ResourceOption) (*PlatformApplication, error) {
	var resource PlatformApplication
	err := ctx.ReadResource("aws:sns/platformApplication:PlatformApplication", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PlatformApplication resources.
type platformApplicationState struct {
	// The ARN of the SNS platform application
	Arn *string `pulumi:"arn"`
	// SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.
	EventDeliveryFailureTopicArn *string `pulumi:"eventDeliveryFailureTopicArn"`
	// SNS Topic triggered when a new platform endpoint is added to your platform application.
	EventEndpointCreatedTopicArn *string `pulumi:"eventEndpointCreatedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is deleted from your platform application.
	EventEndpointDeletedTopicArn *string `pulumi:"eventEndpointDeletedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is changed from your platform application.
	EventEndpointUpdatedTopicArn *string `pulumi:"eventEndpointUpdatedTopicArn"`
	// The IAM role permitted to receive failure feedback for this application.
	FailureFeedbackRoleArn *string `pulumi:"failureFeedbackRoleArn"`
	// The friendly name for the SNS platform application
	Name *string `pulumi:"name"`
	// The platform that the app is registered with. See [Platform][1] for supported platforms.
	Platform *string `pulumi:"platform"`
	// Application Platform credential. See [Credential][1] for type of credential required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformCredential *string `pulumi:"platformCredential"`
	// Application Platform principal. See [Principal][2] for type of principal required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformPrincipal *string `pulumi:"platformPrincipal"`
	// The IAM role permitted to receive success feedback for this application.
	SuccessFeedbackRoleArn *string `pulumi:"successFeedbackRoleArn"`
	// The percentage of success to sample (0-100)
	SuccessFeedbackSampleRate *string `pulumi:"successFeedbackSampleRate"`
}

type PlatformApplicationState struct {
	// The ARN of the SNS platform application
	Arn pulumi.StringPtrInput
	// SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.
	EventDeliveryFailureTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when a new platform endpoint is added to your platform application.
	EventEndpointCreatedTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when an existing platform endpoint is deleted from your platform application.
	EventEndpointDeletedTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when an existing platform endpoint is changed from your platform application.
	EventEndpointUpdatedTopicArn pulumi.StringPtrInput
	// The IAM role permitted to receive failure feedback for this application.
	FailureFeedbackRoleArn pulumi.StringPtrInput
	// The friendly name for the SNS platform application
	Name pulumi.StringPtrInput
	// The platform that the app is registered with. See [Platform][1] for supported platforms.
	Platform pulumi.StringPtrInput
	// Application Platform credential. See [Credential][1] for type of credential required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformCredential pulumi.StringPtrInput
	// Application Platform principal. See [Principal][2] for type of principal required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformPrincipal pulumi.StringPtrInput
	// The IAM role permitted to receive success feedback for this application.
	SuccessFeedbackRoleArn pulumi.StringPtrInput
	// The percentage of success to sample (0-100)
	SuccessFeedbackSampleRate pulumi.StringPtrInput
}

func (PlatformApplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*platformApplicationState)(nil)).Elem()
}

type platformApplicationArgs struct {
	// SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.
	EventDeliveryFailureTopicArn *string `pulumi:"eventDeliveryFailureTopicArn"`
	// SNS Topic triggered when a new platform endpoint is added to your platform application.
	EventEndpointCreatedTopicArn *string `pulumi:"eventEndpointCreatedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is deleted from your platform application.
	EventEndpointDeletedTopicArn *string `pulumi:"eventEndpointDeletedTopicArn"`
	// SNS Topic triggered when an existing platform endpoint is changed from your platform application.
	EventEndpointUpdatedTopicArn *string `pulumi:"eventEndpointUpdatedTopicArn"`
	// The IAM role permitted to receive failure feedback for this application.
	FailureFeedbackRoleArn *string `pulumi:"failureFeedbackRoleArn"`
	// The friendly name for the SNS platform application
	Name *string `pulumi:"name"`
	// The platform that the app is registered with. See [Platform][1] for supported platforms.
	Platform string `pulumi:"platform"`
	// Application Platform credential. See [Credential][1] for type of credential required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformCredential string `pulumi:"platformCredential"`
	// Application Platform principal. See [Principal][2] for type of principal required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformPrincipal *string `pulumi:"platformPrincipal"`
	// The IAM role permitted to receive success feedback for this application.
	SuccessFeedbackRoleArn *string `pulumi:"successFeedbackRoleArn"`
	// The percentage of success to sample (0-100)
	SuccessFeedbackSampleRate *string `pulumi:"successFeedbackSampleRate"`
}

// The set of arguments for constructing a PlatformApplication resource.
type PlatformApplicationArgs struct {
	// SNS Topic triggered when a delivery to any of the platform endpoints associated with your platform application encounters a permanent failure.
	EventDeliveryFailureTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when a new platform endpoint is added to your platform application.
	EventEndpointCreatedTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when an existing platform endpoint is deleted from your platform application.
	EventEndpointDeletedTopicArn pulumi.StringPtrInput
	// SNS Topic triggered when an existing platform endpoint is changed from your platform application.
	EventEndpointUpdatedTopicArn pulumi.StringPtrInput
	// The IAM role permitted to receive failure feedback for this application.
	FailureFeedbackRoleArn pulumi.StringPtrInput
	// The friendly name for the SNS platform application
	Name pulumi.StringPtrInput
	// The platform that the app is registered with. See [Platform][1] for supported platforms.
	Platform pulumi.StringInput
	// Application Platform credential. See [Credential][1] for type of credential required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformCredential pulumi.StringInput
	// Application Platform principal. See [Principal][2] for type of principal required for platform. The value of this attribute when stored into the state is only a hash of the real value, so therefore it is not practical to use this as an attribute for other resources.
	PlatformPrincipal pulumi.StringPtrInput
	// The IAM role permitted to receive success feedback for this application.
	SuccessFeedbackRoleArn pulumi.StringPtrInput
	// The percentage of success to sample (0-100)
	SuccessFeedbackSampleRate pulumi.StringPtrInput
}

func (PlatformApplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*platformApplicationArgs)(nil)).Elem()
}
