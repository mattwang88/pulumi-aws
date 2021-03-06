// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package neptune

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// A Cluster Instance Resource defines attributes that are specific to a single instance in a Neptune Cluster.
//
// You can simply add neptune instances and Neptune manages the replication. You can use the [count][1]
// meta-parameter to make multiple instances and join them all to the same Neptune Cluster, or you may specify different Cluster Instance resources with various `instanceClass` sizes.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/neptune_cluster_instance.html.markdown.
type ClusterInstance struct {
	pulumi.CustomResourceState

	// The hostname of the instance. See also `endpoint` and `port`.
	Address pulumi.StringOutput `pulumi:"address"`
	// Specifies whether any instance modifications
	// are applied immediately, or during the next maintenance window. Default is`false`.
	ApplyImmediately pulumi.BoolOutput `pulumi:"applyImmediately"`
	// Amazon Resource Name (ARN) of neptune instance
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is `true`.
	AutoMinorVersionUpgrade pulumi.BoolPtrOutput `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the neptune instance is created in.
	AvailabilityZone pulumi.StringOutput `pulumi:"availabilityZone"`
	// The identifier of the [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html) in which to launch this instance.
	ClusterIdentifier pulumi.StringOutput `pulumi:"clusterIdentifier"`
	// The region-unique, immutable identifier for the neptune instance.
	DbiResourceId pulumi.StringOutput `pulumi:"dbiResourceId"`
	// The connection endpoint in `address:port` format.
	Endpoint pulumi.StringOutput `pulumi:"endpoint"`
	// The name of the database engine to be used for the neptune instance. Defaults to `neptune`. Valid Values: `neptune`.
	Engine pulumi.StringPtrOutput `pulumi:"engine"`
	// The neptune engine version.
	EngineVersion pulumi.StringOutput `pulumi:"engineVersion"`
	// The indentifier for the neptune instance, if omitted, this provider will assign a random, unique identifier.
	Identifier pulumi.StringOutput `pulumi:"identifier"`
	// Creates a unique identifier beginning with the specified prefix. Conflicts with `identifier`.
	IdentifierPrefix pulumi.StringOutput `pulumi:"identifierPrefix"`
	// The instance class to use.
	InstanceClass pulumi.StringOutput `pulumi:"instanceClass"`
	// The ARN for the KMS encryption key if one is set to the neptune cluster.
	KmsKeyArn pulumi.StringOutput `pulumi:"kmsKeyArn"`
	// The name of the neptune parameter group to associate with this instance.
	NeptuneParameterGroupName pulumi.StringPtrOutput `pulumi:"neptuneParameterGroupName"`
	// A subnet group to associate with this neptune instance. **NOTE:** This must match the `neptuneSubnetGroupName` of the attached [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html).
	NeptuneSubnetGroupName pulumi.StringOutput `pulumi:"neptuneSubnetGroupName"`
	// The port on which the DB accepts connections. Defaults to `8182`.
	Port pulumi.IntPtrOutput `pulumi:"port"`
	// The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"
	PreferredBackupWindow pulumi.StringOutput `pulumi:"preferredBackupWindow"`
	// The window to perform maintenance in.
	// Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".
	PreferredMaintenanceWindow pulumi.StringOutput `pulumi:"preferredMaintenanceWindow"`
	// Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.
	PromotionTier pulumi.IntPtrOutput `pulumi:"promotionTier"`
	// Bool to control if instance is publicly accessible. Default is `false`.
	PubliclyAccessible pulumi.BoolPtrOutput `pulumi:"publiclyAccessible"`
	// Specifies whether the neptune cluster is encrypted.
	StorageEncrypted pulumi.BoolOutput `pulumi:"storageEncrypted"`
	// A mapping of tags to assign to the instance.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Boolean indicating if this instance is writable. `False` indicates this instance is a read replica.
	Writer pulumi.BoolOutput `pulumi:"writer"`
}

// NewClusterInstance registers a new resource with the given unique name, arguments, and options.
func NewClusterInstance(ctx *pulumi.Context,
	name string, args *ClusterInstanceArgs, opts ...pulumi.ResourceOption) (*ClusterInstance, error) {
	if args == nil || args.ClusterIdentifier == nil {
		return nil, errors.New("missing required argument 'ClusterIdentifier'")
	}
	if args == nil || args.InstanceClass == nil {
		return nil, errors.New("missing required argument 'InstanceClass'")
	}
	if args == nil {
		args = &ClusterInstanceArgs{}
	}
	var resource ClusterInstance
	err := ctx.RegisterResource("aws:neptune/clusterInstance:ClusterInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetClusterInstance gets an existing ClusterInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetClusterInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ClusterInstanceState, opts ...pulumi.ResourceOption) (*ClusterInstance, error) {
	var resource ClusterInstance
	err := ctx.ReadResource("aws:neptune/clusterInstance:ClusterInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ClusterInstance resources.
type clusterInstanceState struct {
	// The hostname of the instance. See also `endpoint` and `port`.
	Address *string `pulumi:"address"`
	// Specifies whether any instance modifications
	// are applied immediately, or during the next maintenance window. Default is`false`.
	ApplyImmediately *bool `pulumi:"applyImmediately"`
	// Amazon Resource Name (ARN) of neptune instance
	Arn *string `pulumi:"arn"`
	// Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is `true`.
	AutoMinorVersionUpgrade *bool `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the neptune instance is created in.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The identifier of the [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html) in which to launch this instance.
	ClusterIdentifier *string `pulumi:"clusterIdentifier"`
	// The region-unique, immutable identifier for the neptune instance.
	DbiResourceId *string `pulumi:"dbiResourceId"`
	// The connection endpoint in `address:port` format.
	Endpoint *string `pulumi:"endpoint"`
	// The name of the database engine to be used for the neptune instance. Defaults to `neptune`. Valid Values: `neptune`.
	Engine *string `pulumi:"engine"`
	// The neptune engine version.
	EngineVersion *string `pulumi:"engineVersion"`
	// The indentifier for the neptune instance, if omitted, this provider will assign a random, unique identifier.
	Identifier *string `pulumi:"identifier"`
	// Creates a unique identifier beginning with the specified prefix. Conflicts with `identifier`.
	IdentifierPrefix *string `pulumi:"identifierPrefix"`
	// The instance class to use.
	InstanceClass *string `pulumi:"instanceClass"`
	// The ARN for the KMS encryption key if one is set to the neptune cluster.
	KmsKeyArn *string `pulumi:"kmsKeyArn"`
	// The name of the neptune parameter group to associate with this instance.
	NeptuneParameterGroupName *string `pulumi:"neptuneParameterGroupName"`
	// A subnet group to associate with this neptune instance. **NOTE:** This must match the `neptuneSubnetGroupName` of the attached [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html).
	NeptuneSubnetGroupName *string `pulumi:"neptuneSubnetGroupName"`
	// The port on which the DB accepts connections. Defaults to `8182`.
	Port *int `pulumi:"port"`
	// The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"
	PreferredBackupWindow *string `pulumi:"preferredBackupWindow"`
	// The window to perform maintenance in.
	// Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.
	PromotionTier *int `pulumi:"promotionTier"`
	// Bool to control if instance is publicly accessible. Default is `false`.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// Specifies whether the neptune cluster is encrypted.
	StorageEncrypted *bool `pulumi:"storageEncrypted"`
	// A mapping of tags to assign to the instance.
	Tags map[string]interface{} `pulumi:"tags"`
	// Boolean indicating if this instance is writable. `False` indicates this instance is a read replica.
	Writer *bool `pulumi:"writer"`
}

