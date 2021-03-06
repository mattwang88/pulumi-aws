// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package kms

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a resource-based access control mechanism for a KMS customer master key.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/kms_grant.html.markdown.
type Grant struct {
	pulumi.CustomResourceState

	// A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
	Constraints GrantConstraintArrayOutput `pulumi:"constraints"`
	// A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
	// * `retireOnDelete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
	// See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
	GrantCreationTokens pulumi.StringArrayOutput `pulumi:"grantCreationTokens"`
	// The unique identifier for the grant.
	GrantId pulumi.StringOutput `pulumi:"grantId"`
	// The grant token for the created grant. For more information, see [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token).
	GrantToken pulumi.StringOutput `pulumi:"grantToken"`
	// The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	GranteePrincipal pulumi.StringOutput `pulumi:"granteePrincipal"`
	// The unique identifier for the customer master key (CMK) that the grant applies to. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN.
	KeyId pulumi.StringOutput `pulumi:"keyId"`
	// A friendly name for identifying the grant.
	Name pulumi.StringOutput `pulumi:"name"`
	// A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
	Operations     pulumi.StringArrayOutput `pulumi:"operations"`
	RetireOnDelete pulumi.BoolPtrOutput     `pulumi:"retireOnDelete"`
	// The principal that is given permission to retire the grant by using RetireGrant operation in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	RetiringPrincipal pulumi.StringPtrOutput `pulumi:"retiringPrincipal"`
}

// NewGrant registers a new resource with the given unique name, arguments, and options.
func NewGrant(ctx *pulumi.Context,
	name string, args *GrantArgs, opts ...pulumi.ResourceOption) (*Grant, error) {
	if args == nil || args.GranteePrincipal == nil {
		return nil, errors.New("missing required argument 'GranteePrincipal'")
	}
	if args == nil || args.KeyId == nil {
		return nil, errors.New("missing required argument 'KeyId'")
	}
	if args == nil || args.Operations == nil {
		return nil, errors.New("missing required argument 'Operations'")
	}
	if args == nil {
		args = &GrantArgs{}
	}
	var resource Grant
	err := ctx.RegisterResource("aws:kms/grant:Grant", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetGrant gets an existing Grant resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetGrant(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *GrantState, opts ...pulumi.ResourceOption) (*Grant, error) {
	var resource Grant
	err := ctx.ReadResource("aws:kms/grant:Grant", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Grant resources.
type grantState struct {
	// A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
	Constraints []GrantConstraint `pulumi:"constraints"`
	// A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
	// * `retireOnDelete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
	// See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
	GrantCreationTokens []string `pulumi:"grantCreationTokens"`
	// The unique identifier for the grant.
	GrantId *string `pulumi:"grantId"`
	// The grant token for the created grant. For more information, see [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token).
	GrantToken *string `pulumi:"grantToken"`
	// The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	GranteePrincipal *string `pulumi:"granteePrincipal"`
	// The unique identifier for the customer master key (CMK) that the grant applies to. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN.
	KeyId *string `pulumi:"keyId"`
	// A friendly name for identifying the grant.
	Name *string `pulumi:"name"`
	// A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
	Operations     []string `pulumi:"operations"`
	RetireOnDelete *bool    `pulumi:"retireOnDelete"`
	// The principal that is given permission to retire the grant by using RetireGrant operation in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	RetiringPrincipal *string `pulumi:"retiringPrincipal"`
}

type GrantState struct {
	// A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
	Constraints GrantConstraintArrayInput
	// A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
	// * `retireOnDelete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
	// See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
	GrantCreationTokens pulumi.StringArrayInput
	// The unique identifier for the grant.
	GrantId pulumi.StringPtrInput
	// The grant token for the created grant. For more information, see [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token).
	GrantToken pulumi.StringPtrInput
	// The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	GranteePrincipal pulumi.StringPtrInput
	// The unique identifier for the customer master key (CMK) that the grant applies to. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN.
	KeyId pulumi.StringPtrInput
	// A friendly name for identifying the grant.
	Name pulumi.StringPtrInput
	// A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
	Operations     pulumi.StringArrayInput
	RetireOnDelete pulumi.BoolPtrInput
	// The principal that is given permission to retire the grant by using RetireGrant operation in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	RetiringPrincipal pulumi.StringPtrInput
}

func (GrantState) ElementType() reflect.Type {
	return reflect.TypeOf((*grantState)(nil)).Elem()
}

type grantArgs struct {
	// A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
	Constraints []GrantConstraint `pulumi:"constraints"`
	// A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
	// * `retireOnDelete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
	// See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
	GrantCreationTokens []string `pulumi:"grantCreationTokens"`
	// The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	GranteePrincipal string `pulumi:"granteePrincipal"`
	// The unique identifier for the customer master key (CMK) that the grant applies to. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN.
	KeyId string `pulumi:"keyId"`
	// A friendly name for identifying the grant.
	Name *string `pulumi:"name"`
	// A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
	Operations     []string `pulumi:"operations"`
	RetireOnDelete *bool    `pulumi:"retireOnDelete"`
	// The principal that is given permission to retire the grant by using RetireGrant operation in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	RetiringPrincipal *string `pulumi:"retiringPrincipal"`
}

// The set of arguments for constructing a Grant resource.
type GrantArgs struct {
	// A structure that you can use to allow certain operations in the grant only when the desired encryption context is present. For more information about encryption context, see [Encryption Context](http://docs.aws.amazon.com/kms/latest/developerguide/encryption-context.html).
	Constraints GrantConstraintArrayInput
	// A list of grant tokens to be used when creating the grant. See [Grant Tokens](http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token) for more information about grant tokens.
	// * `retireOnDelete` -(Defaults to false, Forces new resources) If set to false (the default) the grants will be revoked upon deletion, and if set to true the grants will try to be retired upon deletion. Note that retiring grants requires special permissions, hence why we default to revoking grants.
	// See [RetireGrant](https://docs.aws.amazon.com/kms/latest/APIReference/API_RetireGrant.html) for more information.
	GrantCreationTokens pulumi.StringArrayInput
	// The principal that is given permission to perform the operations that the grant permits in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	GranteePrincipal pulumi.StringInput
	// The unique identifier for the customer master key (CMK) that the grant applies to. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN.
	KeyId pulumi.StringInput
	// A friendly name for identifying the grant.
	Name pulumi.StringPtrInput
	// A list of operations that the grant permits. The permitted values are: `Decrypt, Encrypt, GenerateDataKey, GenerateDataKeyWithoutPlaintext, ReEncryptFrom, ReEncryptTo, CreateGrant, RetireGrant, DescribeKey`
	Operations     pulumi.StringArrayInput
	RetireOnDelete pulumi.BoolPtrInput
	// The principal that is given permission to retire the grant by using RetireGrant operation in ARN format. Note that due to eventual consistency issues around IAM principals, the state may not always be refreshed to reflect what is true in AWS.
	RetiringPrincipal pulumi.StringPtrInput
}

func (GrantArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*grantArgs)(nil)).Elem()
}
