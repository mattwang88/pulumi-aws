// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package eks

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an EKS Cluster.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/eks_cluster.html.markdown.
type Cluster struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the cluster.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Nested attribute containing `certificate-authority-data` for your cluster.
	CertificateAuthority ClusterCertificateAuthorityOutput `pulumi:"certificateAuthority"`
	CreatedAt            pulumi.StringOutput               `pulumi:"createdAt"`
	// A list of the desired control plane logging to enable. For more information, see [Amazon EKS Control Plane Logging](https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
	EnabledClusterLogTypes pulumi.StringArrayOutput `pulumi:"enabledClusterLogTypes"`
	// Configuration block with encryption configuration for the cluster. Only available on Kubernetes 1.13 and above clusters created after March 6, 2020. Detailed below.
	EncryptionConfig ClusterEncryptionConfigPtrOutput `pulumi:"encryptionConfig"`
	// The endpoint for your Kubernetes API server.
	Endpoint pulumi.StringOutput `pulumi:"endpoint"`
	// Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019.
	Identities ClusterIdentityArrayOutput `pulumi:"identities"`
	// Name of the cluster.
	Name pulumi.StringOutput `pulumi:"name"`
	// The platform version for the cluster.
	PlatformVersion pulumi.StringOutput `pulumi:"platformVersion"`
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding [`dependsOn`](https://www.terraform.io/docs/configuration/resources.html#depends_on-explicit-resource-dependencies) if using the [`iam.RolePolicy` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy.html) or [`iam.RolePolicyAttachment` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy_attachment.html), otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
	// The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
	Status pulumi.StringOutput `pulumi:"status"`
	// Key-value mapping of resource tags.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.
	Version pulumi.StringOutput `pulumi:"version"`
	// Nested argument for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see [Cluster VPC Considerations](https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html) and [Cluster Security Group Considerations](https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html) in the Amazon EKS User Guide. Configuration detailed below.
	VpcConfig ClusterVpcConfigOutput `pulumi:"vpcConfig"`
}