type ClusterInstanceState struct {
	// The hostname of the instance. See also `endpoint` and `port`.
	Address pulumi.StringPtrInput
	// Specifies whether any instance modifications
	// are applied immediately, or during the next maintenance window. Default is`false`.
	ApplyImmediately pulumi.BoolPtrInput
	// Amazon Resource Name (ARN) of neptune instance
	Arn pulumi.StringPtrInput
	// Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is `true`.
	AutoMinorVersionUpgrade pulumi.BoolPtrInput
	// The EC2 Availability Zone that the neptune instance is created in.
	AvailabilityZone pulumi.StringPtrInput
	// The identifier of the [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html) in which to launch this instance.
	ClusterIdentifier pulumi.StringPtrInput
	// The region-unique, immutable identifier for the neptune instance.
	DbiResourceId pulumi.StringPtrInput
	// The connection endpoint in `address:port` format.
	Endpoint pulumi.StringPtrInput
	// The name of the database engine to be used for the neptune instance. Defaults to `neptune`. Valid Values: `neptune`.
	Engine pulumi.StringPtrInput
	// The neptune engine version.
	EngineVersion pulumi.StringPtrInput
	// The indentifier for the neptune instance, if omitted, this provider will assign a random, unique identifier.
	Identifier pulumi.StringPtrInput
	// Creates a unique identifier beginning with the specified prefix. Conflicts with `identifier`.
	IdentifierPrefix pulumi.StringPtrInput
	// The instance class to use.
	InstanceClass pulumi.StringPtrInput
	// The ARN for the KMS encryption key if one is set to the neptune cluster.
	KmsKeyArn pulumi.StringPtrInput
	// The name of the neptune parameter group to associate with this instance.
	NeptuneParameterGroupName pulumi.StringPtrInput
	// A subnet group to associate with this neptune instance. **NOTE:** This must match the `neptuneSubnetGroupName` of the attached [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html).
	NeptuneSubnetGroupName pulumi.StringPtrInput
	// The port on which the DB accepts connections. Defaults to `8182`.
	Port pulumi.IntPtrInput
	// The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"
	PreferredBackupWindow pulumi.StringPtrInput
	// The window to perform maintenance in.
	// Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.
	PromotionTier pulumi.IntPtrInput
	// Bool to control if instance is publicly accessible. Default is `false`.
	PubliclyAccessible pulumi.BoolPtrInput
	// Specifies whether the neptune cluster is encrypted.
	StorageEncrypted pulumi.BoolPtrInput
	// A mapping of tags to assign to the instance.
	Tags pulumi.MapInput
	// Boolean indicating if this instance is writable. `False` indicates this instance is a read replica.
	Writer pulumi.BoolPtrInput
}

