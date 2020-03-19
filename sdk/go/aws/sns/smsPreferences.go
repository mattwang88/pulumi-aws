// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package sns

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a way to set SNS SMS preferences.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/sns_sms_preferences.html.markdown.
type SmsPreferences struct {
	pulumi.CustomResourceState

	// A string, such as your business brand, that is displayed as the sender on the receiving device.
	DefaultSenderId pulumi.StringPtrOutput `pulumi:"defaultSenderId"`
	// The type of SMS message that you will send by default. Possible values are: Promotional, Transactional
	DefaultSmsType pulumi.StringPtrOutput `pulumi:"defaultSmsType"`
	// The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.
	DeliveryStatusIamRoleArn pulumi.StringPtrOutput `pulumi:"deliveryStatusIamRoleArn"`
	// The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.
	DeliveryStatusSuccessSamplingRate pulumi.StringPtrOutput `pulumi:"deliveryStatusSuccessSamplingRate"`
	// The maximum amount in USD that you are willing to spend each month to send SMS messages.
	MonthlySpendLimit pulumi.StringPtrOutput `pulumi:"monthlySpendLimit"`
	// The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.
	UsageReportS3Bucket pulumi.StringPtrOutput `pulumi:"usageReportS3Bucket"`
}

// NewSmsPreferences registers a new resource with the given unique name, arguments, and options.
func NewSmsPreferences(ctx *pulumi.Context,
	name string, args *SmsPreferencesArgs, opts ...pulumi.ResourceOption) (*SmsPreferences, error) {
	if args == nil {
		args = &SmsPreferencesArgs{}
	}
	var resource SmsPreferences
	err := ctx.RegisterResource("aws:sns/smsPreferences:SmsPreferences", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSmsPreferences gets an existing SmsPreferences resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSmsPreferences(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SmsPreferencesState, opts ...pulumi.ResourceOption) (*SmsPreferences, error) {
	var resource SmsPreferences
	err := ctx.ReadResource("aws:sns/smsPreferences:SmsPreferences", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SmsPreferences resources.
type smsPreferencesState struct {
	// A string, such as your business brand, that is displayed as the sender on the receiving device.
	DefaultSenderId *string `pulumi:"defaultSenderId"`
	// The type of SMS message that you will send by default. Possible values are: Promotional, Transactional
	DefaultSmsType *string `pulumi:"defaultSmsType"`
	// The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.
	DeliveryStatusIamRoleArn *string `pulumi:"deliveryStatusIamRoleArn"`
	// The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.
	DeliveryStatusSuccessSamplingRate *string `pulumi:"deliveryStatusSuccessSamplingRate"`
	// The maximum amount in USD that you are willing to spend each month to send SMS messages.
	MonthlySpendLimit *string `pulumi:"monthlySpendLimit"`
	// The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.
	UsageReportS3Bucket *string `pulumi:"usageReportS3Bucket"`
}

type SmsPreferencesState struct {
	// A string, such as your business brand, that is displayed as the sender on the receiving device.
	DefaultSenderId pulumi.StringPtrInput
	// The type of SMS message that you will send by default. Possible values are: Promotional, Transactional
	DefaultSmsType pulumi.StringPtrInput
	// The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.
	DeliveryStatusIamRoleArn pulumi.StringPtrInput
	// The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.
	DeliveryStatusSuccessSamplingRate pulumi.StringPtrInput
	// The maximum amount in USD that you are willing to spend each month to send SMS messages.
	MonthlySpendLimit pulumi.StringPtrInput
	// The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.
	UsageReportS3Bucket pulumi.StringPtrInput
}

func (SmsPreferencesState) ElementType() reflect.Type {
	return reflect.TypeOf((*smsPreferencesState)(nil)).Elem()
}

type smsPreferencesArgs struct {
	// A string, such as your business brand, that is displayed as the sender on the receiving device.
	DefaultSenderId *string `pulumi:"defaultSenderId"`
	// The type of SMS message that you will send by default. Possible values are: Promotional, Transactional
	DefaultSmsType *string `pulumi:"defaultSmsType"`
	// The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.
	DeliveryStatusIamRoleArn *string `pulumi:"deliveryStatusIamRoleArn"`
	// The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.
	DeliveryStatusSuccessSamplingRate *string `pulumi:"deliveryStatusSuccessSamplingRate"`
	// The maximum amount in USD that you are willing to spend each month to send SMS messages.
	MonthlySpendLimit *string `pulumi:"monthlySpendLimit"`
	// The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.
	UsageReportS3Bucket *string `pulumi:"usageReportS3Bucket"`
}

// The set of arguments for constructing a SmsPreferences resource.
type SmsPreferencesArgs struct {
	// A string, such as your business brand, that is displayed as the sender on the receiving device.
	DefaultSenderId pulumi.StringPtrInput
	// The type of SMS message that you will send by default. Possible values are: Promotional, Transactional
	DefaultSmsType pulumi.StringPtrInput
	// The ARN of the IAM role that allows Amazon SNS to write logs about SMS deliveries in CloudWatch Logs.
	DeliveryStatusIamRoleArn pulumi.StringPtrInput
	// The percentage of successful SMS deliveries for which Amazon SNS will write logs in CloudWatch Logs. The value must be between 0 and 100.
	DeliveryStatusSuccessSamplingRate pulumi.StringPtrInput
	// The maximum amount in USD that you are willing to spend each month to send SMS messages.
	MonthlySpendLimit pulumi.StringPtrInput
	// The name of the Amazon S3 bucket to receive daily SMS usage reports from Amazon SNS.
	UsageReportS3Bucket pulumi.StringPtrInput
}

func (SmsPreferencesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*smsPreferencesArgs)(nil)).Elem()
}