// NewCluster registers a new resource with the given unique name, arguments, and options.
func NewCluster(ctx *pulumi.Context,
	name string, args *ClusterArgs, opts ...pulumi.ResourceOption) (*Cluster, error) {
	if args == nil || args.RoleArn == nil {
		return nil, errors.New("missing required argument 'RoleArn'")
	}
	if args == nil || args.VpcConfig == nil {
		return nil, errors.New("missing required argument 'VpcConfig'")
	}
	if args == nil {
		args = &ClusterArgs{}
	}
	var resource Cluster
	err := ctx.RegisterResource("aws:eks/cluster:Cluster", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCluster gets an existing Cluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCluster(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterState, opts ...pulumi.ResourceOption) (*Cluster, error) {
	var resource Cluster
	err := ctx.ReadResource("aws:eks/cluster:Cluster", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Cluster resources.
type clusterState struct {
	// The Amazon Resource Name (ARN) of the cluster.
	Arn *string `pulumi:"arn"`
	// Nested attribute containing `certificate-authority-data` for your cluster.
	CertificateAuthority *ClusterCertificateAuthority `pulumi:"certificateAuthority"`
	CreatedAt            *string                      `pulumi:"createdAt"`
	// A list of the desired control plane logging to enable. For more information, see [Amazon EKS Control Plane Logging](https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
	EnabledClusterLogTypes []string `pulumi:"enabledClusterLogTypes"`
	// Configuration block with encryption configuration for the cluster. Only available on Kubernetes 1.13 and above clusters created after March 6, 2020. Detailed below.
	EncryptionConfig *ClusterEncryptionConfig `pulumi:"encryptionConfig"`
	// The endpoint for your Kubernetes API server.
	Endpoint *string `pulumi:"endpoint"`
	// Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019.
	Identities []ClusterIdentity `pulumi:"identities"`
	// Name of the cluster.
	Name *string `pulumi:"name"`
	// The platform version for the cluster.
	PlatformVersion *string `pulumi:"platformVersion"`
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding [`dependsOn`](https://www.terraform.io/docs/configuration/resources.html#depends_on-explicit-resource-dependencies) if using the [`iam.RolePolicy` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy.html) or [`iam.RolePolicyAttachment` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy_attachment.html), otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.
	RoleArn *string `pulumi:"roleArn"`
	// The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
	Status *string `pulumi:"status"`
	// Key-value mapping of resource tags.
	Tags map[string]interface{} `pulumi:"tags"`
	// Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.
	Version *string `pulumi:"version"`
	// Nested argument for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see [Cluster VPC Considerations](https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html) and [Cluster Security Group Considerations](https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html) in the Amazon EKS User Guide. Configuration detailed below.
	VpcConfig *ClusterVpcConfig `pulumi:"vpcConfig"`
}

type ClusterState struct {
	// The Amazon Resource Name (ARN) of the cluster.
	Arn pulumi.StringPtrInput
	// Nested attribute containing `certificate-authority-data` for your cluster.
	CertificateAuthority ClusterCertificateAuthorityPtrInput
	CreatedAt            pulumi.StringPtrInput
	// A list of the desired control plane logging to enable. For more information, see [Amazon EKS Control Plane Logging](https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
	EnabledClusterLogTypes pulumi.StringArrayInput
	// Configuration block with encryption configuration for the cluster. Only available on Kubernetes 1.13 and above clusters created after March 6, 2020. Detailed below.
	EncryptionConfig ClusterEncryptionConfigPtrInput
	// The endpoint for your Kubernetes API server.
	Endpoint pulumi.StringPtrInput
	// Nested attribute containing identity provider information for your cluster. Only available on Kubernetes version 1.13 and 1.14 clusters created or upgraded on or after September 3, 2019.
	Identities ClusterIdentityArrayInput
	// Name of the cluster.
	Name pulumi.StringPtrInput
	// The platform version for the cluster.
	PlatformVersion pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding [`dependsOn`](https://www.terraform.io/docs/configuration/resources.html#depends_on-explicit-resource-dependencies) if using the [`iam.RolePolicy` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy.html) or [`iam.RolePolicyAttachment` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy_attachment.html), otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.
	RoleArn pulumi.StringPtrInput
	// The status of the EKS cluster. One of `CREATING`, `ACTIVE`, `DELETING`, `FAILED`.
	Status pulumi.StringPtrInput
	// Key-value mapping of resource tags.
	Tags pulumi.MapInput
	// Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.
	Version pulumi.StringPtrInput
	// Nested argument for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see [Cluster VPC Considerations](https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html) and [Cluster Security Group Considerations](https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html) in the Amazon EKS User Guide. Configuration detailed below.
	VpcConfig ClusterVpcConfigPtrInput
}

func (ClusterState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterState)(nil)).Elem()
}

type clusterArgs struct {
	// A list of the desired control plane logging to enable. For more information, see [Amazon EKS Control Plane Logging](https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
	EnabledClusterLogTypes []string `pulumi:"enabledClusterLogTypes"`
	// Configuration block with encryption configuration for the cluster. Only available on Kubernetes 1.13 and above clusters created after March 6, 2020. Detailed below.
	EncryptionConfig *ClusterEncryptionConfig `pulumi:"encryptionConfig"`
	// Name of the cluster.
	Name *string `pulumi:"name"`
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding [`dependsOn`](https://www.terraform.io/docs/configuration/resources.html#depends_on-explicit-resource-dependencies) if using the [`iam.RolePolicy` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy.html) or [`iam.RolePolicyAttachment` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy_attachment.html), otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.
	RoleArn string `pulumi:"roleArn"`
	// Key-value mapping of resource tags.
	Tags map[string]interface{} `pulumi:"tags"`
	// Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.
	Version *string `pulumi:"version"`
	// Nested argument for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see [Cluster VPC Considerations](https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html) and [Cluster Security Group Considerations](https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html) in the Amazon EKS User Guide. Configuration detailed below.
	VpcConfig ClusterVpcConfig `pulumi:"vpcConfig"`
}

// The set of arguments for constructing a Cluster resource.
type ClusterArgs struct {
	// A list of the desired control plane logging to enable. For more information, see [Amazon EKS Control Plane Logging](https://docs.aws.amazon.com/eks/latest/userguide/control-plane-logs.html)
	EnabledClusterLogTypes pulumi.StringArrayInput
	// Configuration block with encryption configuration for the cluster. Only available on Kubernetes 1.13 and above clusters created after March 6, 2020. Detailed below.
	EncryptionConfig ClusterEncryptionConfigPtrInput
	// Name of the cluster.
	Name pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) of the IAM role that provides permissions for the Kubernetes control plane to make calls to AWS API operations on your behalf. Ensure the resource configuration includes explicit dependencies on the IAM Role permissions by adding [`dependsOn`](https://www.terraform.io/docs/configuration/resources.html#depends_on-explicit-resource-dependencies) if using the [`iam.RolePolicy` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy.html) or [`iam.RolePolicyAttachment` resource](https://www.terraform.io/docs/providers/aws/r/iam_role_policy_attachment.html), otherwise EKS cannot delete EKS managed EC2 infrastructure such as Security Groups on EKS Cluster deletion.
	RoleArn pulumi.StringInput
	// Key-value mapping of resource tags.
	Tags pulumi.MapInput
	// Desired Kubernetes master version. If you do not specify a value, the latest available version at resource creation is used and no upgrades will occur except those automatically triggered by EKS. The value must be configured and increased to upgrade the version when desired. Downgrades are not supported by EKS.
	Version pulumi.StringPtrInput
	// Nested argument for the VPC associated with your cluster. Amazon EKS VPC resources have specific requirements to work properly with Kubernetes. For more information, see [Cluster VPC Considerations](https://docs.aws.amazon.com/eks/latest/userguide/network_reqs.html) and [Cluster Security Group Considerations](https://docs.aws.amazon.com/eks/latest/userguide/sec-group-reqs.html) in the Amazon EKS User Guide. Configuration detailed below.
	VpcConfig ClusterVpcConfigInput
}

func (ClusterArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterArgs)(nil)).Elem()
}