func (ClusterInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterInstanceState)(nil)).Elem()
}

type clusterInstanceArgs struct {
	// Specifies whether any instance modifications
	// are applied immediately, or during the next maintenance window. Default is`false`.
	ApplyImmediately *bool `pulumi:"applyImmediately"`
	// Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is `true`.
	AutoMinorVersionUpgrade *bool `pulumi:"autoMinorVersionUpgrade"`
	// The EC2 Availability Zone that the neptune instance is created in.
	AvailabilityZone *string `pulumi:"availabilityZone"`
	// The identifier of the [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html) in which to launch this instance.
	ClusterIdentifier string `pulumi:"clusterIdentifier"`
	// The name of the database engine to be used for the neptune instance. Defaults to `neptune`. Valid Values: `neptune`.
	Engine *string `pulumi:"engine"`
	// The neptune engine version.
	EngineVersion *string `pulumi:"engineVersion"`
	// The indentifier for the neptune instance, if omitted, this provider will assign a random, unique identifier.
	Identifier *string `pulumi:"identifier"`
	// Creates a unique identifier beginning with the specified prefix. Conflicts with `identifier`.
	IdentifierPrefix *string `pulumi:"identifierPrefix"`
	// The instance class to use.
	InstanceClass string `pulumi:"instanceClass"`
	// The name of the neptune parameter group to associate with this instance.
	NeptuneParameterGroupName *string `pulumi:"neptuneParameterGroupName"`
	// A subnet group to associate with this neptune instance. **NOTE:** This must match the `neptuneSubnetGroupName` of the attached [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html).
	NeptuneSubnetGroupName *string `pulumi:"neptuneSubnetGroupName"`
	// The port on which the DB accepts connections. Defaults to `8182`.
	Port *int `pulumi:"port"`
	// The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"
	PreferredBackupWindow *string `pulumi:"preferredBackupWindow"`
	// The window to perform maintenance in.
	// Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".
	PreferredMaintenanceWindow *string `pulumi:"preferredMaintenanceWindow"`
	// Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.
	PromotionTier *int `pulumi:"promotionTier"`
	// Bool to control if instance is publicly accessible. Default is `false`.
	PubliclyAccessible *bool `pulumi:"publiclyAccessible"`
	// A mapping of tags to assign to the instance.
	Tags map[string]interface{} `pulumi:"tags"`
}

// The set of arguments for constructing a ClusterInstance resource.
type ClusterInstanceArgs struct {
	// Specifies whether any instance modifications
	// are applied immediately, or during the next maintenance window. Default is`false`.
	ApplyImmediately pulumi.BoolPtrInput
	// Indicates that minor engine upgrades will be applied automatically to the instance during the maintenance window. Default is `true`.
	AutoMinorVersionUpgrade pulumi.BoolPtrInput
	// The EC2 Availability Zone that the neptune instance is created in.
	AvailabilityZone pulumi.StringPtrInput
	// The identifier of the [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html) in which to launch this instance.
	ClusterIdentifier pulumi.StringInput
	// The name of the database engine to be used for the neptune instance. Defaults to `neptune`. Valid Values: `neptune`.
	Engine pulumi.StringPtrInput
	// The neptune engine version.
	EngineVersion pulumi.StringPtrInput
	// The indentifier for the neptune instance, if omitted, this provider will assign a random, unique identifier.
	Identifier pulumi.StringPtrInput
	// Creates a unique identifier beginning with the specified prefix. Conflicts with `identifier`.
	IdentifierPrefix pulumi.StringPtrInput
	// The instance class to use.
	InstanceClass pulumi.StringInput
	// The name of the neptune parameter group to associate with this instance.
	NeptuneParameterGroupName pulumi.StringPtrInput
	// A subnet group to associate with this neptune instance. **NOTE:** This must match the `neptuneSubnetGroupName` of the attached [`neptune.Cluster`](https://www.terraform.io/docs/providers/aws/r/neptune_cluster.html).
	NeptuneSubnetGroupName pulumi.StringPtrInput
	// The port on which the DB accepts connections. Defaults to `8182`.
	Port pulumi.IntPtrInput
	// The daily time range during which automated backups are created if automated backups are enabled. Eg: "04:00-09:00"
	PreferredBackupWindow pulumi.StringPtrInput
	// The window to perform maintenance in.
	// Syntax: "ddd:hh24:mi-ddd:hh24:mi". Eg: "Mon:00:00-Mon:03:00".
	PreferredMaintenanceWindow pulumi.StringPtrInput
	// Default 0. Failover Priority setting on instance level. The reader who has lower tier has higher priority to get promoter to writer.
	PromotionTier pulumi.IntPtrInput
	// Bool to control if instance is publicly accessible. Default is `false`.
	PubliclyAccessible pulumi.BoolPtrInput
	// A mapping of tags to assign to the instance.
	Tags pulumi.MapInput
}

func (ClusterInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*clusterInstanceArgs)(nil)).Elem()
}
